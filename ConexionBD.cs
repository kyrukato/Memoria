using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoria
{
    internal class ConexionBD
    {
        static String conexion = "Data Source=IvanIbanez\\SQLEXPRESS;Initial Catalog=Memoria;User ID=sa;Password=admin;";
        public SqlConnection bd;
        public void AbrirConexion()
        {
            bd = new SqlConnection(conexion);
            try
            {
                bd.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos " + ex.Message);
            }
        }

        public void CerrarConexion()
        {
            bd = new SqlConnection(conexion);
            try
            {
                bd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión " + ex.Message);
            }
        }
    }
}
