
namespace SistemaTienda.Pantallas
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcantidaddeproductos = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.BtnSeleccionar.Location = new System.Drawing.Point(12, 187);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(87, 29);
            this.BtnSeleccionar.TabIndex = 1;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 19);
            this.label3.TabIndex = 142;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 19);
            this.label1.TabIndex = 141;
            this.label1.Text = "*";
            // 
            // txtcantidaddeproductos
            // 
            this.txtcantidaddeproductos.Location = new System.Drawing.Point(12, 476);
            this.txtcantidaddeproductos.Name = "txtcantidaddeproductos";
            this.txtcantidaddeproductos.ReadOnly = true;
            this.txtcantidaddeproductos.Size = new System.Drawing.Size(75, 20);
            this.txtcantidaddeproductos.TabIndex = 120;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToOrderColumns = true;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(120)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeight = 40;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCliente,
            this.NombreCompleto,
            this.Direccion,
            this.TELEFONO,
            this.Notas});
            this.dgvCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCliente.Location = new System.Drawing.Point(12, 222);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCliente.RowTemplate.Height = 30;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(899, 248);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellDoubleClick);
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellDoubleClick);
            this.dgvCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCliente_KeyDown);
            this.dgvCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCliente_KeyPress);
            // 
            // IDCliente
            // 
            this.IDCliente.DataPropertyName = "IDCliente";
            this.IDCliente.FillWeight = 49.55036F;
            this.IDCliente.HeaderText = "Codigo";
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.FillWeight = 119.1544F;
            this.NombreCompleto.HeaderText = "Nombre";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.FillWeight = 106.4554F;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // TELEFONO
            // 
            this.TELEFONO.DataPropertyName = "TELEFONO";
            this.TELEFONO.HeaderText = "Telefono";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            // 
            // Notas
            // 
            this.Notas.DataPropertyName = "Notas";
            this.Notas.HeaderText = "Notas";
            this.Notas.Name = "Notas";
            this.Notas.ReadOnly = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(149, 125);
            this.txtTelefono.Mask = "(999)000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 122;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnEliminar);
            this.GroupBox2.Controls.Add(this.btnActualizar);
            this.GroupBox2.Controls.Add(this.btnGuardar);
            this.GroupBox2.Controls.Add(this.btnNuevo);
            this.GroupBox2.Location = new System.Drawing.Point(792, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(119, 174);
            this.GroupBox2.TabIndex = 127;
            this.GroupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(16, 124);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 29);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnActualizar.Location = new System.Drawing.Point(16, 89);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 29);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(16, 54);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 29);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnNuevo.Location = new System.Drawing.Point(16, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(87, 29);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(521, 6);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotas.Size = new System.Drawing.Size(239, 67);
            this.txtNotas.TabIndex = 125;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label23.Location = new System.Drawing.Point(473, 5);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(42, 16);
            this.Label23.TabIndex = 139;
            this.Label23.Text = "Notas";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label19.Location = new System.Drawing.Point(25, 125);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(56, 16);
            this.Label19.TabIndex = 136;
            this.Label19.Text = "Teléfono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(148, 88);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(273, 20);
            this.txtDireccion.TabIndex = 116;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label5.Location = new System.Drawing.Point(25, 90);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(62, 16);
            this.Label5.TabIndex = 131;
            this.Label5.Text = "Direccion";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label2.Location = new System.Drawing.Point(25, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 16);
            this.Label2.TabIndex = 130;
            this.Label2.Text = "Nombre";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(148, 53);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(273, 20);
            this.txtNombreCompleto.TabIndex = 115;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(149, 18);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(43, 20);
            this.txtIDCliente.TabIndex = 128;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label4.Location = new System.Drawing.Point(25, 18);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 129;
            this.Label4.Text = "ID Cliente";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 524);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcantidaddeproductos);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.Label4);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnSeleccionar;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcantidaddeproductos;
        public System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnActualizar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.TextBox txtNotas;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox txtDireccion;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtNombreCompleto;
        internal System.Windows.Forms.TextBox txtIDCliente;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notas;
        internal System.Windows.Forms.Button btnGuardar;
    }
}