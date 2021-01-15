
namespace SistemaTienda.Pantallas
{
    partial class FrmCategoria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblidcategoria = new System.Windows.Forms.Label();
            this.CMBCategorias = new System.Windows.Forms.ComboBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.panel1.Location = new System.Drawing.Point(46, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 62);
            this.panel1.TabIndex = 9;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(277, 14);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 32);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(203, 14);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(68, 32);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(129, 14);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(68, 32);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(55, 14);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(68, 32);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblidcategoria);
            this.groupBox1.Controls.Add(this.CMBCategorias);
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(46, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(396, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // lblidcategoria
            // 
            this.lblidcategoria.AutoSize = true;
            this.lblidcategoria.Location = new System.Drawing.Point(46, 25);
            this.lblidcategoria.Name = "lblidcategoria";
            this.lblidcategoria.Size = new System.Drawing.Size(21, 16);
            this.lblidcategoria.TabIndex = 2;
            this.lblidcategoria.Text = "ID";
            // 
            // CMBCategorias
            // 
            this.CMBCategorias.FormattingEnabled = true;
            this.CMBCategorias.Location = new System.Drawing.Point(45, 53);
            this.CMBCategorias.Name = "CMBCategorias";
            this.CMBCategorias.Size = new System.Drawing.Size(314, 24);
            this.CMBCategorias.TabIndex = 1;
            this.CMBCategorias.SelectedIndexChanged += new System.EventHandler(this.CMBCategorias_SelectedIndexChanged);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(89, 20);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(270, 23);
            this.txtCategoria.TabIndex = 0;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 209);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblidcategoria;
        private System.Windows.Forms.ComboBox CMBCategorias;
        public System.Windows.Forms.TextBox txtCategoria;
    }
}