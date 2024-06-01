using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Memoria
{
    public partial class Form1 : Form
    {

        private String phUsuario = "USUARIO123";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Maximizamos el tamaño de la pantalla
            this.WindowState = FormWindowState.Maximized;
            //Seleccionamos los colores que se van a utilizar
            Color fondocaja = Color.White;
            Color letras = Color.White;
            //Aplicamos los colores
            txtUsuario.BackColor = fondocaja;
            txtContrasena.BackColor = fondocaja;
            txtUsuario.Text = phUsuario;
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Enter += RemovePlaceholder;
            txtUsuario.Leave += SetPlaceholder;
            txtContrasena.ForeColor = Color.Gray;
            label1.ForeColor = letras;
            lblContrasena.ForeColor = letras;
            lblUsuario.ForeColor = letras;
            lblRegistro.ForeColor = letras;
            lblRegistro.VisitedLinkColor = letras;
            btnIngresar.BackColor = fondocaja;
            btnIngresar.ForeColor = Color.Gray;
            btnojo.BackgroundImage = Properties.Resources.eye_solid;
            btnojo.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = Properties.Resources.fondo;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtUsuario.Text == phUsuario)
            {
                txtUsuario.Text = "";
                
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = phUsuario;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if((txtUsuario.Text.Length <= 0) && (txtContrasena.Text.Length <= 0))
            {
                MessageBox.Show("Favor de ingresar todos los datos");
            }
            else
            {
                ABC abc = new ABC();
                if(abc.IniciarSesion(txtUsuario.Text, txtContrasena.Text))
                {
                    Inicio sig = new Inicio();
                    sig.Usuario(txtUsuario.Text);
                    sig.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTOS");
                }
            }
        }

        private void lblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void btnojo_Click(object sender, EventArgs e)
        {
            // Alternar entre mostrar y ocultar la contraseña
            if (txtContrasena.PasswordChar == '\0')
            {
                txtContrasena.PasswordChar = '*'; // Ocultar contraseña
                btnojo.BackgroundImage = Properties.Resources.eye_solid;
            }
            else
            {
                txtContrasena.PasswordChar = '\0'; // Mostrar contraseña
                btnojo.BackgroundImage = Properties.Resources.eye_slash_solid;
            }
        }

        private void lblrecuperarcontra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Show();
            this.Hide();
        }
    }
}
