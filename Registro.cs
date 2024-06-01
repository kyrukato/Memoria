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
        private ToolTip tt = new ToolTip();
        private Validaciones validar = new Validaciones();
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            //Maximizamos el tamaño de la pantalla
            this.WindowState = FormWindowState.Maximized;
            Diseno();
        }

        private void Diseno()
        {
            pbRegresar.Focus();
            tt.SetToolTip(pbSalir, "SALIR");
            tt.InitialDelay = 1000; //Tiempo para aparecer por primera vez
            tt.ReshowDelay = 100; //Tiempo para reaparecer si se mueve el cursor
            tt.AutoPopDelay = 5000; //Para borrar el tooltip despues de aparecer
            tt.SetToolTip(pbRegresar, "REGRESAR");
            pbRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            pbSalir.BackgroundImageLayout = ImageLayout.Stretch;
            txtNombre.PlaceholderText = "NOMBRE APELLIDO";
            txtUsuario.PlaceholderText = "USUARIO123";
            txtContrasena.PlaceholderText = "CONTRASEÑA123";
            txtConfirmar.PlaceholderText = "CONTRASEÑA123";
            txtCorreo.PlaceholderText = "EJEMPLO@EJEMPLO.COM";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registro_Resize(object sender, EventArgs e)
        {
            Diseno();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CamposVacios())
                {
                    if (txtContrasena.Text.Equals(txtConfirmar.Text))
                    {
                        if (ValidarCampos(txtNombre.Text,txtUsuario.Text,txtCorreo.Text,txtContrasena.Text))
                        {
                            ABC abc = new ABC();
                            if(abc.UsuarioExistente("Correo","Usuario","Correo",txtCorreo.Text) || abc.UsuarioExistente("ID", "Usuario", "ID", txtUsuario.Text))
                            {
                                if(abc.UsuarioExistente("Correo", "Usuario", "Correo", txtCorreo.Text))
                                {
                                    MessageBox.Show("EL CORREO YA HA SIDO REGISTRADO","LO SENTIMOS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                                if(abc.UsuarioExistente("ID", "Usuario", "ID", txtUsuario.Text))
                                {
                                    MessageBox.Show("NOMBRE DE USUARIO NO DISPONIBLE", "LO SENTIMOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                abc.AgregarUsuario(txtNombre.Text, txtUsuario.Text, txtContrasena.Text, txtCorreo.Text, 1);
                                txtNombre.Text = "";
                                txtUsuario.Text = "";
                                txtContrasena.Text = "";
                                txtConfirmar.Text = "";
                                txtCorreo.Text = "";
                                txtNombre.PlaceholderText = "NOMBRE APELLIDO";
                                txtUsuario.PlaceholderText = "USUARIO123";
                                txtContrasena.PlaceholderText = "CONTRASEÑA123";
                                txtConfirmar.PlaceholderText = "CONTRASEÑA123";
                                txtCorreo.PlaceholderText = "EJEMPLO@EJEMPLO.COM";
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN");
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private bool CamposVacios()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO NOMBRE");
                return true;
            }
            else if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO USUARIO");
                return true;
            }
            else if (string.IsNullOrEmpty(txtContrasena.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO CONTRASEÑA");
                return true;
            }
            else if (string.IsNullOrEmpty(txtConfirmar.Text) || string.IsNullOrWhiteSpace(txtConfirmar.Text))
            {
                MessageBox.Show("FAVOR DE CONFIRMAR LA CONTRASEÑA");
                return true;
            }
            else if (string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO CORREO");
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidarCampos(String nombre, String usuario, String correo, String contrasena)
        {
            if(!validar.Nombre(nombre))
            {
                MessageBox.Show("EL NOMBRE NO DEBE CONTENER CARACTERES ESPECIALES NI NÚMEROS");
                return false;
            }
            else if(!validar.Usuario(usuario))
            {
                MessageBox.Show("EL NOMBRE DE USUARIO NO DEBE CONTENER ESPACIOS");
                return false;
            }
            else if(contrasena.Length < 5)
            {
                MessageBox.Show("SU CONTRASEÑA DEBE CONTENER AL MENOS 5 CARACTERES SIN ESPACIOS");
                return false;
            }
            else if (!validar.Usuario(contrasena))
            {
                MessageBox.Show("LA CONTRASEÑA NO DEBE CONTENER ESPACIOS");
                return false;
            }
            else if (!validar.Correo(correo))
            {
                MessageBox.Show("CORREO NO VÁLIDO");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿DESEA REGRESAR AL INICIO DE SESIÓN?","MENSAJE",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                //Se crea el objeto Form1 (El de login) y se hace visible
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿DESEA CERRAR LA APLICACIÓN?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
