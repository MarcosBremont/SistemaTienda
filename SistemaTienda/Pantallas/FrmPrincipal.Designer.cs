
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtCodigoPro = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarProductos = new System.Windows.Forms.Button();
            this.txtbuscarproducto = new System.Windows.Forms.TextBox();
            this.lblnombreproducto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtcantidaddeproductos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GBBuscarPorNombre = new System.Windows.Forms.GroupBox();
            this.cmbfacturara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFacturacion = new System.Windows.Forms.DataGridView();
            this.GPDetallesdeStock = new System.Windows.Forms.GroupBox();
            this.txtFacturadoPor = new System.Windows.Forms.TextBox();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
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
            this.id_historial_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_calculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GBBuscarPorNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.GPDetallesdeStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnColocar
            // 
            this.BtnColocar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.BtnColocar.Location = new System.Drawing.Point(596, 94);
            this.BtnColocar.Name = "BtnColocar";
            this.BtnColocar.Size = new System.Drawing.Size(153, 22);
            this.BtnColocar.TabIndex = 91;
            this.BtnColocar.Text = "Colocar";
            this.BtnColocar.UseVisualStyleBackColor = true;
            this.BtnColocar.Click += new System.EventHandler(this.BtnColocar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(413, 95);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(182, 20);
            this.txtCantidad.TabIndex = 92;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(250, 95);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(162, 20);
            this.txtPrecio.TabIndex = 90;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(88, 95);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(160, 20);
            this.txtDescrip.TabIndex = 89;
            // 
            // txtCodigoPro
            // 
            this.txtCodigoPro.Location = new System.Drawing.Point(13, 95);
            this.txtCodigoPro.Name = "txtCodigoPro";
            this.txtCodigoPro.Size = new System.Drawing.Size(73, 20);
            this.txtCodigoPro.TabIndex = 88;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBuscarProductos);
            this.groupBox2.Controls.Add(this.txtbuscarproducto);
            this.groupBox2.Controls.Add(this.lblnombreproducto);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 63);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
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
            this.BtnBuscarProductos.TabIndex = 1;
            this.BtnBuscarProductos.UseVisualStyleBackColor = true;
            this.BtnBuscarProductos.Click += new System.EventHandler(this.BtnBuscarProductos_Click);
            // 
            // txtbuscarproducto
            // 
            this.txtbuscarproducto.Location = new System.Drawing.Point(130, 24);
            this.txtbuscarproducto.Name = "txtbuscarproducto";
            this.txtbuscarproducto.Size = new System.Drawing.Size(151, 20);
            this.txtbuscarproducto.TabIndex = 0;
            // 
            // lblnombreproducto
            // 
            this.lblnombreproducto.AutoSize = true;
            this.lblnombreproducto.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreproducto.Location = new System.Drawing.Point(9, 25);
            this.lblnombreproducto.Name = "lblnombreproducto";
            this.lblnombreproducto.Size = new System.Drawing.Size(104, 16);
            this.lblnombreproducto.TabIndex = 14;
            this.lblnombreproducto.Text = "Buscar Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtcantidaddeproductos);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(463, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 168);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(133, 59);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(130, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // txtcantidaddeproductos
            // 
            this.txtcantidaddeproductos.Location = new System.Drawing.Point(155, 24);
            this.txtcantidaddeproductos.Name = "txtcantidaddeproductos";
            this.txtcantidaddeproductos.ReadOnly = true;
            this.txtcantidaddeproductos.Size = new System.Drawing.Size(108, 20);
            this.txtcantidaddeproductos.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Productos Facturados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total";
            // 
            // GBBuscarPorNombre
            // 
            this.GBBuscarPorNombre.Controls.Add(this.cmbfacturara);
            this.GBBuscarPorNombre.Controls.Add(this.label1);
            this.GBBuscarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBBuscarPorNombre.Location = new System.Drawing.Point(443, 12);
            this.GBBuscarPorNombre.Name = "GBBuscarPorNombre";
            this.GBBuscarPorNombre.Size = new System.Drawing.Size(242, 63);
            this.GBBuscarPorNombre.TabIndex = 103;
            this.GBBuscarPorNombre.TabStop = false;
            // 
            // cmbfacturara
            // 
            this.cmbfacturara.FormattingEnabled = true;
            this.cmbfacturara.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.cmbfacturara.Location = new System.Drawing.Point(88, 22);
            this.cmbfacturara.Name = "cmbfacturara";
            this.cmbfacturara.Size = new System.Drawing.Size(121, 21);
            this.cmbfacturara.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 16;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(120)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
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
            this.total_calculo});
            this.dgvFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturacion.EnableHeadersVisualStyles = false;
            this.dgvFacturacion.GridColor = System.Drawing.SystemColors.Control;
            this.dgvFacturacion.Location = new System.Drawing.Point(13, 118);
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
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFacturacion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFacturacion.RowTemplate.Height = 30;
            this.dgvFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturacion.Size = new System.Drawing.Size(735, 248);
            this.dgvFacturacion.TabIndex = 102;
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
            this.GPDetallesdeStock.Location = new System.Drawing.Point(13, 384);
            this.GPDetallesdeStock.Name = "GPDetallesdeStock";
            this.GPDetallesdeStock.Size = new System.Drawing.Size(362, 168);
            this.GPDetallesdeStock.TabIndex = 100;
            this.GPDetallesdeStock.TabStop = false;
            // 
            // txtFacturadoPor
            // 
            this.txtFacturadoPor.Location = new System.Drawing.Point(150, 35);
            this.txtFacturadoPor.Name = "txtFacturadoPor";
            this.txtFacturadoPor.ReadOnly = true;
            this.txtFacturadoPor.Size = new System.Drawing.Size(130, 20);
            this.txtFacturadoPor.TabIndex = 0;
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.BtnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCliente.Image = global::SistemaTienda.Properties.Resources.anadir;
            this.BtnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAgregarCliente.Location = new System.Drawing.Point(284, 65);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(28, 30);
            this.BtnAgregarCliente.TabIndex = 5;
            this.BtnAgregarCliente.UseVisualStyleBackColor = true;
            this.BtnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Facturado Por";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(23, 73);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(119, 16);
            this.lblprecio.TabIndex = 10;
            this.lblprecio.Text = "Seleccionar Cliente";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(23, 110);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(105, 16);
            this.lblcantidad.TabIndex = 9;
            this.lblcantidad.Text = "Cliente Temporal";
            // 
            // txtSeleccionarCLiente
            // 
            this.txtSeleccionarCLiente.Location = new System.Drawing.Point(150, 70);
            this.txtSeleccionarCLiente.Name = "txtSeleccionarCLiente";
            this.txtSeleccionarCLiente.Size = new System.Drawing.Size(130, 20);
            this.txtSeleccionarCLiente.TabIndex = 4;
            // 
            // txtclienteTemporal
            // 
            this.txtclienteTemporal.Location = new System.Drawing.Point(150, 106);
            this.txtclienteTemporal.Name = "txtclienteTemporal";
            this.txtclienteTemporal.Size = new System.Drawing.Size(130, 20);
            this.txtclienteTemporal.TabIndex = 6;
            // 
            // BtnNueva
            // 
            this.BtnNueva.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.BtnNueva.Location = new System.Drawing.Point(758, 175);
            this.BtnNueva.Name = "BtnNueva";
            this.BtnNueva.Size = new System.Drawing.Size(132, 33);
            this.BtnNueva.TabIndex = 93;
            this.BtnNueva.Text = "Nueva";
            this.BtnNueva.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnsalir.Location = new System.Drawing.Point(758, 384);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(132, 33);
            this.btnsalir.TabIndex = 97;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnImprimir.Location = new System.Drawing.Point(758, 332);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(132, 33);
            this.btnImprimir.TabIndex = 96;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnguardar.Location = new System.Drawing.Point(758, 280);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(132, 33);
            this.btnguardar.TabIndex = 95;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(758, 228);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 33);
            this.btnEliminar.TabIndex = 94;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
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
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 574);
            this.Controls.Add(this.BtnColocar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtCodigoPro);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBBuscarPorNombre);
            this.Controls.Add(this.dgvFacturacion);
            this.Controls.Add(this.GPDetallesdeStock);
            this.Controls.Add(this.BtnNueva);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnEliminar);
            this.Name = "FrmPrincipal";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBBuscarPorNombre.ResumeLayout(false);
            this.GBBuscarPorNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            this.GPDetallesdeStock.ResumeLayout(false);
            this.GPDetallesdeStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnColocar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtCodigoPro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBuscarProductos;
        private System.Windows.Forms.TextBox txtbuscarproducto;
        private System.Windows.Forms.Label lblnombreproducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtcantidaddeproductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id_historial_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturado;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_calculo;
    }
}

