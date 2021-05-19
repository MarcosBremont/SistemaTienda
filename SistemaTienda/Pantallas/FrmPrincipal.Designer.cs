
namespace SistemaTienda
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnColocar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbuscarproducto = new System.Windows.Forms.TextBox();
            this.lblnombreproducto = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblcambio = new System.Windows.Forms.Label();
            this.txtDineroRecibido = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtcantidaddeproductos = new System.Windows.Forms.TextBox();
            this.lblfechafactura = new System.Windows.Forms.Label();
            this.lblproductosfacturados = new System.Windows.Forms.Label();
            this.lbldinerorecibido = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.GBBuscarPorNombre = new System.Windows.Forms.GroupBox();
            this.cmbfacturara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFacturacion = new System.Windows.Forms.DataGridView();
            this.id_historial_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_calculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPDetallesdeStock = new System.Windows.Forms.GroupBox();
            this.txtFacturadoPor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtSeleccionarCLiente = new System.Windows.Forms.TextBox();
            this.txtclienteTemporal = new System.Windows.Forms.TextBox();
            this.BtnNueva = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCodigoPro = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombreprod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarProductos = new System.Windows.Forms.Button();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.GBBuscarPorNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.GPDetallesdeStock.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnColocar
            // 
            this.BtnColocar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(21)))));
            this.BtnColocar.FlatAppearance.BorderSize = 0;
            this.BtnColocar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnColocar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.BtnColocar.Location = new System.Drawing.Point(965, 191);
            this.BtnColocar.Name = "BtnColocar";
            this.BtnColocar.Size = new System.Drawing.Size(132, 38);
            this.BtnColocar.TabIndex = 6;
            this.BtnColocar.Text = "Colocar";
            this.BtnColocar.UseVisualStyleBackColor = false;
            this.BtnColocar.Click += new System.EventHandler(this.BtnColocar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBuscarProductos);
            this.groupBox2.Controls.Add(this.txtbuscarproducto);
            this.groupBox2.Controls.Add(this.lblnombreproducto);
            this.groupBox2.Location = new System.Drawing.Point(12, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 63);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtbuscarproducto
            // 
            this.txtbuscarproducto.Location = new System.Drawing.Point(130, 24);
            this.txtbuscarproducto.Name = "txtbuscarproducto";
            this.txtbuscarproducto.Size = new System.Drawing.Size(151, 20);
            this.txtbuscarproducto.TabIndex = 1;
            this.txtbuscarproducto.TextChanged += new System.EventHandler(this.txtbuscarproducto_TextChanged);
            this.txtbuscarproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbuscarproducto_KeyDown);
            // 
            // lblnombreproducto
            // 
            this.lblnombreproducto.AutoSize = true;
            this.lblnombreproducto.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreproducto.Location = new System.Drawing.Point(9, 25);
            this.lblnombreproducto.Name = "lblnombreproducto";
            this.lblnombreproducto.Size = new System.Drawing.Size(104, 16);
            this.lblnombreproducto.TabIndex = 1;
            this.lblnombreproducto.Text = "Buscar Producto";
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Location = new System.Drawing.Point(340, 47);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(130, 20);
            this.txtCambio.TabIndex = 103;
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcambio.Location = new System.Drawing.Point(283, 48);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(51, 16);
            this.lblcambio.TabIndex = 102;
            this.lblcambio.Text = "Cambio";
            // 
            // txtDineroRecibido
            // 
            this.txtDineroRecibido.Location = new System.Drawing.Point(147, 20);
            this.txtDineroRecibido.Name = "txtDineroRecibido";
            this.txtDineroRecibido.Size = new System.Drawing.Size(130, 20);
            this.txtDineroRecibido.TabIndex = 101;
            this.txtDineroRecibido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDineroRecibido_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(843, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker1.TabIndex = 100;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(340, 19);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(130, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // txtcantidaddeproductos
            // 
            this.txtcantidaddeproductos.Enabled = false;
            this.txtcantidaddeproductos.Location = new System.Drawing.Point(147, 48);
            this.txtcantidaddeproductos.Name = "txtcantidaddeproductos";
            this.txtcantidaddeproductos.ReadOnly = true;
            this.txtcantidaddeproductos.Size = new System.Drawing.Size(130, 20);
            this.txtcantidaddeproductos.TabIndex = 99;
            // 
            // lblfechafactura
            // 
            this.lblfechafactura.AutoSize = true;
            this.lblfechafactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblfechafactura.Location = new System.Drawing.Point(840, 126);
            this.lblfechafactura.Name = "lblfechafactura";
            this.lblfechafactura.Size = new System.Drawing.Size(89, 13);
            this.lblfechafactura.TabIndex = 12;
            this.lblfechafactura.Text = "Fecha Factura";
            // 
            // lblproductosfacturados
            // 
            this.lblproductosfacturados.AutoSize = true;
            this.lblproductosfacturados.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductosfacturados.Location = new System.Drawing.Point(13, 48);
            this.lblproductosfacturados.Name = "lblproductosfacturados";
            this.lblproductosfacturados.Size = new System.Drawing.Size(135, 16);
            this.lblproductosfacturados.TabIndex = 12;
            this.lblproductosfacturados.Text = "Productos Facturados";
            // 
            // lbldinerorecibido
            // 
            this.lbldinerorecibido.AutoSize = true;
            this.lbldinerorecibido.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldinerorecibido.Location = new System.Drawing.Point(13, 21);
            this.lbldinerorecibido.Name = "lbldinerorecibido";
            this.lbldinerorecibido.Size = new System.Drawing.Size(98, 16);
            this.lbldinerorecibido.TabIndex = 10;
            this.lbldinerorecibido.Text = "Dinero Recibido";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(283, 21);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(35, 16);
            this.lbltotal.TabIndex = 10;
            this.lbltotal.Text = "Total";
            // 
            // GBBuscarPorNombre
            // 
            this.GBBuscarPorNombre.Controls.Add(this.cmbfacturara);
            this.GBBuscarPorNombre.Controls.Add(this.label1);
            this.GBBuscarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBBuscarPorNombre.Location = new System.Drawing.Point(443, 47);
            this.GBBuscarPorNombre.Name = "GBBuscarPorNombre";
            this.GBBuscarPorNombre.Size = new System.Drawing.Size(242, 63);
            this.GBBuscarPorNombre.TabIndex = 4;
            this.GBBuscarPorNombre.TabStop = false;
            // 
            // cmbfacturara
            // 
            this.cmbfacturara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfacturara.FormattingEnabled = true;
            this.cmbfacturara.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.cmbfacturara.Location = new System.Drawing.Point(88, 22);
            this.cmbfacturara.Name = "cmbfacturara";
            this.cmbfacturara.Size = new System.Drawing.Size(121, 21);
            this.cmbfacturara.TabIndex = 1;
            this.cmbfacturara.SelectedValueChanged += new System.EventHandler(this.cmbfacturara_SelectedValueChanged);
            this.cmbfacturara.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbfacturara_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Facturar a:";
            // 
            // dgvFacturacion
            // 
            this.dgvFacturacion.AllowUserToAddRows = false;
            this.dgvFacturacion.AllowUserToDeleteRows = false;
            this.dgvFacturacion.AllowUserToOrderColumns = true;
            this.dgvFacturacion.AllowUserToResizeColumns = false;
            this.dgvFacturacion.AllowUserToResizeRows = false;
            this.dgvFacturacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturacion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFacturacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFacturacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturacion.ColumnHeadersHeight = 40;
            this.dgvFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_historial_factura,
            this.nombre_pro,
            this.precio_pro,
            this.Cantidad,
            this.nombrecompleto,
            this.facturado,
            this.total_calculo,
            this.fechaFactura});
            this.dgvFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturacion.EnableHeadersVisualStyles = false;
            this.dgvFacturacion.GridColor = System.Drawing.SystemColors.Control;
            this.dgvFacturacion.Location = new System.Drawing.Point(12, 167);
            this.dgvFacturacion.MultiSelect = false;
            this.dgvFacturacion.Name = "dgvFacturacion";
            this.dgvFacturacion.ReadOnly = true;
            this.dgvFacturacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFacturacion.RowHeadersVisible = false;
            this.dgvFacturacion.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFacturacion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFacturacion.RowTemplate.Height = 30;
            this.dgvFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturacion.Size = new System.Drawing.Size(947, 262);
            this.dgvFacturacion.TabIndex = 3;
            this.dgvFacturacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturacion_CellClick);
            this.dgvFacturacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturacion_CellContentClick);
            // 
            // id_historial_factura
            // 
            this.id_historial_factura.DataPropertyName = "id_historial_factura";
            this.id_historial_factura.FillWeight = 49.55036F;
            this.id_historial_factura.HeaderText = "Codigo";
            this.id_historial_factura.Name = "id_historial_factura";
            this.id_historial_factura.ReadOnly = true;
            // 
            // nombre_pro
            // 
            this.nombre_pro.DataPropertyName = "nombre_pro";
            this.nombre_pro.FillWeight = 106.4554F;
            this.nombre_pro.HeaderText = "Nombre Producto";
            this.nombre_pro.Name = "nombre_pro";
            this.nombre_pro.ReadOnly = true;
            // 
            // precio_pro
            // 
            this.precio_pro.DataPropertyName = "precio_pro";
            this.precio_pro.HeaderText = "Precio V.";
            this.precio_pro.Name = "precio_pro";
            this.precio_pro.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // nombrecompleto
            // 
            this.nombrecompleto.DataPropertyName = "nombrecompleto";
            this.nombrecompleto.FillWeight = 106.4554F;
            this.nombrecompleto.HeaderText = "Nombre Cliente";
            this.nombrecompleto.Name = "nombrecompleto";
            this.nombrecompleto.ReadOnly = true;
            // 
            // facturado
            // 
            this.facturado.DataPropertyName = "facturado";
            this.facturado.HeaderText = "Facturado a:";
            this.facturado.Name = "facturado";
            this.facturado.ReadOnly = true;
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
            // GPDetallesdeStock
            // 
            this.GPDetallesdeStock.Controls.Add(this.txtFacturadoPor);
            this.GPDetallesdeStock.Controls.Add(this.BtnAgregarCliente);
            this.GPDetallesdeStock.Controls.Add(this.label5);
            this.GPDetallesdeStock.Controls.Add(this.lblprecio);
            this.GPDetallesdeStock.Controls.Add(this.lblcantidad);
            this.GPDetallesdeStock.Controls.Add(this.txtSeleccionarCLiente);
            this.GPDetallesdeStock.Controls.Add(this.txtclienteTemporal);
            this.GPDetallesdeStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GPDetallesdeStock.Location = new System.Drawing.Point(12, 434);
            this.GPDetallesdeStock.Name = "GPDetallesdeStock";
            this.GPDetallesdeStock.Size = new System.Drawing.Size(331, 127);
            this.GPDetallesdeStock.TabIndex = 5;
            this.GPDetallesdeStock.TabStop = false;
            // 
            // txtFacturadoPor
            // 
            this.txtFacturadoPor.Enabled = false;
            this.txtFacturadoPor.Location = new System.Drawing.Point(150, 22);
            this.txtFacturadoPor.Name = "txtFacturadoPor";
            this.txtFacturadoPor.ReadOnly = true;
            this.txtFacturadoPor.Size = new System.Drawing.Size(130, 20);
            this.txtFacturadoPor.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Facturado Por";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(23, 60);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(119, 16);
            this.lblprecio.TabIndex = 10;
            this.lblprecio.Text = "Seleccionar Cliente";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(23, 97);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(105, 16);
            this.lblcantidad.TabIndex = 9;
            this.lblcantidad.Text = "Cliente Temporal";
            // 
            // txtSeleccionarCLiente
            // 
            this.txtSeleccionarCLiente.Location = new System.Drawing.Point(150, 57);
            this.txtSeleccionarCLiente.Name = "txtSeleccionarCLiente";
            this.txtSeleccionarCLiente.Size = new System.Drawing.Size(130, 20);
            this.txtSeleccionarCLiente.TabIndex = 4;
            this.txtSeleccionarCLiente.TextChanged += new System.EventHandler(this.txtSeleccionarCLiente_TextChanged);
            // 
            // txtclienteTemporal
            // 
            this.txtclienteTemporal.Location = new System.Drawing.Point(150, 93);
            this.txtclienteTemporal.Name = "txtclienteTemporal";
            this.txtclienteTemporal.Size = new System.Drawing.Size(130, 20);
            this.txtclienteTemporal.TabIndex = 6;
            this.txtclienteTemporal.TextChanged += new System.EventHandler(this.txtclienteTemporal_TextChanged);
            // 
            // BtnNueva
            // 
            this.BtnNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(21)))));
            this.BtnNueva.FlatAppearance.BorderSize = 0;
            this.BtnNueva.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnNueva.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.BtnNueva.Location = new System.Drawing.Point(965, 239);
            this.BtnNueva.Name = "BtnNueva";
            this.BtnNueva.Size = new System.Drawing.Size(132, 33);
            this.BtnNueva.TabIndex = 93;
            this.BtnNueva.Text = "Nueva";
            this.BtnNueva.UseVisualStyleBackColor = false;
            this.BtnNueva.Click += new System.EventHandler(this.BtnNueva_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnsalir.Location = new System.Drawing.Point(965, 528);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(132, 33);
            this.btnsalir.TabIndex = 97;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(21)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImprimir.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnImprimir.Location = new System.Drawing.Point(965, 366);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(132, 33);
            this.btnImprimir.TabIndex = 96;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(21)))));
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnguardar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnguardar.Location = new System.Drawing.Point(965, 317);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(132, 33);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(21)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(965, 278);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 33);
            this.btnEliminar.TabIndex = 94;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(21, 626);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(0, 16);
            this.lblusuario.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(121)))));
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.historialToolStripMenuItem1,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip1.TabIndex = 105;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarCategoriasToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // editarCategoriasToolStripMenuItem
            // 
            this.editarCategoriasToolStripMenuItem.Name = "editarCategoriasToolStripMenuItem";
            this.editarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editarCategoriasToolStripMenuItem.Text = "Editar Categorias";
            this.editarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.editarCategoriasToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarInventarioToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.inventarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // editarInventarioToolStripMenuItem
            // 
            this.editarInventarioToolStripMenuItem.Name = "editarInventarioToolStripMenuItem";
            this.editarInventarioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.editarInventarioToolStripMenuItem.Text = "Editar Inventario";
            this.editarInventarioToolStripMenuItem.Click += new System.EventHandler(this.editarInventarioToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem1
            // 
            this.historialToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeFacturasToolStripMenuItem,
            this.historialDeudasToolStripMenuItem});
            this.historialToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.historialToolStripMenuItem1.Name = "historialToolStripMenuItem1";
            this.historialToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.historialToolStripMenuItem1.Text = "Historial";
            // 
            // historialDeFacturasToolStripMenuItem
            // 
            this.historialDeFacturasToolStripMenuItem.Name = "historialDeFacturasToolStripMenuItem";
            this.historialDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.historialDeFacturasToolStripMenuItem.Text = "Historial de facturas";
            this.historialDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.historialDeFacturasToolStripMenuItem_Click);
            // 
            // historialDeudasToolStripMenuItem
            // 
            this.historialDeudasToolStripMenuItem.Name = "historialDeudasToolStripMenuItem";
            this.historialDeudasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.historialDeudasToolStripMenuItem.Text = "Historial Deudas";
            this.historialDeudasToolStripMenuItem.Click += new System.EventHandler(this.historialDeudasToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // txtCodigoPro
            // 
            this.txtCodigoPro.Location = new System.Drawing.Point(13, 144);
            this.txtCodigoPro.Name = "txtCodigoPro";
            this.txtCodigoPro.Size = new System.Drawing.Size(58, 20);
            this.txtCodigoPro.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(77, 144);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(127, 20);
            this.txtnombre.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(208, 144);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(116, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(330, 144);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(123, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(12, 126);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(33, 13);
            this.lblcodigo.TabIndex = 107;
            this.lblcodigo.Text = "Cod.";
            // 
            // lblnombreprod
            // 
            this.lblnombreprod.AutoSize = true;
            this.lblnombreprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreprod.Location = new System.Drawing.Point(74, 127);
            this.lblnombreprod.Name = "lblnombreprod";
            this.lblnombreprod.Size = new System.Drawing.Size(50, 13);
            this.lblnombreprod.TabIndex = 107;
            this.lblnombreprod.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 107;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Cantidad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(121)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 38);
            this.panel1.TabIndex = 108;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcantidaddeproductos);
            this.groupBox1.Controls.Add(this.txtCambio);
            this.groupBox1.Controls.Add(this.lbltotal);
            this.groupBox1.Controls.Add(this.lblcambio);
            this.groupBox1.Controls.Add(this.lbldinerorecibido);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtDineroRecibido);
            this.groupBox1.Controls.Add(this.lblproductosfacturados);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(483, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 102);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            // 
            // BtnBuscarProductos
            // 
            this.BtnBuscarProductos.FlatAppearance.BorderSize = 0;
            this.BtnBuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProductos.Image = global::SistemaTienda.Properties.Resources.lupa__2_;
            this.BtnBuscarProductos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarProductos.Location = new System.Drawing.Point(290, 12);
            this.BtnBuscarProductos.Name = "BtnBuscarProductos";
            this.BtnBuscarProductos.Size = new System.Drawing.Size(73, 43);
            this.BtnBuscarProductos.TabIndex = 2;
            this.BtnBuscarProductos.UseVisualStyleBackColor = true;
            this.BtnBuscarProductos.Click += new System.EventHandler(this.BtnBuscarProductos_Click);
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.BtnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCliente.Image = global::SistemaTienda.Properties.Resources.anadir;
            this.BtnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAgregarCliente.Location = new System.Drawing.Point(284, 52);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(28, 30);
            this.BtnAgregarCliente.TabIndex = 1;
            this.BtnAgregarCliente.UseVisualStyleBackColor = true;
            this.BtnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarCliente_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblnombreprod);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblfechafactura);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtCodigoPro);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.BtnColocar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GBBuscarPorNombre);
            this.Controls.Add(this.dgvFacturacion);
            this.Controls.Add(this.GPDetallesdeStock);
            this.Controls.Add(this.BtnNueva);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmPrincipal";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPrincipal_MouseDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GBBuscarPorNombre.ResumeLayout(false);
            this.GBBuscarPorNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            this.GPDetallesdeStock.ResumeLayout(false);
            this.GPDetallesdeStock.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnColocar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBuscarProductos;
        private System.Windows.Forms.TextBox txtbuscarproducto;
        private System.Windows.Forms.Label lblnombreproducto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtcantidaddeproductos;
        private System.Windows.Forms.Label lblproductosfacturados;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.GroupBox GBBuscarPorNombre;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvFacturacion;
        private System.Windows.Forms.GroupBox GPDetallesdeStock;
        public System.Windows.Forms.TextBox txtFacturadoPor;
        private System.Windows.Forms.Button BtnAgregarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtSeleccionarCLiente;
        private System.Windows.Forms.TextBox txtclienteTemporal;
        private System.Windows.Forms.Button BtnNueva;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbfacturara;
        public System.Windows.Forms.Label lblusuario;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCategoriasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCodigoPro;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialDeFacturasToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_historial_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturado;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_calculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFactura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblfechafactura;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblcambio;
        private System.Windows.Forms.TextBox txtDineroRecibido;
        private System.Windows.Forms.Label lbldinerorecibido;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombreprod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem historialDeudasToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

