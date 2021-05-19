using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTienda.Pantallas
{
    public partial class FrmLogin : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        MySqlCommand cmd;
        MySqlDataReader dr;

        String cs = ("Server=localhost; database=SistemaTienda; user=root; password=1234");
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            cbRol.Focus();
            cbRol.Text = "Seleccione un rol";
           
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        public void Ingresar()
        {

            if (cbRol.Text == "")
            {
                MessageBox.Show("Por favor seleccione un Rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbRol.Focus();
                return;
            }


            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Por favor introduzca su nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }
            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Por favor introduzca su contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                return;
            }


            try
            {
                MySqlConnection myConnection = default(MySqlConnection);
                myConnection = new MySqlConnection(cs);

                MySqlCommand myCommand = default(MySqlCommand);

                myCommand = new MySqlCommand("SELECT Role, Usuario,Contrasena FROM usuario WHERE Role = @Role AND Usuario = @Usuario AND Contrasena = @Contrasena", myConnection);
                MySqlParameter uRole = new MySqlParameter("@Role", MySqlDbType.VarChar);
                MySqlParameter uName = new MySqlParameter("@Usuario", MySqlDbType.VarChar);
                MySqlParameter uPassword = new MySqlParameter("@Contrasena", MySqlDbType.VarChar);

                uRole.Value = cbRol.Text;
                uName.Value = txtUsuario.Text;
                uPassword.Value = txtContraseña.Text;
                myCommand.Parameters.Add(uRole);
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);


                myCommand.Connection.Open();

                MySqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);


                #region
                if (myReader.Read() == true)
                {
                    int i;

                    ProgressBar1.Visible = true;
                    ProgressBar1.Maximum = 800;
                    ProgressBar1.Minimum = 0;
                    ProgressBar1.Value = 4;
                    ProgressBar1.Step = 1;

                    for (i = 0; i <= 5000; i++)
                    {
                        ProgressBar1.PerformStep();
                    }

                    this.Hide();
                    FrmPrincipal frm = new FrmPrincipal();
                    //Logged in as (Role)
                    frm.Show();
                    frm.lblusuario.Text = cbRol.Text;
                    frm.txtFacturadoPor.Text = cbRol.Text;

                    if (cbRol.SelectedItem == "Empleado") frm.usuariosToolStripMenuItem.Visible = false;


                }



                #endregion


                else
                {

                    MessageBox.Show("El inicio de sesion fallo, por favor verifique los datos correctamente!", "Inicio de sesion fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //txtUsuario.Clear();
                    //txtContraseña.Clear();

                    cbRol.Enabled = true;
                    txtUsuario.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de iniciar sesion, por favor comuniquese con soporte");
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = false;

            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Ingresar();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmCambiarContraseña frm = new FrmCambiarContraseña();
            frm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmRecuperarContraseña frm = new FrmRecuperarContraseña();
            frm.txtEmail.Focus();
            frm.Show();
        }

        private void pictureBoxLogoTic_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Black;
            }
        }
    }
}
