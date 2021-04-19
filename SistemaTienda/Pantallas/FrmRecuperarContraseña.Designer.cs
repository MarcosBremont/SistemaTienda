
namespace SistemaTienda.Pantallas
{
    partial class FrmRecuperarContraseña
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
            this.components = new System.ComponentModel.Container();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnVolverAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(46, 66);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(336, 24);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ingrese su Correo Electrónico :";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEnviar.FlatAppearance.BorderSize = 2;
            this.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviar.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.BtnEnviar.ForeColor = System.Drawing.Color.White;
            this.BtnEnviar.Location = new System.Drawing.Point(400, 60);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(99, 33);
            this.BtnEnviar.TabIndex = 20;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // BtnVolverAtras
            // 
            this.BtnVolverAtras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnVolverAtras.FlatAppearance.BorderSize = 2;
            this.BtnVolverAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolverAtras.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.BtnVolverAtras.ForeColor = System.Drawing.Color.White;
            this.BtnVolverAtras.Image = global::SistemaTienda.Properties.Resources.BackIcon;
            this.BtnVolverAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolverAtras.Location = new System.Drawing.Point(179, 120);
            this.BtnVolverAtras.Name = "BtnVolverAtras";
            this.BtnVolverAtras.Size = new System.Drawing.Size(152, 33);
            this.BtnVolverAtras.TabIndex = 22;
            this.BtnVolverAtras.Text = "Volver Atras";
            this.BtnVolverAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVolverAtras.UseVisualStyleBackColor = true;
            this.BtnVolverAtras.Click += new System.EventHandler(this.BtnVolverAtras_Click);
            // 
            // FrmRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(548, 176);
            this.Controls.Add(this.BtnVolverAtras);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEnviar);
            this.Name = "FrmRecuperarContraseña";
            this.Text = "Recuperar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnVolverAtras;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Timer timer1;
    }
}