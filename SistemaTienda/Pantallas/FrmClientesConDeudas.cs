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
    public partial class FrmClientesConDeudas : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=SistemaTienda; user=root; password=1234");
        public FrmClientesConDeudas()
        {
            InitializeComponent();
        }

        private void FrmHistorialFacturas_Load(object sender, EventArgs e)
        {
            CargarDgvCliente();
        }

        public void CargarDgvCliente()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SClientesConDeuda", con);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_clientes_con_deudas.DataSource = dt;
            con.Close();

            //dgvCliente.DataBind();

        }

        private void dgvHistorialFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgv_clientes_con_deudas.CurrentRow.Cells["cod_prod"].Value.ToString();
            txtNombreproducto.Text = dgv_clientes_con_deudas.CurrentRow.Cells["nombre_pro"].Value.ToString();
            txtprecioproducto.Text = dgv_clientes_con_deudas.CurrentRow.Cells["precio_pro"].Value.ToString();
            txtnombrecompleto.Text = dgv_clientes_con_deudas.CurrentRow.Cells["nombrecompleto"].Value.ToString();
            txtcantidad.Text = dgv_clientes_con_deudas.CurrentRow.Cells["Cantidad"].Value.ToString();
            txttotal.Text = dgv_clientes_con_deudas.CurrentRow.Cells["total_calculo"].Value.ToString();
            dateTimePicker1.Text = dgv_clientes_con_deudas.CurrentRow.Cells["fechaFactura"].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE historial_factura SET nombre_pro = @nombre_pro, precio_pro = @precio_pro, nombrecompleto = @nombrecompleto, Cantidad = @Cantidad, total_calculo = @total_calculo, fechaFactura = @fechaFactura  where cod_prod=@cod_prod";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@cod_prod", txtCodigo.Text);
            comando.Parameters.AddWithValue("@nombre_pro", txtNombreproducto.Text);
            comando.Parameters.AddWithValue("@precio_pro", txtprecioproducto.Text);
            comando.Parameters.AddWithValue("@nombrecompleto", txtnombrecompleto.Text);
            comando.Parameters.AddWithValue("@Cantidad", txtcantidad.Text);
            comando.Parameters.AddWithValue("@total_calculo", txttotal.Text);
            comando.Parameters.AddWithValue("@fechaFactura", dateTimePicker1.Value);
            comando.ExecuteNonQuery();
            MessageBox.Show("Factura Actualizada");
            CargarDgvCliente();
            con.Close();
            Clear();
        }

        public void Clear()
        {
            txtNombreproducto.Clear();
            txtprecioproducto.Clear();
            txtnombrecompleto.Clear();
            txtcantidad.Clear();
            txttotal.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            DialogResult result = MessageBox.Show("¿Estas seguro que quiere eliminar esta factura?", "ATENCION", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM historial_factura Where cod_prod = @cod_prod";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@cod_prod", txtCodigo.Text);
                comando.ExecuteNonQuery();
                CargarDgvCliente();
                MessageBox.Show("Deuda Pagada");
                con.Close();
                Clear();
            }
            else
            {

            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void PagarFactura()
        {
            con.Open();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("UHistorialFacturaPago", con);
            cmd.Parameters.Add("prm_facturadoa", MySqlDbType.Text).Value = "Credito";
            cmd.Parameters.Add("prm_facturadoa", MySqlDbType.Text).Value = "Credito";
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_clientes_con_deudas.DataSource = dt;
            con.Close();

            //dgvCliente.DataBind();

        }
    }
}
