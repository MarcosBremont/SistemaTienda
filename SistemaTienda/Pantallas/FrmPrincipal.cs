using MySql.Data.MySqlClient;
using SistemaTienda.Pantallas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTienda
{
    public partial class FrmPrincipal : Form
    {
        Conexion conexion = new Conexion();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static int cont_fila = 0;
        public static double total;
        public static double cambio;
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void BtnBuscarProductos_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtbuscarproducto.Text))
                {
                    FrmInventario FrmI = new FrmInventario();
                    FrmI.ShowDialog();

                    if (FrmI.DialogResult == DialogResult.OK)
                    {
                        txtCodigoPro.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[0].Value.ToString();
                        txtnombre.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[1].Value.ToString();
                        txtPrecio.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[4].Value.ToString();
                        txtCantidad.Focus();
                        conexion.Desconectar();
                    }
                    this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");

                }

                else
                {
                    MySqlCommand cmd = new MySqlCommand(" SELECT * FROM producto where id_producto = @id_producto", conexion.GetCon());
                    cmd.Parameters.AddWithValue("id_producto", txtbuscarproducto.Text);

                    MySqlDataReader registro = cmd.ExecuteReader();
                    if (registro.Read())
                    {
                        txtCodigoPro.Text = registro["id_producto"].ToString();
                        txtnombre.Text = registro["nombre_pro"].ToString();
                        txtPrecio.Text = registro["precio_pro"].ToString();
                        txtCantidad.Focus();

                    }
                     conexion.Desconectar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de cargar los datos, comuniquese con soporte");
            }
            
        }
     
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
            txtnombre.Text = "";
            txtCodigoPro.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";


            txtFacturadoPor.Text = "";


        }

        public void AgregarCliente()
        {
            try
            {
                if (string.IsNullOrEmpty(txtSeleccionarCLiente.Text))
                {

                    FrmCliente FrmC = new FrmCliente();
                    FrmC.ShowDialog();

                    if (FrmC.DialogResult == DialogResult.OK)
                    {
                        //txtSeleccionarCLiente.Text = FrmC.dgvCliente.Rows[FrmC.dgvCliente.CurrentRow.Cells].Cells[1].Value.ToString();
                        txtSeleccionarCLiente.Text = FrmC.dgvCliente.CurrentRow.Cells[1].Value.ToString();
                         conexion.Desconectar();
                    }
                }

                else
                {
                    MySqlCommand cmd = new MySqlCommand(" SELECT * FROM cliente where IDCliente = @IDCliente", conexion.GetCon());
                    cmd.Parameters.AddWithValue("IDCliente", txtSeleccionarCLiente.Text);
                    conexion.Conectar();
                    MySqlDataReader registro = cmd.ExecuteReader();
                    if (registro.Read())
                    {
                        txtSeleccionarCLiente.Text = registro["NombreCompleto"].ToString();
                        txtclienteTemporal.Focus();

                    }
                     conexion.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de cargar los datos, comuniquese con soporte");
            }
            


        }
        public void Insertar()
        {
            try
            {
               

                foreach (DataGridViewRow row in dgvFacturacion.Rows)
                {
                    conexion.Conectar();
                    string nombrepro1 = row.Cells["nombre_pro"].Value.ToString();
                    int precio_pro = Convert.ToInt32(row.Cells["precio_pro"].Value);
                    string nombrecompleto = row.Cells["nombrecompleto"].Value.ToString();
                    string facturado = row.Cells["facturado"].Value.ToString();
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    int total_calculo = Convert.ToInt32(row.Cells["total_calculo"].Value);
                    DateTime fechaFactura = Convert.ToDateTime(row.Cells["fechaFactura"].Value);
                    int codigoproducto = Convert.ToInt32(row.Cells["id_historial_factura"].Value);

                    MySqlCommand cmd = new MySqlCommand("IHistorial_Factura", conexion.GetCon());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("prm_nombre_pro", MySqlDbType.Text).Value = nombrepro1;
                    cmd.Parameters.Add("prm_precio_pro", MySqlDbType.Double).Value = precio_pro;
                    cmd.Parameters.Add("prm_nombrecompleto", MySqlDbType.Text).Value = nombrecompleto;
                    cmd.Parameters.Add("prm_facturado", MySqlDbType.Text).Value = facturado;
                    cmd.Parameters.Add("prm_Cantidad", MySqlDbType.Int32).Value = cantidad;
                    cmd.Parameters.Add("prm_total_calculo", MySqlDbType.Double).Value = total_calculo;
                    cmd.Parameters.Add("prm_fechaFactura", MySqlDbType.DateTime).Value = fechaFactura;
                    cmd.Parameters.Add("prm_idproducto", MySqlDbType.Int32).Value = codigoproducto;
                    cmd.ExecuteReader();
                     conexion.Desconectar();
                }
                MessageBox.Show("Facturación Completa");
                this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de insertar los datos, comuniquese con soporte");
            }
            
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
            btnEliminar.Enabled = false;
            validacionColocarProducto();

        }

        public void validacionColocarProducto()
        {
            if (txtCantidad.Text == "")
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


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            DialogResult result = MessageBox.Show("¿Estas seguro que quiere eliminar este producto?.", "ATENCION", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvFacturacion.SelectedRows)
                {
                    dgvFacturacion.Rows.RemoveAt(row.Index);
                }
            }
            else
            {

            }
            //this.txtcantidaddeproductos.Text = this.dgvStock.Rows.Count.ToString("N0");
        }

        public void Facturar()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de cargar los datos, comuniquese con soporte");
            }
            
        }

        public void ColocarEnGrid()
        {

            bool existe = false;
            int num_fila = 0;
            string UnCliente = "";
            try
            {
                if (string.IsNullOrEmpty(txtSeleccionarCLiente.Text))
                {
                    UnCliente = txtclienteTemporal.Text;

                }
                else
                {
                    UnCliente = txtSeleccionarCLiente.Text;
                }



                if (string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Debe introducir una cantidad del producto seleccionado");
                    txtCantidad.Focus();
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
                            dgvFacturacion.Rows.Add(txtCodigoPro.Text, txtnombre.Text, txtPrecio.Text, txtCantidad.Text);
                            double importe = Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[3].Value);
                            dgvFacturacion.Rows[cont_fila].Cells[6].Value = importe;
                            dgvFacturacion.Rows[cont_fila].Cells[4].Value = UnCliente;
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
                                dgvFacturacion.Rows.Add(txtCodigoPro.Text, txtnombre.Text, txtPrecio.Text, txtCantidad.Text);
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
                btnEliminar.Enabled = true;
                txtbuscarproducto.Focus();
                int cambio = 0;
                cambio = int.Parse(txtDineroRecibido.Text) - int.Parse(txtTotal.Text);
                txtCambio.Text = cambio.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de colocar los datos en pantalla, comuniquese con soporte");
            }
           
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
                        txtnombre.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[1].Value.ToString();
                        txtPrecio.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[4].Value.ToString();
                        txtCantidad.Focus();
                         conexion.Desconectar();
                    }
                    this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");

                }

                else
                {
                    MySqlCommand cmd = new MySqlCommand(" SELECT * FROM producto where id_producto = @id_producto", conexion.GetCon());
                    cmd.Parameters.AddWithValue("id_producto", txtbuscarproducto.Text);

                    conexion.Conectar();
                    MySqlDataReader registro = cmd.ExecuteReader();
                    if (registro.Read())
                    {
                        txtCodigoPro.Text = registro["id_producto"].ToString();
                        txtnombre.Text = registro["nombre_pro"].ToString();
                        txtPrecio.Text = registro["precio_pro"].ToString();
                        txtCantidad.Focus();

                    }
                     conexion.Desconectar();

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
            if (txtSeleccionarCLiente.TextLength>0)
            {
                txtclienteTemporal.Enabled = false;
            }
            else
                txtclienteTemporal.Enabled = true;

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
            try
            {
                PrintDialog printDialog = new PrintDialog();
                DialogResult userResp = printDialog.ShowDialog();
                printDocument1 = new PrintDocument();
                if (printDialog.PrinterSettings.PrinterName == "Microsoft Print to PDF")
                {   // force a reasonable filename
                    string basename = Path.GetFileNameWithoutExtension((Path.GetTempFileName()));
                    string directory = Path.GetDirectoryName("c:/");
                    printDocument1.PrinterSettings.PrintToFile = true;
                    // confirm the user wants to use that name
                    SaveFileDialog pdfSaveDialog = new SaveFileDialog();
                    pdfSaveDialog.InitialDirectory = directory;
                    pdfSaveDialog.FileName = basename + ".pdf";
                    pdfSaveDialog.Filter = "PDF File|*.pdf";
                    userResp = pdfSaveDialog.ShowDialog();
                    if (userResp != DialogResult.Cancel)
                        printDocument1.PrinterSettings.PrintFileName = pdfSaveDialog.FileName;
                }
                //Facturar();

                //printDocument1 = new PrintDocument();
                //PrinterSettings ps = new PrinterSettings();
                //printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += Imprimir;
                //printDocument1.DocumentName = "Factura";
                printDocument1.Print();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de imprimir los datos, comuniquese con soporte");
            }
           
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Point ulCorner1 = new Point(100, 100);
            Point urCorner1 = new Point(325, 100);
            Point llCorner1 = new Point(150, 250);
            Point[] destPara1 = { ulCorner1, urCorner1, llCorner1 };

            Rectangle srcRect = new Rectangle(50, 50, 150, 150);
            GraphicsUnit units = GraphicsUnit.Pixel;

            Font font = new Font("Times New Roman", 14, FontStyle.Bold);
            Font fontSinBold = new Font("Times New Roman", 14);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Near;
            format.Alignment = StringAlignment.Near;
            DateTime fecha = DateTime.Parse(dateTimePicker1.Text.ToString());
            int ancho = 250;
            int y = 20;

            string unCliente = "";


            if (string.IsNullOrEmpty(txtSeleccionarCLiente.Text))
            {
                 unCliente = txtclienteTemporal.Text;

            }
            else
            {
                unCliente = txtSeleccionarCLiente.Text;
            }

            try
            {
                Bitmap image = new Bitmap("c:/boutique.png");

                e.Graphics.DrawImage(image, new Rectangle(80, 5, 50, 50));
                e.Graphics.DrawString("           ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), format);
                e.Graphics.DrawString("    --- Lucas Fashion ---", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), format);
                e.Graphics.DrawString("          " + fecha.ToString("MM/dd/yyyy"), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), format);
                //e.Graphics.DrawString("--- Factura # ---" + txtCantidad.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                e.Graphics.DrawString("Cliente: " + unCliente, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), format);
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
                    cambio = double.Parse(txtCambio.Text.ToString());

                    e.Graphics.DrawString(cantidad + " " + nombreProducto + " " + precio, fontSinBold, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), format);
                }

                e.Graphics.DrawString(" ------------------------------- ", fontSinBold, Brushes.Black, new RectangleF(0, y += 40, ancho, 20), format);
                e.Graphics.DrawString("Total: " + total, fontSinBold, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), format);
                e.Graphics.DrawString("Devuelta: " + cambio, fontSinBold, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), format);
                e.Graphics.DrawString("--- Gracias por Visitarnos ---", fontSinBold, Brushes.Black, new RectangleF(0, y += 30, ancho, 20), format);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error a la hora de imprimir, Por favor comuniquese con soporte");
            }
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

        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.U && e.Modifiers == Keys.Alt)
            {
                FrmRegistroUsuario frmRegistroUsuario = new FrmRegistroUsuario();
                frmRegistroUsuario.Show();
                //Do stuff...
            }
            else if (e.KeyCode == Keys.C && e.Modifiers == Keys.Alt)
            {
                FrmCliente frmCliente = new FrmCliente();
                frmCliente.Show();
            }
            else if (e.KeyCode == Keys.I && e.Modifiers == Keys.Alt)
            {
                FrmInventario frmInventario = new FrmInventario();
                frmInventario.Show();
            }

        }

        private void historialDeudasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientesConDeudas frmClientesConDeudas = new FrmClientesConDeudas();
            frmClientesConDeudas.Show();
        }

        private void txtclienteTemporal_TextChanged(object sender, EventArgs e)
        {
            if (txtclienteTemporal.TextLength > 0)
            {
                txtSeleccionarCLiente.Enabled = false;
            }
            else
                txtSeleccionarCLiente.Enabled = true;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void dgvFacturacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFacturacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoPro.Text = dgvFacturacion.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvFacturacion.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvFacturacion.CurrentRow.Cells[2].Value.ToString();
            txtCantidad.Text = dgvFacturacion.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
