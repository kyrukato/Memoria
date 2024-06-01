namespace Memoria
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnojo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblrecuperarcontra = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(322, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(283, 1);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(181, 39);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "USUARIO";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(290, 47);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(320, 40);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(290, 141);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(320, 40);
            this.txtContrasena.TabIndex = 3;
            // 
            // lblContrasena
            // 
            this.lblContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(283, 99);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(267, 39);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "CONTRASEÑA";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(447, 197);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(163, 49);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.LinkColor = System.Drawing.Color.White;
            this.lblRegistro.Location = new System.Drawing.Point(260, 23);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(408, 25);
            this.lblRegistro.TabIndex = 6;
            this.lblRegistro.TabStop = true;
            this.lblRegistro.Text = "¿NO TIENES CUENTA? REGÍSTRATE";
            this.lblRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegistro_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 102);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnojo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblContrasena);
            this.panel2.Controls.Add(this.btnIngresar);
            this.panel2.Controls.Add(this.txtContrasena);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 438);
            this.panel2.TabIndex = 8;
            // 
            // btnojo
            // 
            this.btnojo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnojo.Location = new System.Drawing.Point(617, 141);
            this.btnojo.Name = "btnojo";
            this.btnojo.Size = new System.Drawing.Size(65, 40);
            this.btnojo.TabIndex = 6;
            this.btnojo.UseVisualStyleBackColor = true;
            this.btnojo.Click += new System.EventHandler(this.btnojo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblrecuperarcontra);
            this.panel3.Controls.Add(this.lblRegistro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(885, 151);
            this.panel3.TabIndex = 0;
            // 
            // lblrecuperarcontra
            // 
            this.lblrecuperarcontra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblrecuperarcontra.AutoSize = true;
            this.lblrecuperarcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecuperarcontra.LinkColor = System.Drawing.Color.White;
            this.lblrecuperarcontra.Location = new System.Drawing.Point(276, 56);
            this.lblrecuperarcontra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrecuperarcontra.Name = "lblrecuperarcontra";
            this.lblrecuperarcontra.Size = new System.Drawing.Size(363, 25);
            this.lblrecuperarcontra.TabIndex = 7;
            this.lblrecuperarcontra.TabStop = true;
            this.lblrecuperarcontra.Text = "¿OLVIDASTE TU CONTRASEÑA?";
            this.lblrecuperarcontra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblrecuperarcontra_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "BIENVENIDO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel lblRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel lblrecuperarcontra;
        private System.Windows.Forms.Button btnojo;
    }
}

