using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Maximizamos el tamaño de la pantalla
            this.WindowState = FormWindowState.Maximized;
            //Seleccionamos los colores que se van a utilizar
            Color fondo = ColorTranslator.FromHtml("#D9D9D9");
            Color fondocaja = ColorTranslator.FromHtml("#576162");
            Color letras = ColorTranslator.FromHtml("#C30606");
            //Aplicamos los colores
            this.BackColor = fondo;
            txtUsuario.BackColor = fondocaja;
            txtContrasena.BackColor = fondocaja;
            txtUsuario.ForeColor = Color.White;
            txtContrasena.ForeColor = Color.White;
            label1.ForeColor = letras;
            lblContrasena.ForeColor = letras;
            lblUsuario.ForeColor = letras;
            lblRegistro.ForeColor = letras;
            lblRegistro.VisitedLinkColor = letras;
            btnIngresar.BackColor = fondocaja;
            btnIngresar.ForeColor = letras;
            Centrar();
        }

        //Función para centrar los elementos en la ventana
        public void Centrar()
        {
            label1.AutoSize = true;
            label1.Location = new Point((ClientSize.Width - label1.Width) / 2, label1.Height * 3);
            int pos = label1.Top + lblUsuario.Height;
            lblUsuario.Location = new Point((ClientSize.Width - txtUsuario.Width) / 2, pos + lblUsuario.Height);
            txtUsuario.Location = new Point((ClientSize.Width - txtUsuario.Width) / 2, pos + lblUsuario.Height + txtUsuario.Height);
            int pos2 = pos + lblUsuario.Height + txtUsuario.Height;
            lblContrasena.Location = new Point((ClientSize.Width - txtContrasena.Width) / 2, pos2 + (lblContrasena.Height*2));
            txtContrasena.Location = new Point((ClientSize.Width - txtContrasena.Width) / 2, pos2 + (lblContrasena.Height * 2)+txtContrasena.Height);
            int posboton = pos2 + (lblContrasena.Height * 2) + txtContrasena.Height;
            btnIngresar.Location = new Point((ClientSize.Width + btnIngresar.Width) / 2, posboton + (btnIngresar.Height*2));
            lblRegistro.Location = new Point((ClientSize.Width - lblRegistro.Width) / 2, posboton + (btnIngresar.Height * 2) + (btnIngresar.Height*2));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //En caso de que se redimencione la ventana mantener la alineación de los elementos
        private void Form1_Resize(object sender, EventArgs e)
        {
            Centrar();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if((txtUsuario.Text.Length <= 0) && (txtContrasena.Text.Length <= 0))
            {
                MessageBox.Show("Favor de ingresar todos los datos");
            }
            else
            {
                Inicio sig = new Inicio();
                sig.Usuario(txtUsuario.Text,txtContrasena.Text);
                this.Hide();
                sig.Show();
            }
        }

        private void lblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }
}
