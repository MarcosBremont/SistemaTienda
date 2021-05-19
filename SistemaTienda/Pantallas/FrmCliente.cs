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
        MySqlConnection con = new MySqlConnection("Server=localhost; database=sistematienda; user=root; password=1234");
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
            
            try
            {
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand("SCliente", con);
                cmd.Parameters.Add("prm_EstadoCliente", MySqlDbType.Text).Value = "A";
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dgvCliente.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de cargar los datos, comuniquese con soporte");
            }

            

        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDCliente.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txtNombreCompleto.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtNotas.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            CmbEstado.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
        }
        public void Clear()
        {
            txtNombreCompleto.Clear();
            txtDireccion.Clear();
            txtIDCliente.Clear();
            txtNotas.Clear();
            txtTelefono.Clear();
            comboBox1.Text = "A";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DialogResult result = MessageBox.Show("¿Estas seguro que quiere deshabilitar este Cliente?", "ATENCIÓN", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DCliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("prm_IDCliente", MySqlDbType.Text).Value = txtIDCliente.Text;
                    cmd.Parameters.Add("prm_EstadoCliente", MySqlDbType.Text).Value = CmbEstado.Text;
                    cmd.ExecuteReader();
                    MessageBox.Show("Cliente Deshabilitado");
                    con.Close();
                }
                else
                {

                }

                this.txtcantidaddeproductos.Text = this.dgvCliente.Rows.Count.ToString("N0");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de eliminar los datos, comuniquese con soporte");
            }

        }

        public void Insertar()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("ICliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("prm_NombreCompleto", MySqlDbType.Text).Value = txtNombreCompleto.Text;
                cmd.Parameters.Add("prm_Direccion", MySqlDbType.Text).Value = txtDireccion.Text;
                cmd.Parameters.Add("prm_TELEFONO", MySqlDbType.Text).Value = txtTelefono.Text;
                cmd.Parameters.Add("prm_Notas", MySqlDbType.Text).Value = txtNotas.Text;
                cmd.Parameters.Add("prm_EstadoCliente", MySqlDbType.Text).Value = CmbEstado.Text;
                cmd.ExecuteReader();
                MessageBox.Show("Cliente Agregado");
                con.Close();
                this.txtcantidaddeproductos.Text = this.dgvCliente.Rows.Count.ToString("N0");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de insertar los datos, comuniquese con soporte");
            }

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
            try
            {
                MySqlCommand cmd = new MySqlCommand("UCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@prm_IDCliente", MySqlDbType.Text).Value = txtIDCliente.Text;
                cmd.Parameters.Add("@prm_NombreCompleto", MySqlDbType.Text).Value = txtNombreCompleto.Text;
                cmd.Parameters.Add("@prm_Direccion", MySqlDbType.Text).Value = txtDireccion.Text;
                cmd.Parameters.Add("@prm_TELEFONO", MySqlDbType.Text).Value = txtTelefono.Text;
                cmd.Parameters.Add("@prm_Notas", MySqlDbType.Text).Value = txtNotas.Text;
                cmd.Parameters.Add("@prm_EstadoCliente", MySqlDbType.Text).Value = CmbEstado.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Actualizado");
                CargarDgvCliente();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de actualizar los datos, comuniquese con soporte");
            }

            con.Close();
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

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand("SCliente", con);
                cmd.Parameters.Add("prm_EstadoCliente", MySqlDbType.Text).Value = comboBox1.Text;
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dgvCliente.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de cargar los datos, comuniquese con soporte");
            }
        }
    }
}
