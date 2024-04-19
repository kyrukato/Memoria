namespace Memoria
{
    partial class Inicio
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
            this.lblNivel1 = new System.Windows.Forms.Label();
            this.lblnivel2 = new System.Windows.Forms.Label();
            this.lblNivel3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblGlosario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNivel1
            // 
            this.lblNivel1.AutoSize = true;
            this.lblNivel1.Location = new System.Drawing.Point(180, 80);
            this.lblNivel1.Name = "lblNivel1";
            this.lblNivel1.Size = new System.Drawing.Size(47, 13);
            this.lblNivel1.TabIndex = 0;
            this.lblNivel1.Text = "NIVEL 1";
            this.lblNivel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnivel2
            // 
            this.lblnivel2.AutoSize = true;
            this.lblnivel2.Location = new System.Drawing.Point(180, 132);
            this.lblnivel2.Name = "lblnivel2";
            this.lblnivel2.Size = new System.Drawing.Size(47, 13);
            this.lblnivel2.TabIndex = 1;
            this.lblnivel2.Text = "NIVEL 2";
            // 
            // lblNivel3
            // 
            this.lblNivel3.AutoSize = true;
            this.lblNivel3.Location = new System.Drawing.Point(180, 178);
            this.lblNivel3.Name = "lblNivel3";
            this.lblNivel3.Size = new System.Drawing.Size(47, 13);
            this.lblNivel3.TabIndex = 2;
            this.lblNivel3.Text = "NIVEL 3";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(683, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblGlosario
            // 
            this.lblGlosario.AutoSize = true;
            this.lblGlosario.Location = new System.Drawing.Point(180, 219);
            this.lblGlosario.Name = "lblGlosario";
            this.lblGlosario.Size = new System.Drawing.Size(62, 13);
            this.lblGlosario.TabIndex = 4;
            this.lblGlosario.Text = "GLOSARIO";
            this.lblGlosario.Click += new System.EventHandler(this.lblGlosario_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblGlosario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNivel3);
            this.Controls.Add(this.lblnivel2);
            this.Controls.Add(this.lblNivel1);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNivel1;
        private System.Windows.Forms.Label lblnivel2;
        private System.Windows.Forms.Label lblNivel3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblGlosario;
    }
}