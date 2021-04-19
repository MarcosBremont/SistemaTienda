﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTienda.Pantallas
{
    public partial class FrmRecuperarContraseña : Form
    {
        public FrmRecuperarContraseña()
        {
            InitializeComponent();
        }

        String cs = ("Server=localhost; database=SistemaTienda; user=root; password=1234");
        private void BtnEnviar_Click(object sender, EventArgs e)
        {

        }

        public void EnviarCorreo()
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Introduzca su Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                DataSet ds = new DataSet();
                MySqlConnection con = new MySqlConnection(cs);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Contrasena FROM usuario Where Email = '" + txtEmail.Text + "'", con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MailMessage Msg = new MailMessage();
                    // Sender e-mail address.
                    Msg.From = new MailAddress("LofiSoftware00@gmail.com");
                    // Recipient e-mail address.
                    Msg.To.Add(txtEmail.Text);
                    Msg.Subject = "Detalles de tu cuenta";
                    Msg.Body = "Hola, tú Contraseña es: (" + Convert.ToString(ds.Tables[0].Rows[0]["Contrasena"]) + "), Por favor guarda bien tu contraseña y no la compartas con mas nadie.";
                    Msg.IsBodyHtml = true;
                    // your remote SMTP server IP.
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("LofiSoftware00@gmail.com", "Marcosjb1");
                    smtp.EnableSsl = true;
                    smtp.Send(Msg);
                    MessageBox.Show(("La Contraseña se envio Exitosamente " + ("\r\n" + "Por favor verifique la bendeja de entrada de su correo")), "Gracias", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frml = new FrmLogin();
            frml.Show();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = false;
                EnviarCorreo();
            }
        }
    }
}
