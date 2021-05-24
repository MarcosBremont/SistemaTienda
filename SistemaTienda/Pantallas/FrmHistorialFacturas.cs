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
    public partial class FrmHistorialFacturas : Form
    {
        Conexion conexion = new Conexion();
        public FrmHistorialFacturas()
        {
            InitializeComponent();
        }

        private void FrmHistorialFacturas_Load(object sender, EventArgs e)
        {
            CargarDgvHistorialFactura();
        }

        public void CargarDgvHistorialFactura()
        {
            try
            {
                MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from historial_factura", conexion.GetCon());
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvHistorialFactura.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de cargar los datos, comuniquese con soporte");
            }
        }

        private void dgvHistorialFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDhistorialfactura.Text = dgvHistorialFactura.CurrentRow.Cells[0].Value.ToString();
                txtNombreproducto.Text = dgvHistorialFactura.CurrentRow.Cells[1].Value.ToString();
                txtprecioproducto.Text = dgvHistorialFactura.CurrentRow.Cells[2].Value.ToString();
                txtnombrecompleto.Text = dgvHistorialFactura.CurrentRow.Cells[3].Value.ToString();
                txtfacturado.Text = dgvHistorialFactura.CurrentRow.Cells[4].Value.ToString();
                txtcantidad.Text = dgvHistorialFactura.CurrentRow.Cells[5].Value.ToString();
                txttotal.Text = dgvHistorialFactura.CurrentRow.Cells[6].Value.ToString();
                dateTimePicker1.Text = dgvHistorialFactura.CurrentRow.Cells[7].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de cargar los datos, comuniquese con soporte");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Conectar();
                string query = "UPDATE historial_factura SET nombre_pro = @nombre_pro, precio_pro = @precio_pro, nombrecompleto = @nombrecompleto, facturado = @facturado, Cantidad = @Cantidad, total_calculo = @total_calculo, fechaFactura = @fechaFactura  where id_historial_factura=@id_historial_factura";
                MySqlCommand comando = new MySqlCommand(query, conexion.GetCon());
                comando.Parameters.AddWithValue("@id_historial_factura", txtIDhistorialfactura.Text);
                comando.Parameters.AddWithValue("@nombre_pro", txtNombreproducto.Text);
                comando.Parameters.AddWithValue("@precio_pro", txtprecioproducto.Text);
                comando.Parameters.AddWithValue("@nombrecompleto", txtnombrecompleto.Text);
                comando.Parameters.AddWithValue("@facturado", txtfacturado.Text);
                comando.Parameters.AddWithValue("@Cantidad", txtcantidad.Text);
                comando.Parameters.AddWithValue("@total_calculo", txttotal.Text);
                comando.Parameters.AddWithValue("@fechaFactura", dateTimePicker1.Value);
                comando.ExecuteNonQuery();
                MessageBox.Show("Factura Actualizada");
                CargarDgvHistorialFactura();
                 conexion.Desconectar();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de actualizar los datos, comuniquese con soporte");
            }
        }

        public void Clear()
        {
            txtIDhistorialfactura.Clear();
            txtNombreproducto.Clear();
            txtprecioproducto.Clear();
            txtnombrecompleto.Clear();
            txtfacturado.Clear();
            txtcantidad.Clear();
            txttotal.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Conectar();
                DialogResult result = MessageBox.Show("¿Estas seguro que quiere eliminar esta factura?", "ATENCION", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM historial_factura Where id_historial_factura = @id_historial_factura";
                    MySqlCommand comando = new MySqlCommand(query, conexion.GetCon());
                    comando.Parameters.AddWithValue("@id_historial_factura", txtIDhistorialfactura.Text);
                    comando.ExecuteNonQuery();
                    CargarDgvHistorialFactura();
                    MessageBox.Show("Factura Eliminada");
                     conexion.Desconectar();
                    Clear();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
