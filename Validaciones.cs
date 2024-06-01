using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;
namespace Memoria
{
    internal class Validaciones
    {
        public bool Correo(string correo)
        {
            string validacion = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(validacion);
            return regex.IsMatch(correo);
        }

        public bool Nombre(string nombre)
        {
            string validacion = @"^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ\s]+$";
            Regex regex = new Regex(validacion);

            return regex.IsMatch(nombre);
        }

        public bool Usuario(string usuario)
        {
            string validacion = @"^[^\s]+$";
            Regex regex = new Regex(validacion);
            return regex.IsMatch(usuario);
        }
    }
}
