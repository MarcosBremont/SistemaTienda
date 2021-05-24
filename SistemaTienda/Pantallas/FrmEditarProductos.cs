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
    public partial class FrmEditarProductos : Form
    {
        Conexion conexion = new Conexion();
        public FrmEditarProductos()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtidproducto.Text = "";
            txtnombreproducto.Text = "";
            cmbCategoria.Text = "";
            txtprecio.Text = "";
            txtcantidad.Text = "";
            txtcompra.Text = "";
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Conectar();
                string query = "INSERT INTO producto (nombre_pro, categoria_pro, precio_pro, compra_pro, cantidad_pro) values (@nombre_pro, @categoria_pro, @precio_pro, @compra_pro, @cantidad_pro)";
                MySqlCommand comando = new MySqlCommand(query, conexion.GetCon());
                comando.Parameters.AddWithValue("@nombre_pro", txtnombreproducto.Text);
                comando.Parameters.AddWithValue("@categoria_pro", cmbCategoria.Text);
                comando.Parameters.AddWithValue("@precio_pro", txtprecio.Text);
                comando.Parameters.AddWithValue("@compra_pro", txtcompra.Text);
                comando.Parameters.AddWithValue("@cantidad_pro", txtcantidad.Text);
                comando.ExecuteNonQuery();
                CargarDgvStock();
                MessageBox.Show("Producto Agregado al Stock");
                 conexion.Desconectar();
                clear();
                this.txtcantidaddeproductos.Text = this.dgvStock.Rows.Count.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de guardar los datos, comuniquese con soporte");
            }
           
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            clear();
            this.txtcantidaddeproductos.Text = this.dgvStock.Rows.Count.ToString("N0");
        }

        private void txtbuscarpornombredelproducto_KeyUp(object sender, KeyEventArgs e)
        {
            conexion.Conectar();

            MySqlCommand cmd = conexion.GetCon().CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM producto where nombre_pro like ('%" + txtbuscarpornombredelproducto.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dgvStock.DataSource = dt;

             conexion.Desconectar();
        }

        public void CargarDgvStock()
        {
            try
            {
                MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from producto", conexion.GetCon());
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvStock.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de cargar los datos, comuniquese con soporte");
            }
           
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidproducto.Text = dgvStock.CurrentRow.Cells[0].Value.ToString();
            txtnombreproducto.Text = dgvStock.CurrentRow.Cells[1].Value.ToString();
            cmbCategoria.Text = dgvStock.CurrentRow.Cells[2].Value.ToString();
            txtprecio.Text = dgvStock.CurrentRow.Cells[3].Value.ToString();
            txtcompra.Text = dgvStock.CurrentRow.Cells[4].Value.ToString();
            txtcantidad.Text = dgvStock.CurrentRow.Cells[5].Value.ToString();
        }

        private void FrmEditarProductos_Load(object sender, EventArgs e)
        {
            CargarDgvStock();
            CARGARCOMBOBOXCATEGORIA();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Conectar();
                DialogResult result = MessageBox.Show("¿Estas seguro que quiere eliminar este producto?.", "ATENCION", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM producto Where id_producto = @id_producto";
                    MySqlCommand comando = new MySqlCommand(query, conexion.GetCon());
                    comando.Parameters.AddWithValue("@id_producto", txtidproducto.Text);
                    comando.ExecuteNonQuery();
                    CargarDgvStock();
                    MessageBox.Show("Producto Eliminado");
                     conexion.Desconectar();
                    clear();
                }
                else
                {

                }
                this.txtcantidaddeproductos.Text = this.dgvStock.Rows.Count.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de eliminar los datos, comuniquese con soporte");
            }
            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Conectar();
                string query = "UPDATE producto SET nombre_pro = @nombre_pro, categoria_pro = @categoria_pro, precio_pro = @precio_pro, compra_pro = @compra_pro, cantidad_pro = @cantidad_pro where id_producto=@id_producto";
                MySqlCommand comando = new MySqlCommand(query, conexion.GetCon());
                comando.Parameters.AddWithValue("@id_producto", txtidproducto.Text);
                comando.Parameters.AddWithValue("@nombre_pro", txtnombreproducto.Text);
                comando.Parameters.AddWithValue("@categoria_pro", cmbCategoria.Text);
                comando.Parameters.AddWithValue("@precio_pro", txtprecio.Text);
                comando.Parameters.AddWithValue("@compra_pro", txtcompra.Text);
                comando.Parameters.AddWithValue("@cantidad_pro", txtcantidad.Text);
                comando.ExecuteNonQuery();
                CargarDgvStock();
                MessageBox.Show("Producto Actualizado");
                 conexion.Desconectar();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de actualizar los datos, comuniquese con soporte");
            }
           
        }

        public void CARGARCOMBOBOXCATEGORIA()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM categoria", conexion.GetCon());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCategoria.ValueMember = "IDCategoria";
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.DataSource = dt;
        }
    }
}
