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
    public partial class FrmCambiarContraseña : Form
    {
        public FrmCambiarContraseña()
        {
            InitializeComponent();
        }

        MySqlConnection con = null;
        MySqlCommand cmd = null;

        String cs = ("Server=localhost; database=SistemaTienda; user=root; password=1234");

        private void FrmCambiarContraseña_Load(object sender, EventArgs e)
        {
            lblUsuario.Visible = true;
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            try
            {
                int RowsAffected = 0;
                if ((txtUsuario.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Por favor introduzca el nombre de Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }
                if ((txtViejaContraseña.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Por favor introduzca la vieja contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtViejaContraseña.Focus();
                    return;
                }
                if ((txtNuevaContraseña.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Por favor introduzca la nueva contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNuevaContraseña.Focus();
                    return;
                }
                if ((txtConfirmarContraseña.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Por favor confirme la nueva contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmarContraseña.Focus();
                    return;
                }
                if ((txtNuevaContraseña.TextLength < 5))
                {
                    MessageBox.Show("La nueva contraseña debe de ser mayor a 4 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNuevaContraseña.Text = "";
                    txtConfirmarContraseña.Text = "";
                    txtNuevaContraseña.Focus();
                    return;
                }
                else if ((txtNuevaContraseña.Text != txtConfirmarContraseña.Text))
                {
                    MessageBox.Show("La contraseña no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNuevaContraseña.Text = "";
                    txtViejaContraseña.Text = "";
                    txtConfirmarContraseña.Text = "";
                    txtViejaContraseña.Focus();
                    return;
                }
                else if ((txtViejaContraseña.Text == txtNuevaContraseña.Text))
                {
                    MessageBox.Show("La contraseña introducida es la misma, por favor itroduzca otra contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNuevaContraseña.Text = "";
                    txtConfirmarContraseña.Text = "";
                    txtNuevaContraseña.Focus();
                    return;
                }

                con = new MySqlConnection(cs);
                con.Open();
                string co = "Update usuario set Contrasena = '" + txtNuevaContraseña.Text + "'where Usuario='" + txtUsuario.Text + "' and Contrasena = '" + txtViejaContraseña.Text + "'";

                cmd = new MySqlCommand(co);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                if ((RowsAffected > 0))
                {
                    MessageBox.Show("La contraseña se ha cambiado correctamente", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    txtUsuario.Text = "";
                    txtNuevaContraseña.Text = "";
                    txtViejaContraseña.Text = "";
                    txtConfirmarContraseña.Text = "";
                    FrmLogin LoginForm1 = new FrmLogin();
                    LoginForm1.Show();

                }
                else
                {
                    MessageBox.Show("Nombre de Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtNuevaContraseña.Text = "";
                    txtViejaContraseña.Text = "";
                    txtConfirmarContraseña.Text = "";
                    txtUsuario.Focus();
                }
                if ((con.State == ConnectionState.Open))
                {
                    con.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
        }

        private void txtViejaContraseña_Enter(object sender, EventArgs e)
        {
            if (txtViejaContraseña.Text == "Contraseña Actual")
            {
                txtViejaContraseña.Text = "";
                txtViejaContraseña.ForeColor = Color.White;
            }
        }

        private void txtViejaContraseña_Leave(object sender, EventArgs e)
        {
            if (txtViejaContraseña.Text == "")
            {
                txtViejaContraseña.Text = "Contraseña Actual";
                txtViejaContraseña.ForeColor = Color.White;
            }
        }

        private void txtNuevaContraseña_Enter(object sender, EventArgs e)
        {
            if (txtNuevaContraseña.Text == "Nueva Contraseña")
            {
                txtNuevaContraseña.Text = "";
                txtNuevaContraseña.ForeColor = Color.White;
            }
        }

        private void txtNuevaContraseña_Leave(object sender, EventArgs e)
        {
            if (txtNuevaContraseña.Text == "")
            {
                txtNuevaContraseña.Text = "Nueva Contraseña";
                txtNuevaContraseña.ForeColor = Color.White;
            }
        }

        private void txtConfirmarContraseña_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarContraseña.Text == "Confirmar Contraseña")
            {
                txtConfirmarContraseña.Text = "";
                txtConfirmarContraseña.ForeColor = Color.White;
            }
        }

        private void txtConfirmarContraseña_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarContraseña.Text == "")
            {
                txtConfirmarContraseña.Text = "Confirmar Contraseña";
                txtConfirmarContraseña.ForeColor = Color.White;
            }
        }

        private void BtnVolverAtras_Click(object sender, EventArgs e)
        {
            FrmLogin frml = new FrmLogin();
            frml.Show();
            this.Hide();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
        }

        private void txtViejaContraseña_Click(object sender, EventArgs e)
        {
            lblcontrasenaactual.Visible = true;
        }

        private void txtViejaContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
