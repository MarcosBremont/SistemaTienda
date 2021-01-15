using MySql.Data.MySqlClient;
using SistemaTienda.Pantallas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTienda
{
    public partial class FrmPrincipal : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=SistemaTienda; user=root; password=1234");
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        
        private void BtnBuscarProductos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbuscarproducto.Text))
            {
                FrmInventario FrmI = new FrmInventario();
                FrmI.ShowDialog();

                if (FrmI.DialogResult == DialogResult.OK)
                {
                    txtCodigoPro.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[0].Value.ToString();
                    txtDescrip.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[1].Value.ToString();
                    txtPrecio.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[4].Value.ToString();
                    txtCantidad.Focus();
                    con.Close();
                }
                this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");

            }

            else
            {
                MySqlCommand cmd = new MySqlCommand(" SELECT * FROM producto where id_producto = @id_producto", con);
                cmd.Parameters.AddWithValue("id_producto", txtbuscarproducto.Text);

                con.Open();
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    txtCodigoPro.Text = registro["id_producto"].ToString();
                    txtDescrip.Text = registro["nombre_pro"].ToString();
                    txtPrecio.Text = registro["precio_pro"].ToString();
                    txtCantidad.Focus();

                }
                con.Close();

            }
        }
        public static int cont_fila = 0;
        public static double total;
        private void BtnColocar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int num_fila = 0;
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Debe introducir una cantidad del producto seleccionado");

                return;
            }
            else
            {
                if (cont_fila == 0)
                {
                    dgvFacturacion.Rows.Add(txtCodigoPro.Text, txtDescrip.Text, txtPrecio.Text, txtCantidad.Text);
                    double importe = Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[3].Value);
                    dgvFacturacion.Rows[cont_fila].Cells[6].Value = importe;
                    dgvFacturacion.Rows[cont_fila].Cells[4].Value = txtSeleccionarCLiente.Text;
                    dgvFacturacion.Rows[cont_fila].Cells[5].Value = cmbfacturara.Text;
                    cont_fila++;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dgvFacturacion.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == txtCodigoPro.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        dgvFacturacion.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dgvFacturacion.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dgvFacturacion.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dgvFacturacion.Rows[num_fila].Cells[3].Value);
                        dgvFacturacion.Rows[num_fila].Cells[6].Value = importe;
                    }
                    else
                    {
                        dgvFacturacion.Rows.Add(txtCodigoPro.Text, txtDescrip.Text, txtPrecio.Text, txtCantidad.Text);
                        double importe = Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[3].Value);
                        dgvFacturacion.Rows[cont_fila].Cells[6].Value = importe;
                        cont_fila++;
                    }
                }
                total = 0;
                foreach (DataGridViewRow Fila in dgvFacturacion.Rows)
                {
                    total += Convert.ToDouble(Fila.Cells[6].Value);
                }
                txtTotal.Text = "RD$" + total.ToString();
                txtSeleccionarCLiente.Focus();
                this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");
            }
        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSeleccionarCLiente.Text))
            {

                FrmCliente FrmC = new FrmCliente();
                FrmC.ShowDialog();

                if (FrmC.DialogResult == DialogResult.OK)
                {
                    txtSeleccionarCLiente.Text = FrmC.dgvCliente.Rows[FrmC.dgvCliente.CurrentRow.Index].Cells[1].Value.ToString();
                    con.Close();
                }
            }

            else
            {
                MySqlCommand cmd = new MySqlCommand(" SELECT * FROM cliente where IDCliente = @IDCliente", con);
                cmd.Parameters.AddWithValue("IDCliente", txtSeleccionarCLiente.Text);
                con.Open();
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    txtSeleccionarCLiente.Text = registro["NombreCompleto"].ToString();
                    txtclienteTemporal.Focus();

                }
                con.Close();
            }
        }
        public void Insertar()
        {
            foreach (DataGridViewRow row in dgvFacturacion.Rows)
            {
                string nombrepro = row.Cells["nombre_pro"].Value.ToString();
                int precio_pro = Convert.ToInt32(row.Cells["precio_pro"].Value);
                string nombrecompleto = row.Cells["nombrecompleto"].Value.ToString();
                string facturado = row.Cells["facturado"].Value.ToString();
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                int total_calculo = Convert.ToInt32(row.Cells["total_calculo"].Value);

                con.Open();
                string query = "INSERT INTO historial_factura (nombre_pro, precio_pro, nombrecompleto, facturado, Cantidad, total_calculo) VALUES (@nombre_pro, @precio_pro, @nombrecompleto, @facturado, @Cantidad, @total_calculo)";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.Add("@nombre_pro", MySqlDbType.String).Value = nombrepro;
                comando.Parameters.Add("@precio_pro", MySqlDbType.Int32).Value = precio_pro;
                comando.Parameters.Add("@nombrecompleto", MySqlDbType.String).Value = nombrecompleto;
                comando.Parameters.Add("@facturado", MySqlDbType.String).Value = facturado;
                comando.Parameters.Add("@Cantidad", MySqlDbType.Int32).Value = cantidad;
                comando.Parameters.Add("@total_calculo", MySqlDbType.Int32).Value = total_calculo;

                comando.ExecuteNonQuery();
                MessageBox.Show("Facturación Completa");
                con.Close();
            }
            this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            Insertar();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void editarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria FrmC = new FrmCategoria();
            FrmC.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario FrmR = new FrmRegistroUsuario();
            FrmR.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin Frml = new FrmLogin();
            Frml.Show();
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente FrmC = new FrmCliente();
            FrmC.Show();
        }

        private void editarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarProductos FrmEd = new FrmEditarProductos();
            FrmEd.Show();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe FrmAc = new FrmAcercaDe();
            FrmAc.Show();
        }


        public void CargarDgvPrincipal()
        {
            //MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from historial_factura where id_historial_factura = @id_historial_factura", con);
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //dgvStock.DataSource = tabla;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            DialogResult result = MessageBox.Show("¿Estas seguro que quiere eliminar este producto?.", "ATENCION", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM historial_factura Where id_historial_factura = @id_historial_factura";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@id_historial_factura", txtcodigoeliminar.Text);
                comando.ExecuteNonQuery();
            
                MessageBox.Show("Producto Eliminado");
                con.Close();
                //clear();
            }
            else
            {

            }
            //this.txtcantidaddeproductos.Text = this.dgvStock.Rows.Count.ToString("N0");
        }
    }
}
