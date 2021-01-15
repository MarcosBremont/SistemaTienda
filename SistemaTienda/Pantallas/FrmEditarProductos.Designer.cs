
namespace SistemaTienda.Pantallas
{
    partial class FrmEditarProductos
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
            this.txtcantidaddeproductos = new System.Windows.Forms.TextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compra_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBBuscarPorNombre = new System.Windows.Forms.GroupBox();
            this.txtbuscarpornombredelproducto = new System.Windows.Forms.TextBox();
            this.GPDetallesdeStock = new System.Windows.Forms.GroupBox();
            this.txtcompra = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.lblfechastock = new System.Windows.Forms.Label();
            this.lblnombreproducto = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblidproducto = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.GBBuscarPorNombre.SuspendLayout();
            this.GPDetallesdeStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcantidaddeproductos
            // 
            this.txtcantidaddeproductos.Location = new System.Drawing.Point(478, 499);
            this.txtcantidaddeproductos.Name = "txtcantidaddeproductos";
            this.txtcantidaddeproductos.ReadOnly = true;
            this.txtcantidaddeproductos.Size = new System.Drawing.Size(75, 20);
            this.txtcantidaddeproductos.TabIndex = 81;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(120)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeight = 40;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.nombre_pro,
            this.categoria_pro,
            this.precio_pro,
            this.compra_pro,
            this.cantidad_pro});
            this.dgvStock.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStock.Location = new System.Drawing.Point(478, 111);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStock.RowTemplate.Height = 30;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(699, 373);
            this.dgvStock.TabIndex = 83;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            // 
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.FillWeight = 49.55036F;
            this.id_producto.HeaderText = "Codigo";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            // 
            // nombre_pro
            // 
            this.nombre_pro.DataPropertyName = "nombre_pro";
            this.nombre_pro.FillWeight = 119.1544F;
            this.nombre_pro.HeaderText = "Nombre del Producto";
            this.nombre_pro.Name = "nombre_pro";
            this.nombre_pro.ReadOnly = true;
            // 
            // categoria_pro
            // 
            this.categoria_pro.DataPropertyName = "categoria_pro";
            this.categoria_pro.FillWeight = 106.4554F;
            this.categoria_pro.HeaderText = "Categoria del Producto";
            this.categoria_pro.Name = "categoria_pro";
            this.categoria_pro.ReadOnly = true;
            // 
            // precio_pro
            // 
            this.precio_pro.DataPropertyName = "precio_pro";
            this.precio_pro.FillWeight = 106.4554F;
            this.precio_pro.HeaderText = "Descripcion";
            this.precio_pro.Name = "precio_pro";
            this.precio_pro.ReadOnly = true;
            // 
            // compra_pro
            // 
            this.compra_pro.DataPropertyName = "compra_pro";
            this.compra_pro.FillWeight = 106.4554F;
            this.compra_pro.HeaderText = "Precio";
            this.compra_pro.Name = "compra_pro";
            this.compra_pro.ReadOnly = true;
            // 
            // cantidad_pro
            // 
            this.cantidad_pro.DataPropertyName = "cantidad_pro";
            this.cantidad_pro.HeaderText = "Cantidad del Prod.";
            this.cantidad_pro.Name = "cantidad_pro";
            this.cantidad_pro.ReadOnly = true;
            // 
            // GBBuscarPorNombre
            // 
            this.GBBuscarPorNombre.Controls.Add(this.txtbuscarpornombredelproducto);
            this.GBBuscarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBBuscarPorNombre.Location = new System.Drawing.Point(478, 20);
            this.GBBuscarPorNombre.Name = "GBBuscarPorNombre";
            this.GBBuscarPorNombre.Size = new System.Drawing.Size(200, 80);
            this.GBBuscarPorNombre.TabIndex = 82;
            this.GBBuscarPorNombre.TabStop = false;
            this.GBBuscarPorNombre.Text = "Buscar Por Nombre del Producto";
            // 
            // txtbuscarpornombredelproducto
            // 
            this.txtbuscarpornombredelproducto.Location = new System.Drawing.Point(8, 36);
            this.txtbuscarpornombredelproducto.Name = "txtbuscarpornombredelproducto";
            this.txtbuscarpornombredelproducto.Size = new System.Drawing.Size(184, 20);
            this.txtbuscarpornombredelproducto.TabIndex = 0;
            this.txtbuscarpornombredelproducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarpornombredelproducto_KeyUp);
            // 
            // GPDetallesdeStock
            // 
            this.GPDetallesdeStock.Controls.Add(this.cmbCategoria);
            this.GPDetallesdeStock.Controls.Add(this.txtcompra);
            this.GPDetallesdeStock.Controls.Add(this.lblCategoria);
            this.GPDetallesdeStock.Controls.Add(this.btneditar);
            this.GPDetallesdeStock.Controls.Add(this.btneliminar);
            this.GPDetallesdeStock.Controls.Add(this.btnguardar);
            this.GPDetallesdeStock.Controls.Add(this.btnnuevo);
            this.GPDetallesdeStock.Controls.Add(this.lblfechastock);
            this.GPDetallesdeStock.Controls.Add(this.lblnombreproducto);
            this.GPDetallesdeStock.Controls.Add(this.lblprecio);
            this.GPDetallesdeStock.Controls.Add(this.lblcantidad);
            this.GPDetallesdeStock.Controls.Add(this.lblidproducto);
            this.GPDetallesdeStock.Controls.Add(this.txtprecio);
            this.GPDetallesdeStock.Controls.Add(this.txtnombreproducto);
            this.GPDetallesdeStock.Controls.Add(this.txtcantidad);
            this.GPDetallesdeStock.Controls.Add(this.txtidproducto);
            this.GPDetallesdeStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GPDetallesdeStock.Location = new System.Drawing.Point(12, 12);
            this.GPDetallesdeStock.Name = "GPDetallesdeStock";
            this.GPDetallesdeStock.Size = new System.Drawing.Size(448, 357);
            this.GPDetallesdeStock.TabIndex = 80;
            this.GPDetallesdeStock.TabStop = false;
            this.GPDetallesdeStock.Text = "Detalles de Stock";
            // 
            // txtcompra
            // 
            this.txtcompra.Location = new System.Drawing.Point(147, 186);
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.Size = new System.Drawing.Size(240, 20);
            this.txtcompra.TabIndex = 21;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(30, 112);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(64, 16);
            this.lblCategoria.TabIndex = 20;
            this.lblCategoria.Text = "Categoria";
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btneditar.Location = new System.Drawing.Point(338, 287);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(90, 33);
            this.btneditar.TabIndex = 9;
            this.btneditar.Text = "Actualizar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btneliminar.Location = new System.Drawing.Point(227, 287);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(90, 33);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnguardar.Location = new System.Drawing.Point(116, 287);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(90, 33);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnnuevo.Location = new System.Drawing.Point(5, 287);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(90, 33);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // lblfechastock
            // 
            this.lblfechastock.AutoSize = true;
            this.lblfechastock.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechastock.Location = new System.Drawing.Point(30, 190);
            this.lblfechastock.Name = "lblfechastock";
            this.lblfechastock.Size = new System.Drawing.Size(54, 16);
            this.lblfechastock.TabIndex = 13;
            this.lblfechastock.Text = "Compra";
            // 
            // lblnombreproducto
            // 
            this.lblnombreproducto.AutoSize = true;
            this.lblnombreproducto.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreproducto.Location = new System.Drawing.Point(30, 73);
            this.lblnombreproducto.Name = "lblnombreproducto";
            this.lblnombreproducto.Size = new System.Drawing.Size(110, 16);
            this.lblnombreproducto.TabIndex = 12;
            this.lblnombreproducto.Text = "Nombre Producto";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(30, 151);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(45, 16);
            this.lblprecio.TabIndex = 10;
            this.lblprecio.Text = "Precio";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(30, 229);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(58, 16);
            this.lblcantidad.TabIndex = 9;
            this.lblcantidad.Text = "Cantidad";
            // 
            // lblidproducto
            // 
            this.lblidproducto.AutoSize = true;
            this.lblidproducto.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidproducto.Location = new System.Drawing.Point(30, 34);
            this.lblidproducto.Name = "lblidproducto";
            this.lblidproducto.Size = new System.Drawing.Size(76, 16);
            this.lblidproducto.TabIndex = 6;
            this.lblidproducto.Text = "ID Producto";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(147, 147);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(240, 20);
            this.txtprecio.TabIndex = 3;
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(147, 69);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(240, 20);
            this.txtnombreproducto.TabIndex = 0;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(147, 225);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(240, 20);
            this.txtcantidad.TabIndex = 4;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(147, 30);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(28, 20);
            this.txtidproducto.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(147, 111);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(240, 21);
            this.cmbCategoria.TabIndex = 22;
            // 
            // FrmEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 529);
            this.Controls.Add(this.txtcantidaddeproductos);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.GBBuscarPorNombre);
            this.Controls.Add(this.GPDetallesdeStock);
            this.Name = "FrmEditarProductos";
            this.Text = "FrmEditarProductos";
            this.Load += new System.EventHandler(this.FrmEditarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.GBBuscarPorNombre.ResumeLayout(false);
            this.GBBuscarPorNombre.PerformLayout();
            this.GPDetallesdeStock.ResumeLayout(false);
            this.GPDetallesdeStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcantidaddeproductos;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.GroupBox GBBuscarPorNombre;
        private System.Windows.Forms.TextBox txtbuscarpornombredelproducto;
        private System.Windows.Forms.GroupBox GPDetallesdeStock;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label lblfechastock;
        private System.Windows.Forms.Label lblnombreproducto;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblidproducto;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn compra_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_pro;
        private System.Windows.Forms.TextBox txtcompra;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}