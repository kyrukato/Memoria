using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoria
{
    public partial class Contrasena : Form
    {
        ToolTip tt = new ToolTip();
        private ABC abc = new ABC();
        public Contrasena()
        {
            InitializeComponent();
        }

        private void Contrasena_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            tt.SetToolTip(pbRegresar, "REGRESAR");
            tt.SetToolTip(pbSalir,"SALIR");
            tt.InitialDelay = 1000; //Tiempo para aparecer por primera vez
            tt.ReshowDelay = 100; //Tiempo para reaparecer si se mueve el cursor
            tt.AutoPopDelay = 5000; //Para borrar el tooltip despues de aparecer
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("NO PUEDE DEJAR EL CAMPO VACÍO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String pass = GenerarContrasena(8);
                String user = abc.Consultar("ID", "Usuario", "Correo", txtCorreo.Text);
                try
                {
                    abc.ModificarUsuario("Contrasena", pass, user);
                    String mensaje = "Hola " + user + ":\n Su contraseña se ha reestablecido con éxito, su nueva contraseña es: " + pass + ".\n Le sugerimos entrar a su perfil y actualizarla por la de su preferencia.";
                    lblMensaje.Text = mensaje;
                    panelMensaje.Visible = true;
                }
                catch
                {
                    MessageBox.Show("ERROR AL ACTUALIZAR SU CONTRASEÑA");
                }
            }
        }

        private string GenerarContrasena(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(validChars[(int)(num % (uint)validChars.Length)]);
                }
            }
            return res.ToString();
        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA REGRESAR AL INICIO DE SESIÓN?","MENSAJE",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Creamos el formulario de inicio de sesión
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA SALIR DE LA APLICACIÓN?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
