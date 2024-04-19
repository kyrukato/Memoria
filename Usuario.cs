using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoria
{
    internal class Usuario
    {
        public String nombre = "";
        public String user = "";
        public String contrasena = "";

        public void Saludar()
        {
            MessageBox.Show($"Bienvenido: {this.nombre}");
        }

        public void ObtenerNombre(String u)
        {
            this.nombre = u;
        }

    }
}
