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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            Diseno();
            Centrar();
        }

        private void Diseno()
        {
            //Maximizamos el tamaño de la pantalla
            this.WindowState = FormWindowState.Maximized;
            //Seleccionamos los colores que se van a utilizar
            Color fondo = ColorTranslator.FromHtml("#D9D9D9");
            Color fondocaja = ColorTranslator.FromHtml("#576162");
            Color letras = ColorTranslator.FromHtml("#C30606");
            //Aplicamos los colores
            this.BackColor = fondo;
            lblConfirmar.ForeColor = letras;
            lblContrasena.ForeColor = letras;
            lblCorreo.ForeColor = letras;
            lblNombre.ForeColor = letras;
            lblUsuario.ForeColor = letras;
            txtConfirmar.BackColor = fondocaja;
            txtContrasena.BackColor = fondocaja;
            txtCorreo.BackColor = fondocaja;
            txtNombre.BackColor = fondocaja;
            txtUsuario.BackColor = fondocaja;
            txtConfirmar.ForeColor = Color.White;
            txtContrasena.ForeColor= Color.White;
            txtCorreo.ForeColor= Color.White;
            txtNombre.ForeColor= Color.White;
            txtUsuario.ForeColor= Color.White;
            btnSalir.ForeColor = letras;
            btnSalir.BackColor = fondocaja;
            btnAceptar.ForeColor = letras;
            btnAceptar.BackColor = fondocaja;
            btnCancelar.ForeColor = letras;
            btnCancelar.BackColor = fondocaja;
        }

        private void Centrar()
        {
            lblNombre.Location = new Point((ClientSize.Width - txtNombre.Width)/2, lblNombre.Height *3);
            txtNombre.Location = new Point((ClientSize.Width - txtNombre.Width) / 2, (lblNombre.Height * 3)+txtNombre.Height);
            lblUsuario.Location = new Point((ClientSize.Width - txtNombre.Width) / 2, (lblNombre.Height * 3) + txtNombre.Height + (lblUsuario.Height*2));
            txtUsuario.Location = new Point((ClientSize.Width - txtNombre.Width) / 2, (lblNombre.Height * 3) + txtNombre.Height + (lblUsuario.Height * 2) + txtUsuario.Height);
            lblContrasena.Location = new Point((ClientSize.Width - txtNombre.Width) / 2, (lblNombre.Height * 3) + txtNombre.Height + (lblUsuario.Height * 2) + txtUsuario.Height + (lblContrasena.Height*2));
            txtContrasena.Location = new Point((ClientSize.Width - txtNombre.Width) / 2, (lblNombre.Height * 3) + txtNombre.Height + (lblUsuario.Height * 2) + txtUsuario.Height + (lblContrasena.Height * 2) +txtContrasena.Height);
            lblConfirmar.Location = new Point((ClientSize.Width - txtNombre.Width) / 2, (lblNombre.Height * 3) + txtNombre.Height + (lblUsuario.Height * 2) + txtUsuario.Height + (lblContrasena.Height * 2) + txtContrasena.Height+(lblConfirmar.Height * 2));
            txtConfirmar.Location = new Point((ClientSize.Width - txtNombre.Width) / 2, (lblNombre.Height * 3) + txtNombre.Height + (lblUsuario.Height * 2) + txtUsuario.Height + (lblContrasena.Height * 2) + txtContrasena.Height + (lblConfirmar.Height * 2) +txtConfirmar.Height);
            lblCorreo.Location = new Point((ClientSize.Width - txtNombre.Width) / 2, (lblNombre.Height * 3) + txtNombre.Height + (lblUsuario.Height * 2) + txtUsuario.Height + (lblContrasena.Height * 2) + txtContrasena.Height + (lblConfirmar.Height * 2) + txtConfirmar.Height+(lblCorreo.Height * 2));
            txtCorreo.Location = new Point((ClientSize.Width - txtNombre.Width) / 2, (lblNombre.Height * 3) + txtNombre.Height + (lblUsuario.Height * 2) + txtUsuario.Height + (lblContrasena.Height * 2) + txtContrasena.Height + (lblConfirmar.Height*2) + txtConfirmar.Height + (lblCorreo.Height*2)+txtCorreo.Height);
            btnSalir.Location = new Point(ClientSize.Width - btnSalir.Width, btnSalir.Height);
            btnCancelar.Location = new Point((ClientSize.Width - txtNombre.Width) / 2, (lblNombre.Height * 3) + txtNombre.Height + (lblUsuario.Height * 2) + txtUsuario.Height + (lblContrasena.Height * 2) + txtContrasena.Height + (lblConfirmar.Height * 2) + txtConfirmar.Height + (lblCorreo.Height * 2) + txtCorreo.Height +(btnCancelar.Height*2));
            btnAceptar.Location = new Point(((ClientSize.Width - txtNombre.Width) / 2)+(btnCancelar.Width+98), (lblNombre.Height * 3) + txtNombre.Height + (lblUsuario.Height * 2) + txtUsuario.Height + (lblContrasena.Height * 2) + txtContrasena.Height + (lblConfirmar.Height * 2) + txtConfirmar.Height + (lblCorreo.Height * 2) + txtCorreo.Height + (btnCancelar.Height * 2));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registro_Resize(object sender, EventArgs e)
        {
            Diseno();
            Centrar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario creado exitosamente");
        }
    }
}
