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
    public partial class FrmInventario : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=SistemaTienda; user=root; password=1234");
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarDgvInventario();
        }

        public void CargarDgvInventario()
        {
            try
            {
                MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from producto", con);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvInventario.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de cargar los datos, comuniquese con soporte");
            }
        }

        private void txtbuscarpornombredelproducto_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM producto where nombre_pro like ('" + txtbuscarpornombredelproducto.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dgvInventario.DataSource = dt;

            con.Close();
        }

        private void txtbuscarporcategoria_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM producto where categoria_pro like ('" + txtbuscarporcategoria.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgvInventario.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de buscar los datos, comuniquese con soporte");
            }
           
        }

        private void txtbuscarporcodigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM producto where id_producto like ('" + txtbuscarporcodigo.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgvInventario.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de buscar los datos, comuniquese con soporte");
            }
            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmEditarProductos frme = new FrmEditarProductos();
            frme.Show();
            this.Close();
        }

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInventario.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
