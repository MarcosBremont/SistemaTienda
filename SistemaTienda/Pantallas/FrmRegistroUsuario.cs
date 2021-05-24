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
    public partial class FrmRegistroUsuario : Form
    {
        MySqlDataReader rdr = null;
        DataTable dt = new DataTable();

        MySqlCommand cmd = null;

        Conexion conexion = new Conexion();
        public FrmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {
            CargarDgvUsuariosRegistrados();
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Por favor introduzca el nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }
                conexion.Conectar();
                string ct = "select Usuario from usuario where Usuario='" + txtUsuario.Text + "'";

                cmd = new MySqlCommand(ct);
                cmd.Connection = conexion.GetCon();
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Usuario no disponible", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!rdr.Read())
                {
                    MessageBox.Show("Usuario disponible", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();

                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             conexion.Desconectar();
        }
        public void clear()
        {
            TXTID.Text = "";
            txtNombre.Text = "";
            txtContrasena.Text = "";
            txtEmail.Text = "";
            txtNumeroDeContacto.Text = "";
            txtUsuario.Text = "";

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Conectar();
                string query = "INSERT INTO usuario (Nombre, Role, Usuario, Contrasena, NDeContacto, Email) values (@Nombre, @Role, @Usuario, @Contrasena, @NDeContacto, @Email)";
                MySqlCommand comando = new MySqlCommand(query, conexion.GetCon());
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Role", comboRoles.Text);
                comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                comando.Parameters.AddWithValue("@NDeContacto", txtNumeroDeContacto.Text);
                comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                comando.ExecuteNonQuery();
                 conexion.Desconectar();
                CargarDgvUsuariosRegistrados();
                MessageBox.Show("Usuario Agregado exitosamente");

                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de guardar los datos, comuniquese con soporte");
            }
           
        }

        public void CargarDgvUsuariosRegistrados()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from usuario", conexion.GetCon());
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvUsuariosRegistrados.DataSource = tabla;

        }

        private void dgvUsuariosRegistrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTID.Text = dgvUsuariosRegistrados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvUsuariosRegistrados.CurrentRow.Cells[1].Value.ToString();
            comboRoles.Text = dgvUsuariosRegistrados.CurrentRow.Cells[2].Value.ToString();
            txtUsuario.Text = dgvUsuariosRegistrados.CurrentRow.Cells[3].Value.ToString();
            txtContrasena.Text = dgvUsuariosRegistrados.CurrentRow.Cells[4].Value.ToString();
            txtNumeroDeContacto.Text = dgvUsuariosRegistrados.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dgvUsuariosRegistrados.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Conectar();
                string query = "UPDATE usuario SET Nombre = @Nombre, Role = @Role, Usuario = @Usuario, Contrasena = @Contrasena, NDeContacto = @NDeContacto, Email = @Email where idusuario=@idusuario";
                MySqlCommand comando = new MySqlCommand(query, conexion.GetCon());
                comando.Parameters.AddWithValue("@idusuario", TXTID.Text);
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Role", comboRoles.Text);
                comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                comando.Parameters.AddWithValue("@NDeContacto", txtNumeroDeContacto.Text);
                comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                comando.ExecuteNonQuery();
                CargarDgvUsuariosRegistrados();
                MessageBox.Show("Usuario Actualizado");
                 conexion.Desconectar();
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de actualizar los datos, comuniquese con soporte");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Conectar();
                DialogResult result = MessageBox.Show("¿Estas seguro que quiere eliminar este Usuario?.", "ATENCION", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM usuario Where idusuario = @idusuario";
                    MySqlCommand comando = new MySqlCommand(query, conexion.GetCon());
                    comando.Parameters.AddWithValue("@idusuario", TXTID.Text);
                    comando.ExecuteNonQuery();
                    CargarDgvUsuariosRegistrados();
                    MessageBox.Show("Usuario Eliminado");
                     conexion.Desconectar();
                    clear();
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de eliminar los datos, comuniquese con soporte");
            }
            

        }

        private void dgvUsuariosRegistrados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtContrasena.PasswordChar = default(char);
            }

            else
            {
                txtContrasena.PasswordChar = char.Parse("*");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
