namespace Memoria
{
    partial class Contrasena
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCorreo = new System.Windows.Forms.Panel();
            this.panelMensaje = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            this.panelCorreo.SuspendLayout();
            this.panelMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pbSalir);
            this.panel2.Controls.Add(this.pbRegresar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 2;
            // 
            // pbSalir
            // 
            this.pbSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSalir.BackgroundImage = global::Memoria.Properties.Resources.xmark_solid1;
            this.pbSalir.Image = global::Memoria.Properties.Resources.xmark_solid1;
            this.pbSalir.Location = new System.Drawing.Point(720, 17);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(68, 50);
            this.pbSalir.TabIndex = 2;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // pbRegresar
            // 
            this.pbRegresar.BackgroundImage = global::Memoria.Properties.Resources.arrow_left_solid_white;
            this.pbRegresar.Image = global::Memoria.Properties.Resources.arrow_left_solid_white;
            this.pbRegresar.Location = new System.Drawing.Point(12, 17);
            this.pbRegresar.Name = "pbRegresar";
            this.pbRegresar.Size = new System.Drawing.Size(68, 50);
            this.pbRegresar.TabIndex = 1;
            this.pbRegresar.TabStop = false;
            this.pbRegresar.Click += new System.EventHandler(this.pbRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECUPERAR MI CONTRASEÑA";
            // 
            // panelCorreo
            // 
            this.panelCorreo.BackColor = System.Drawing.Color.Transparent;
            this.panelCorreo.Controls.Add(this.panelMensaje);
            this.panelCorreo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCorreo.Location = new System.Drawing.Point(0, 287);
            this.panelCorreo.Name = "panelCorreo";
            this.panelCorreo.Size = new System.Drawing.Size(800, 228);
            this.panelCorreo.TabIndex = 3;
            // 
            // panelMensaje
            // 
            this.panelMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMensaje.Controls.Add(this.lblMensaje);
            this.panelMensaje.Location = new System.Drawing.Point(84, 27);
            this.panelMensaje.Name = "panelMensaje";
            this.panelMensaje.Size = new System.Drawing.Size(512, 157);
            this.panelMensaje.TabIndex = 0;
            this.panelMensaje.Visible = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(18, 28);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(70, 25);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "label3";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Location = new System.Drawing.Point(573, 201);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(128, 40);
            this.btnRecuperar.TabIndex = 7;
            this.btnRecuperar.Text = "ENVIAR";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(228, 155);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(473, 40);
            this.txtCorreo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "CORREO";
            // 
            // Contrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memoria.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.ControlBox = false;
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelCorreo);
            this.Controls.Add(this.panel2);
            this.Name = "Contrasena";
            this.Text = "Contrasena";
            this.Load += new System.EventHandler(this.Contrasena_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            this.panelCorreo.ResumeLayout(false);
            this.panelMensaje.ResumeLayout(false);
            this.panelMensaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCorreo;
        private System.Windows.Forms.Panel panelMensaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSalir;
    }
}