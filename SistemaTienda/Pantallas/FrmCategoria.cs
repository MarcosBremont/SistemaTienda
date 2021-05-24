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
    public partial class FrmCategoria : Form
    {
        Conexion conexion = new Conexion();

        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CARGARCOMBOBOXCATEGORIA();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCategoria.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Conectar();
                string query = "INSERT INTO categoria (NombreCategoria) values (@NombreCategoria)";
                MySqlCommand comando = new MySqlCommand(query, conexion.GetCon());
                comando.Parameters.AddWithValue("@NombreCategoria", txtCategoria.Text);
                comando.ExecuteNonQuery();
                CARGARCOMBOBOXCATEGORIA();
                MessageBox.Show("Categoria Agregada");
                 conexion.Desconectar();
                txtCategoria.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de guardar los datos, comuniquese con soporte");
            }
           
        }

        public void CARGARCOMBOBOXCATEGORIA()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM categoria", conexion.GetCon());
                DataTable dt = new DataTable();
                da.Fill(dt);
                CMBCategorias.ValueMember = "IDCategoria";
                CMBCategorias.DisplayMember = "NombreCategoria";
                CMBCategorias.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de cargar las categorias, comuniquese con soporte");
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Conectar();
                DialogResult result = MessageBox.Show("¿Estas seguro que quiere eliminar esta Categoria?", "ATENCION", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM categoria Where IDCategoria = @IDCategoria";
                    MySqlCommand comando = new MySqlCommand(query, conexion.GetCon());
                    comando.Parameters.AddWithValue("@IDCategoria", CMBCategorias.SelectedValue);
                    comando.ExecuteNonQuery();
                    CARGARCOMBOBOXCATEGORIA();
                    MessageBox.Show("Categoria Eliminada");
                     conexion.Desconectar();
                    txtCategoria.Clear();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un problema a la hora de eliminar los datos, comuniquese con soporte");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de eliminar los datos, comuniquese con soporte");
            }
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Conectar();
                string query = "UPDATE categoria SET NombreCategoria = @NombreCategoria where IDCategoria=@IDCategoria";
                MySqlCommand comando = new MySqlCommand(query, conexion.GetCon());
                comando.Parameters.AddWithValue("@IDCategoria", lblidcategoria.Text);
                comando.Parameters.AddWithValue("@NombreCategoria", txtCategoria.Text);
                comando.ExecuteNonQuery();
                CARGARCOMBOBOXCATEGORIA();
                MessageBox.Show("Categoria Actualizada");
                 conexion.Desconectar();
                txtCategoria.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de actualizar los datos, comuniquese con soporte");
            }
           
        }

        private void CMBCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblidcategoria.Text = Convert.ToString(CMBCategorias.SelectedValue);
        }
    }
}
