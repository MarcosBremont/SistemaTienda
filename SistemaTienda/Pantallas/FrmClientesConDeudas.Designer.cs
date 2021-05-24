
namespace SistemaTienda.Pantallas
{
    partial class FrmClientesConDeudas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_clientes_con_deudas = new System.Windows.Forms.DataGridView();
            this.cod_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_calculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblnombrecompleto = new System.Windows.Forms.Label();
            this.txtprecioproducto = new System.Windows.Forms.TextBox();
            this.lblprecioproducto = new System.Windows.Forms.Label();
            this.lblnombreproducto = new System.Windows.Forms.Label();
            this.txtNombreproducto = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblidhistorialfactura = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes_con_deudas)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 19);
            this.label3.TabIndex = 158;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 19);
            this.label1.TabIndex = 157;
            this.label1.Text = "*";
            // 
            // dgv_clientes_con_deudas
            // 
            this.dgv_clientes_con_deudas.AllowUserToAddRows = false;
            this.dgv_clientes_con_deudas.AllowUserToDeleteRows = false;
            this.dgv_clientes_con_deudas.AllowUserToOrderColumns = true;
            this.dgv_clientes_con_deudas.AllowUserToResizeColumns = false;
            this.dgv_clientes_con_deudas.AllowUserToResizeRows = false;
            this.dgv_clientes_con_deudas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clientes_con_deudas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_clientes_con_deudas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_clientes_con_deudas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_clientes_con_deudas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clientes_con_deudas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clientes_con_deudas.ColumnHeadersHeight = 40;
            this.dgv_clientes_con_deudas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_prod,
            this.nombre_pro,
            this.precio_pro,
            this.nombrecompleto,
            this.Cantidad,
            this.total_calculo,
            this.fechaFactura});
            this.dgv_clientes_con_deudas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_clientes_con_deudas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_clientes_con_deudas.EnableHeadersVisualStyles = false;
            this.dgv_clientes_con_deudas.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_clientes_con_deudas.Location = new System.Drawing.Point(12, 173);
            this.dgv_clientes_con_deudas.MultiSelect = false;
            this.dgv_clientes_con_deudas.Name = "dgv_clientes_con_deudas";
            this.dgv_clientes_con_deudas.ReadOnly = true;
            this.dgv_clientes_con_deudas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clientes_con_deudas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_clientes_con_deudas.RowHeadersVisible = false;
            this.dgv_clientes_con_deudas.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_clientes_con_deudas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_clientes_con_deudas.RowTemplate.Height = 30;
            this.dgv_clientes_con_deudas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes_con_deudas.Size = new System.Drawing.Size(899, 322);
            this.dgv_clientes_con_deudas.TabIndex = 143;
            this.dgv_clientes_con_deudas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialFactura_CellClick);
            // 
            // cod_prod
            // 
            this.cod_prod.DataPropertyName = "cod_prod";
            this.cod_prod.HeaderText = "Codigo";
            this.cod_prod.Name = "cod_prod";
            this.cod_prod.ReadOnly = true;
            // 
            // nombre_pro
            // 
            this.nombre_pro.DataPropertyName = "nombre_pro";
            this.nombre_pro.FillWeight = 119.1544F;
            this.nombre_pro.HeaderText = "Nombre Producto";
            this.nombre_pro.Name = "nombre_pro";
            this.nombre_pro.ReadOnly = true;
            // 
            // precio_pro
            // 
            this.precio_pro.DataPropertyName = "precio_pro";
            this.precio_pro.FillWeight = 106.4554F;
            this.precio_pro.HeaderText = "Precio Producto";
            this.precio_pro.Name = "precio_pro";
            this.precio_pro.ReadOnly = true;
            // 
            // nombrecompleto
            // 
            this.nombrecompleto.DataPropertyName = "nombrecompleto";
            this.nombrecompleto.HeaderText = "Nombre Cliente";
            this.nombrecompleto.Name = "nombrecompleto";
            this.nombrecompleto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // total_calculo
            // 
            this.total_calculo.DataPropertyName = "total_calculo";
            this.total_calculo.HeaderText = "Total";
            this.total_calculo.Name = "total_calculo";
            this.total_calculo.ReadOnly = true;
            // 
            // fechaFactura
            // 
            this.fechaFactura.DataPropertyName = "fechaFactura";
            this.fechaFactura.HeaderText = "Fecha Factura";
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.ReadOnly = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnEliminar);
            this.GroupBox2.Controls.Add(this.btnActualizar);
            this.GroupBox2.Controls.Add(this.btnNuevo);
            this.GroupBox2.Location = new System.Drawing.Point(792, 8);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(119, 136);
            this.GroupBox2.TabIndex = 150;
            this.GroupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(16, 90);
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
            this.btnActualizar.Location = new System.Drawing.Point(16, 55);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 29);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            // lblnombrecompleto
            // 
            this.lblnombrecompleto.AutoSize = true;
            this.lblnombrecompleto.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.lblnombrecompleto.Location = new System.Drawing.Point(25, 128);
            this.lblnombrecompleto.Name = "lblnombrecompleto";
            this.lblnombrecompleto.Size = new System.Drawing.Size(113, 16);
            this.lblnombrecompleto.TabIndex = 155;
            this.lblnombrecompleto.Text = "Nombre Completo";
            // 
            // txtprecioproducto
            // 
            this.txtprecioproducto.Location = new System.Drawing.Point(148, 91);
            this.txtprecioproducto.Name = "txtprecioproducto";
            this.txtprecioproducto.Size = new System.Drawing.Size(273, 20);
            this.txtprecioproducto.TabIndex = 146;
            // 
            // lblprecioproducto
            // 
            this.lblprecioproducto.AutoSize = true;
            this.lblprecioproducto.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.lblprecioproducto.Location = new System.Drawing.Point(25, 93);
            this.lblprecioproducto.Name = "lblprecioproducto";
            this.lblprecioproducto.Size = new System.Drawing.Size(100, 16);
            this.lblprecioproducto.TabIndex = 154;
            this.lblprecioproducto.Text = "Precio Producto";
            // 
            // lblnombreproducto
            // 
            this.lblnombreproducto.AutoSize = true;
            this.lblnombreproducto.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.lblnombreproducto.Location = new System.Drawing.Point(25, 58);
            this.lblnombreproducto.Name = "lblnombreproducto";
            this.lblnombreproducto.Size = new System.Drawing.Size(110, 16);
            this.lblnombreproducto.TabIndex = 153;
            this.lblnombreproducto.Text = "Nombre Producto";
            // 
            // txtNombreproducto
            // 
            this.txtNombreproducto.Location = new System.Drawing.Point(148, 56);
            this.txtNombreproducto.Name = "txtNombreproducto";
            this.txtNombreproducto.Size = new System.Drawing.Size(273, 20);
            this.txtNombreproducto.TabIndex = 145;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.lblcantidad.Location = new System.Drawing.Point(449, 58);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(58, 16);
            this.lblcantidad.TabIndex = 156;
            this.lblcantidad.Text = "Cantidad";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.lbltotal.Location = new System.Drawing.Point(449, 93);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(35, 16);
            this.lbltotal.TabIndex = 156;
            this.lbltotal.Text = "Total";
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.Location = new System.Drawing.Point(149, 124);
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(273, 20);
            this.txtnombrecompleto.TabIndex = 146;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(521, 56);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(151, 20);
            this.txtcantidad.TabIndex = 145;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(521, 91);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(151, 20);
            this.txttotal.TabIndex = 145;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(544, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 159;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.label2.Location = new System.Drawing.Point(449, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 160;
            this.label2.Text = "Fecha Factura";
            // 
            // lblidhistorialfactura
            // 
            this.lblidhistorialfactura.AutoSize = true;
            this.lblidhistorialfactura.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.lblidhistorialfactura.Location = new System.Drawing.Point(25, 21);
            this.lblidhistorialfactura.Name = "lblidhistorialfactura";
            this.lblidhistorialfactura.Size = new System.Drawing.Size(47, 16);
            this.lblidhistorialfactura.TabIndex = 152;
            this.lblidhistorialfactura.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(149, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(43, 20);
            this.txtCodigo.TabIndex = 151;
            // 
            // FrmClientesConDeudas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_clientes_con_deudas);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.lblnombrecompleto);
            this.Controls.Add(this.txtnombrecompleto);
            this.Controls.Add(this.txtprecioproducto);
            this.Controls.Add(this.lblprecioproducto);
            this.Controls.Add(this.lblnombreproducto);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtNombreproducto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblidhistorialfactura);
            this.Name = "FrmClientesConDeudas";
            this.Text = "Clientes con Deudas";
            this.Load += new System.EventHandler(this.FrmHistorialFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes_con_deudas)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_clientes_con_deudas;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnActualizar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Label lblnombrecompleto;
        internal System.Windows.Forms.TextBox txtprecioproducto;
        internal System.Windows.Forms.Label lblprecioproducto;
        internal System.Windows.Forms.Label lblnombreproducto;
        internal System.Windows.Forms.TextBox txtNombreproducto;
        internal System.Windows.Forms.Label lblcantidad;
        internal System.Windows.Forms.Label lbltotal;
        internal System.Windows.Forms.TextBox txtnombrecompleto;
        internal System.Windows.Forms.TextBox txtcantidad;
        internal System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblidhistorialfactura;
        internal System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_calculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFactura;
    }
}