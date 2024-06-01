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
    public partial class Perfil : Form
    {
        private ToolTip tt = new ToolTip();
        private String usuario = "";
        private ABC abc = new ABC();
        private Validaciones validar = new Validaciones();
        private bool editar = false;
        public Perfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            pbPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            pbGuardarCambios.SizeMode = PictureBoxSizeMode.Zoom;
            pbEditar.SizeMode = PictureBoxSizeMode.Zoom;
            tt.SetToolTip(pbCerrarSesion,"CERRAR SESION");
            tt.InitialDelay = 1000; //Tiempo para aparecer por primera vez
            tt.ReshowDelay = 100; //Tiempo para reaparecer si se mueve el cursor
            tt.AutoPopDelay = 5000; //Para borrar el tooltip despues de aparecer
            tt.SetToolTip(pbRegresar,"REGRESAR");
            tt.SetToolTip(pbGuardarCambios,"GUARDAR CAMBIOS");
            tt.SetToolTip(pbEditar,"EDITAR PERFIL");
            pbRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            pbCerrarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            txtNombre.Text = abc.Consultar("Nombre", "Usuario", "ID", usuario);
            txtUsuario.Text = usuario;
            txtCorreo.Text = abc.Consultar("Correo","Usuario","ID",usuario);

        }

        public void Usuario(String n)
        {
            this.usuario = n;
        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA REGRESAR AL MENU PRINCIPAL?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Inicio inicio = new Inicio();
                inicio.Usuario(usuario);
                inicio.Show();
                this.Close();
            }
        }

        private void pbCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                pbGuardarCambios.Enabled = true;
                txtNombre.ReadOnly = false;
                txtContrasena.ReadOnly = false;
                txtConfirmar.ReadOnly = false;
                pbGuardarCambios.Cursor = Cursors.Hand;
                pbEditar.Cursor = Cursors.No;
                editar = true;
                MessageBox.Show("AHORA PUEDE ACTUALIZAR SU INFORMACIÓN");
            }
        }

        private void pbGuardarCambios_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string contrasena = txtContrasena.Text;
            string confirmar = txtConfirmar.Text;
            if (editar)
            {
                try
                {
                    if (!String.IsNullOrWhiteSpace(nombre))
                    {
                        if (validar.Nombre(nombre))
                        {
                            abc.ModificarUsuario("Nombre", nombre, usuario);
                        }
                        else
                        {
                            MessageBox.Show("EL NOMBRE DE USUARIO NO ES VALIDO.\nNO DEBE CONTENER NÚMEROS NI CARACTERES ESPECIALES");
                        }
                    }
                    if (!String.IsNullOrWhiteSpace(contrasena))
                    {
                        if (contrasena.Equals(confirmar))
                        {
                            if (contrasena.Length >= 5)
                            {
                                if (validar.Usuario(contrasena))
                                {
                                    abc.ModificarUsuario("Contrasena", contrasena, usuario);
                                }
                                else
                                {
                                    MessageBox.Show("LA CONTRASEÑA NO ES VALIDA.\nNO DEBE CONTENER ESPACIOS");
                                }
                            }
                            else
                            {
                                MessageBox.Show("LA CONSTRASEÑA DEBE CONTENER AL MENOS 5 CARACTERES");
                            }
                        }
                        else
                        {
                            MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN");
                        }
                    }
                    editar = false;
                    txtNombre.ReadOnly = true;
                    txtContrasena.ReadOnly = true;
                    txtConfirmar.ReadOnly = true;
                    pbGuardarCambios.Cursor = Cursors.No;
                    pbEditar.Cursor = Cursors.Hand;
                    MessageBox.Show("INFORMACIÓN ACTUALIZADA CORRECTAMENTE");
                }
                catch
                {
                    MessageBox.Show("OCURRIÓ UN ERROR AL INTENTAR ACTUALIZAR SUS DATOS.\nFAVOR DE INTENTARLO MAS TARDE");
                }
            }
        }
    }
}
