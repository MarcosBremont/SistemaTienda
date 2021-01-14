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
    public partial class FrmCliente : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=SistemaTienda; user=root; password=1234");
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
           
            CargarDgvCliente();
            this.txtcantidaddeproductos.Text = this.dgvCliente.Rows.Count.ToString("N0");
        }

        public void CargarDgvCliente()
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from cliente", con);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvCliente.DataSource = tabla;
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDCliente.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txtNombreCompleto.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtNotas.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
        }
        public void Clear()
        {
            txtNombreCompleto.Clear();
            txtDireccion.Clear();
            txtIDCliente.Clear();
            txtNotas.Clear();
            txtTelefono.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            DialogResult result = MessageBox.Show("¿Estas seguro que quiere eliminar este Cliente?", "ATENCION", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM cliente Where IDCliente = @IDCliente";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@IDCliente", txtIDCliente.Text);
                comando.ExecuteNonQuery();
                CargarDgvCliente();
                MessageBox.Show("Cliente Eliminado");
                con.Close();
                Clear();
            }
            else
            {

            }

            this.txtcantidaddeproductos.Text = this.dgvCliente.Rows.Count.ToString("N0");
        }

        public void Insertar()
        {
            con.Open();
            string query = "INSERT INTO Cliente (NombreCompleto, Direccion, TELEFONO, Notas) values (@NombreCompleto, @Direccion, @TELEFONO, @Notas)";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@NombreCompleto", txtNombreCompleto.Text);
            comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            comando.Parameters.AddWithValue("@TELEFONO", txtTelefono.Text);
            comando.Parameters.AddWithValue("@Notas", txtNotas.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Cliente Agregado");
            con.Close();
            this.txtcantidaddeproductos.Text = this.dgvCliente.Rows.Count.ToString("N0");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Insertar();
            CargarDgvCliente();
            Clear();
            this.txtcantidaddeproductos.Text = this.dgvCliente.Rows.Count.ToString("N0");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE cliente SET NombreCompleto = @NombreCompleto, Direccion = @Direccion, TELEFONO = @TELEFONO, Notas = @Notas  where IDCliente=@IDCliente";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDCliente", txtIDCliente.Text);
            comando.Parameters.AddWithValue("@NombreCompleto", txtNombreCompleto.Text);
            comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            comando.Parameters.AddWithValue("@TELEFONO", txtTelefono.Text);
            comando.Parameters.AddWithValue("@Notas", txtNotas.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Cliente Actualizado");
            CargarDgvCliente();
            con.Close();
            Clear();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
