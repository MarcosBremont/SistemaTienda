using MySql.Data.MySqlClient;
using SistemaTienda.Pantallas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
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
            ColocarEnGrid();
        }



        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente();
        }
        public void Limpiar()
        {
            txtCodigoPro.Text = "";
            txtDescrip.Text = "";
            txtCodigoPro.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
          
           
            txtFacturadoPor.Text = "";
          

        } 
        
        public void AgregarCliente()
        {
            if (string.IsNullOrEmpty(txtSeleccionarCLiente.Text))
            {

                FrmCliente FrmC = new FrmCliente();
                FrmC.ShowDialog();

                if (FrmC.DialogResult == DialogResult.OK)
                {
                    //txtSeleccionarCLiente.Text = FrmC.dgvCliente.Rows[FrmC.dgvCliente.CurrentRow.Cells].Cells[1].Value.ToString();
                    txtSeleccionarCLiente.Text = FrmC.dgvCliente.CurrentRow.Cells[1].Value.ToString();
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
            con.Open();
            foreach (DataGridViewRow row in dgvFacturacion.Rows)
            {
                string nombrepro = row.Cells["nombre_pro"].Value.ToString();
                int precio_pro = Convert.ToInt32(row.Cells["precio_pro"].Value);
                string nombrecompleto = row.Cells["nombrecompleto"].Value.ToString();
                string facturado = row.Cells["facturado"].Value.ToString();
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                int total_calculo = Convert.ToInt32(row.Cells["total_calculo"].Value);
                DateTime fechaFactura = Convert.ToDateTime(row.Cells["fechaFactura"].Value);

                string query = "INSERT INTO historial_factura (nombre_pro, precio_pro, nombrecompleto, facturado, Cantidad, total_calculo, fechaFactura) VALUES (@nombre_pro, @precio_pro, @nombrecompleto, @facturado, @Cantidad, @total_calculo, @fechaFactura)";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.Add("@nombre_pro", MySqlDbType.String).Value = nombrepro;
                comando.Parameters.Add("@precio_pro", MySqlDbType.Int32).Value = precio_pro;
                comando.Parameters.Add("@nombrecompleto", MySqlDbType.String).Value = nombrecompleto;
                comando.Parameters.Add("@facturado", MySqlDbType.String).Value = facturado;
                comando.Parameters.Add("@Cantidad", MySqlDbType.Int32).Value = cantidad;
                comando.Parameters.Add("@total_calculo", MySqlDbType.Int32).Value = total_calculo;
                comando.Parameters.Add("@fechaFactura", MySqlDbType.DateTime).Value = fechaFactura;

                comando.ExecuteNonQuery();
            }
            MessageBox.Show("Facturación Completa");
            con.Close();
            this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            validacionColocarProducto();
            Insertar();
            btnImprimir.Focus();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            txtbuscarproducto.TabIndex = 0;
            btnguardar.Enabled = false;
            btnImprimir.Enabled = false;
            validacionColocarProducto();
        }

        public void validacionColocarProducto()
        {
            if (txtCantidad.Text == "")
            {
                BtnColocar.Enabled = false;

            }
            else if (txtSeleccionarCLiente.Text == "")
            {
                BtnColocar.Enabled = false;
            }
            else if (cmbfacturara.Text == "")
            {
                BtnColocar.Enabled = false;
            }
            else if (txtDineroRecibido.Text == "")
            {
                BtnColocar.Enabled = false;
            }
            else
            {
                BtnColocar.Enabled = true;
            }

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

        public void Facturar()
        {
            DataTable dt = new DataTable();
            dgvFacturacion.DataSource = dt;

            Factura fact = new Factura();
            List<Factura> listaFact = new List<Factura>();

            foreach (DataRow row in dt.Rows)
            {
                //fact.Codigo = row["Codigo"].ToString();
                fact.Nombre_pro = row["precio_pro"].ToString();
                fact.Nombrecompleto = row["nombrecompleto"].ToString();
                fact.Facturado = row["facturado"].ToString();
                //fact.Cantidad = row["cantidad"].ToString();
                //fact.Total_calculo = row["total_calculo"].ToString();
                //fact.FechaFactura = row["fechaFactura"].ToString();

                listaFact.Add(fact);

                MessageBox.Show(listaFact.Count().ToString());
            }

        }

        public void ColocarEnGrid()
        {
            bool existe = false;
            int num_fila = 0;

           

            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Debe introducir una cantidad del producto seleccionado");
                txtCantidad.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSeleccionarCLiente.Text))
            {
                MessageBox.Show("Debe introducir un cliente");
                txtSeleccionarCLiente.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbfacturara.Text))
            {
                MessageBox.Show("Debe seleccionar una forma de facturar");
                cmbfacturara.Focus();

                return;
            }

            else
            {
                if (string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Debe introducir una cantidad del producto seleccionado");
                    txtCantidad.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtSeleccionarCLiente.Text))
                {
                    MessageBox.Show("Debe introducir un cliente");
                    txtSeleccionarCLiente.Focus();
                    return;
                }
                else
                {

                    if (string.IsNullOrEmpty(cmbfacturara.Text))
                    {
                        MessageBox.Show("Debe seleccionar una forma de facturar");
                        cmbfacturara.Focus();

                        return;
                    }
                    if (cont_fila >= 0)
                    {
                        dgvFacturacion.Rows.Add(txtCodigoPro.Text, txtDescrip.Text, txtPrecio.Text, txtCantidad.Text);
                        double importe = Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[3].Value);
                        dgvFacturacion.Rows[cont_fila].Cells[6].Value = importe;
                        dgvFacturacion.Rows[cont_fila].Cells[4].Value = txtSeleccionarCLiente.Text;
                        dgvFacturacion.Rows[cont_fila].Cells[5].Value = cmbfacturara.Text;
                        dgvFacturacion.Rows[cont_fila].Cells[7].Value = dateTimePicker1.Text;
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
                    txtTotal.Text = total.ToString();
                    txtSeleccionarCLiente.Focus();
                    this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");

                    Limpiar();
                }

            }
            btnguardar.Enabled = true;
            btnImprimir.Enabled = true;
            txtbuscarproducto.Focus();
            int cambio = 0;
            cambio = int.Parse(txtDineroRecibido.Text) - int.Parse(txtTotal.Text);
            txtCambio.Text = cambio.ToString();
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = false;
                ColocarEnGrid();
            }
        }

        private void txtbuscarproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = false;

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
        }

        private void txtbuscarproducto_TextChanged(object sender, EventArgs e)
        {
            validacionColocarProducto();
        }

        private void txtSeleccionarCLiente_TextChanged(object sender, EventArgs e)
        {
            validacionColocarProducto();
        }

        private void cmbfacturara_SelectedValueChanged(object sender, EventArgs e)
        {
            validacionColocarProducto();
        }

        private void BtnNueva_Click(object sender, EventArgs e)
        {
            dgvFacturacion.Rows.Clear();
            txtbuscarproducto.Focus();
        }

        private void historialDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorialFacturas FrmHF = new FrmHistorialFacturas();
            FrmHF.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Facturar();

            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            // Create image.
            Image newImage = Image.FromFile("c:/earth.png");

            // Create parallelogram for drawing image.
            Point ulCorner1 = new Point(100, 100);
            Point urCorner1 = new Point(325, 100);
            Point llCorner1 = new Point(150, 250);
            Point[] destPara1 = { ulCorner1, urCorner1, llCorner1 };

            // Create rectangle for source image.
            Rectangle srcRect = new Rectangle(50, 50, 150, 150);
            GraphicsUnit units = GraphicsUnit.Pixel;



            


            Font font = new Font("Times New Roman", 14, FontStyle.Bold);
            Font fontSinBold = new Font("Times New Roman", 14);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Near;
            format.Alignment = StringAlignment.Near;
            DateTime fecha =  DateTime.Parse(dateTimePicker1.Text.ToString());
            int ancho = 250; 
            int anchoPhoto = 10; 
            int y = 20;
            //string logo = "";
            Image photo = Image.FromFile("c:/earth.png");

            Bitmap image = new Bitmap("c:/rompecabezas.png");
            Graphics x = this.CreateGraphics();

            e.Graphics.DrawImage(image, new Rectangle(80, 5, 50, 50));
            e.Graphics.DrawImage(newImage, destPara1, srcRect, units);
            e.Graphics.DrawString("           ", font,  Brushes.Black, new RectangleF(0, y += 20, ancho, 20), format);
            e.Graphics.DrawString("    --- Compañia X ---", font,  Brushes.Black, new RectangleF(0, y += 20, ancho, 20), format);
            e.Graphics.DrawString("          " + fecha.ToString("MM/dd/yyyy"), font,  Brushes.Black, new RectangleF(0, y += 20, ancho, 20), format);
            //e.Graphics.DrawString("--- Factura # ---" + txtCantidad.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente: " + txtSeleccionarCLiente.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), format);
            e.Graphics.DrawString("    --- Productos ---", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20), format);
            DataTable dt = new DataTable();

            foreach (DataGridViewRow row in dgvFacturacion.Rows)
            {
                //MessageBox.Show(row.Cells["cod_prod"].Value.ToString());
                int cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString());
                string nombreProducto = row.Cells["nombre_pro"].Value.ToString();
                float precio = float.Parse(row.Cells["precio_pro"].Value.ToString());
                string nombreCliente = row.Cells["nombrecompleto"].Value.ToString();
                string total = txtTotal.Text.ToString();

                e.Graphics.DrawString(cantidad + " " + nombreProducto + " " + precio, fontSinBold, Brushes.Black,  new RectangleF(0, y += 20, ancho, 20), format);
            }

                e.Graphics.DrawString(" ------------------------------- ", fontSinBold, Brushes.Black, new RectangleF(0, y += 40, ancho, 20), format);
                e.Graphics.DrawString("Total: " + total, fontSinBold, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), format);
                e.Graphics.DrawString("--- Gracias por Visitarnos ---", fontSinBold, Brushes.Black, new RectangleF(0, y += 30, ancho, 20), format);
            //foreach (DataRow row in dgvFacturacion.Rows)
            //{
            //    e.Graphics.DrawString(nombrecompleto + " " +
            //        row["PRODUCTO"].ToString(), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            //}
        }

        private void txtCantidad_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = false;
                AgregarCliente();
                txtDineroRecibido.Focus();
            }
        }

        private void txtDineroRecibido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = false;
                cmbfacturara.Focus();
            }
        }

        private void cmbfacturara_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = false;
                ColocarEnGrid();
                btnguardar.Focus();
            }
        }
    }
}
