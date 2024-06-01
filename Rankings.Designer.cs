namespace Memoria
{
    partial class Rankings
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
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tablaRanking = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            this.panelTabla.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tablaRanking.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Memoria.Properties.Resources.arrow_left_solid_white;
            this.panel1.Controls.Add(this.pbRegresar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 114);
            this.panel1.TabIndex = 1;
            // 
            // pbRegresar
            // 
            this.pbRegresar.Image = global::Memoria.Properties.Resources.arrow_left_solid_white;
            this.pbRegresar.Location = new System.Drawing.Point(12, 12);
            this.pbRegresar.Name = "pbRegresar";
            this.pbRegresar.Size = new System.Drawing.Size(68, 50);
            this.pbRegresar.TabIndex = 1;
            this.pbRegresar.TabStop = false;
            this.pbRegresar.Click += new System.EventHandler(this.pbRegresar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(299, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "RANKINGS";
            // 
            // panelTabla
            // 
            this.panelTabla.BackColor = System.Drawing.Color.Transparent;
            this.panelTabla.Controls.Add(this.panel3);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(0, 114);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(800, 336);
            this.panelTabla.TabIndex = 2;
            this.panelTabla.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.tablaRanking);
            this.panel3.Location = new System.Drawing.Point(52, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(703, 233);
            this.panel3.TabIndex = 1;
            // 
            // tablaRanking
            // 
            this.tablaRanking.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tablaRanking.ColumnCount = 3;
            this.tablaRanking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablaRanking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tablaRanking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tablaRanking.Controls.Add(this.label3, 2, 0);
            this.tablaRanking.Controls.Add(this.label2, 1, 0);
            this.tablaRanking.Controls.Add(this.label1, 0, 0);
            this.tablaRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaRanking.Location = new System.Drawing.Point(0, 0);
            this.tablaRanking.Name = "tablaRanking";
            this.tablaRanking.RowCount = 10;
            this.tablaRanking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablaRanking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablaRanking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablaRanking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablaRanking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablaRanking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablaRanking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablaRanking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablaRanking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablaRanking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablaRanking.Size = new System.Drawing.Size(703, 233);
            this.tablaRanking.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(515, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(277, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "PUNTAJE MÁXIMO";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIVEL";
            // 
            // Rankings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memoria.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panel1);
            this.Name = "Rankings";
            this.Text = "Rankings";
            this.Load += new System.EventHandler(this.Rankings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            this.panelTabla.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tablaRanking.ResumeLayout(false);
            this.tablaRanking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.TableLayoutPanel tablaRanking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbRegresar;
    }
}