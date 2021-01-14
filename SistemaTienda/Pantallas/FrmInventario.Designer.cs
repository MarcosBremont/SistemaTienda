
namespace SistemaTienda.Pantallas
{
    partial class FrmInventario
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.GBBuscarPorCodigo = new System.Windows.Forms.GroupBox();
            this.txtbuscarporcodigo = new System.Windows.Forms.TextBox();
            this.GBBuscarPorCategoria = new System.Windows.Forms.GroupBox();
            this.txtbuscarporcategoria = new System.Windows.Forms.TextBox();
            this.GBBuscarPorNombre = new System.Windows.Forms.GroupBox();
            this.txtbuscarpornombredelproducto = new System.Windows.Forms.TextBox();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compra_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.GBBuscarPorCodigo.SuspendLayout();
            this.GBBuscarPorCategoria.SuspendLayout();
            this.GBBuscarPorNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnSeleccionar.Location = new System.Drawing.Point(2, 71);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(90, 33);
            this.btnSeleccionar.TabIndex = 79;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btneditar.Location = new System.Drawing.Point(2, 110);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(90, 33);
            this.btneditar.TabIndex = 81;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToOrderColumns = true;
            this.dgvInventario.AllowUserToResizeColumns = false;
            this.dgvInventario.AllowUserToResizeRows = false;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(120)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.ColumnHeadersHeight = 40;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.nombre_pro,
            this.categoria_pro,
            this.precio_pro,
            this.compra_pro,
            this.cantidad_pro});
            this.dgvInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.GridColor = System.Drawing.SystemColors.Control;
            this.dgvInventario.Location = new System.Drawing.Point(0, 166);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInventario.RowTemplate.Height = 30;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(1063, 330);
            this.dgvInventario.TabIndex = 84;
            // 
            // GBBuscarPorCodigo
            // 
            this.GBBuscarPorCodigo.Controls.Add(this.txtbuscarporcodigo);
            this.GBBuscarPorCodigo.Location = new System.Drawing.Point(705, 16);
            this.GBBuscarPorCodigo.Name = "GBBuscarPorCodigo";
            this.GBBuscarPorCodigo.Size = new System.Drawing.Size(200, 80);
            this.GBBuscarPorCodigo.TabIndex = 83;
            this.GBBuscarPorCodigo.TabStop = false;
            this.GBBuscarPorCodigo.Text = "Buscar Por Codigo";
            // 
            // txtbuscarporcodigo
            // 
            this.txtbuscarporcodigo.Location = new System.Drawing.Point(6, 36);
            this.txtbuscarporcodigo.Name = "txtbuscarporcodigo";
            this.txtbuscarporcodigo.Size = new System.Drawing.Size(184, 20);
            this.txtbuscarporcodigo.TabIndex = 0;
            this.txtbuscarporcodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarporcodigo_KeyUp);
            // 
            // GBBuscarPorCategoria
            // 
            this.GBBuscarPorCategoria.Controls.Add(this.txtbuscarporcategoria);
            this.GBBuscarPorCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GBBuscarPorCategoria.Location = new System.Drawing.Point(410, 16);
            this.GBBuscarPorCategoria.Name = "GBBuscarPorCategoria";
            this.GBBuscarPorCategoria.Size = new System.Drawing.Size(200, 80);
            this.GBBuscarPorCategoria.TabIndex = 82;
            this.GBBuscarPorCategoria.TabStop = false;
            this.GBBuscarPorCategoria.Text = "Buscar Por Categoria";
            // 
            // txtbuscarporcategoria
            // 
            this.txtbuscarporcategoria.Location = new System.Drawing.Point(10, 36);
            this.txtbuscarporcategoria.Name = "txtbuscarporcategoria";
            this.txtbuscarporcategoria.Size = new System.Drawing.Size(184, 20);
            this.txtbuscarporcategoria.TabIndex = 0;
            this.txtbuscarporcategoria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarporcategoria_KeyUp);
            // 
            // GBBuscarPorNombre
            // 
            this.GBBuscarPorNombre.Controls.Add(this.txtbuscarpornombredelproducto);
            this.GBBuscarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBBuscarPorNombre.Location = new System.Drawing.Point(115, 16);
            this.GBBuscarPorNombre.Name = "GBBuscarPorNombre";
            this.GBBuscarPorNombre.Size = new System.Drawing.Size(200, 80);
            this.GBBuscarPorNombre.TabIndex = 80;
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
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.FillWeight = 76.14214F;
            this.id_producto.HeaderText = "Codigo";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            // 
            // nombre_pro
            // 
            this.nombre_pro.DataPropertyName = "nombre_pro";
            this.nombre_pro.FillWeight = 111.9289F;
            this.nombre_pro.HeaderText = "Nombre del Producto";
            this.nombre_pro.Name = "nombre_pro";
            this.nombre_pro.ReadOnly = true;
            // 
            // categoria_pro
            // 
            this.categoria_pro.DataPropertyName = "categoria_pro";
            this.categoria_pro.HeaderText = "Categoria del Producto";
            this.categoria_pro.Name = "categoria_pro";
            this.categoria_pro.ReadOnly = true;
            // 
            // precio_pro
            // 
            this.precio_pro.DataPropertyName = "precio_pro";
            this.precio_pro.HeaderText = "Precio";
            this.precio_pro.Name = "precio_pro";
            this.precio_pro.ReadOnly = true;
            // 
            // compra_pro
            // 
            this.compra_pro.DataPropertyName = "compra_pro";
            this.compra_pro.HeaderText = "Precio C";
            this.compra_pro.Name = "compra_pro";
            this.compra_pro.ReadOnly = true;
            // 
            // cantidad_pro
            // 
            this.cantidad_pro.DataPropertyName = "cantidad_pro";
            this.cantidad_pro.HeaderText = "Cantidad existente";
            this.cantidad_pro.Name = "cantidad_pro";
            this.cantidad_pro.ReadOnly = true;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 496);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.GBBuscarPorCodigo);
            this.Controls.Add(this.GBBuscarPorCategoria);
            this.Controls.Add(this.GBBuscarPorNombre);
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.GBBuscarPorCodigo.ResumeLayout(false);
            this.GBBuscarPorCodigo.PerformLayout();
            this.GBBuscarPorCategoria.ResumeLayout(false);
            this.GBBuscarPorCategoria.PerformLayout();
            this.GBBuscarPorNombre.ResumeLayout(false);
            this.GBBuscarPorNombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btneditar;
        public System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.GroupBox GBBuscarPorCodigo;
        private System.Windows.Forms.TextBox txtbuscarporcodigo;
        private System.Windows.Forms.GroupBox GBBuscarPorCategoria;
        private System.Windows.Forms.TextBox txtbuscarporcategoria;
        private System.Windows.Forms.GroupBox GBBuscarPorNombre;
        private System.Windows.Forms.TextBox txtbuscarpornombredelproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn compra_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_pro;
    }
}