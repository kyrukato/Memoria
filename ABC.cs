using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoria
{
    internal class ABC : ConexionBD
    {
        int niveles = 9;
        public ABC()
        {

        }

        public void AgregarUsuario(String nombre, String usuario, String contra, String correo, int nivel)
        {

            try
            {
                AbrirConexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = bd;
                String Query = "Insert INTO Usuario (ID,Contrasena,Nombre,Correo,Nivelmax) VALUES (@id,@pass,@nom,@email,@nivel)";
                comando.Parameters.AddWithValue("@id", usuario);
                comando.Parameters.AddWithValue("@pass", contra);
                comando.Parameters.AddWithValue("@nom", nombre);
                comando.Parameters.AddWithValue("@email", correo);
                comando.Parameters.AddWithValue("@nivel", nivel);
                comando.CommandText = Query;
                comando.ExecuteNonQuery();
                for (int i = 0; i < niveles; i++)
                {
                    CrearPuntaje(usuario,(i+1));
                }
                MessageBox.Show("USUARIO AGREGADO EXITOSAMENTE.\nESPERAR EL CORREO DE VALIDACIÓN.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                CerrarConexion();
            }
        }

        public String Consultar(String busqueda, String tabla, String columna, String valor)
        {
            String respuesta = null;
            try
            {
                AbrirConexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = bd;
                String Query = $"Select {busqueda} from {tabla} Where {columna} = @val ";
                comando.Parameters.AddWithValue("@val", valor);
                comando.CommandText = Query;
                object result = comando.ExecuteScalar();
                comando.ExecuteNonQuery();
                respuesta = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                CerrarConexion();
            }
            return respuesta;
        }

        public bool UsuarioExistente(String busqueda, String tabla, String columna, String valor)
        {
            bool existe = false;
            try
            {
                AbrirConexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = bd;
                String Query = $"Select {busqueda} from {tabla} Where {columna} = @val ";
                comando.Parameters.AddWithValue("@val", valor);
                comando.CommandText = Query;
                object result = comando.ExecuteScalar();
                comando.ExecuteNonQuery();
                if(result != null)
                {
                    existe = true;
                }
                else
                {
                    existe = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                CerrarConexion();
            }
            return existe;
        }

        public bool IniciarSesion(String usuario, String contrasena)
        {
            bool encontrado = false;
            try
            {
                AbrirConexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = bd;
                String Query = "Select ID from Usuario Where ID = @u and Contrasena = @c";
                comando.Parameters.AddWithValue("@u", usuario);
                comando.Parameters.AddWithValue("@c", contrasena);
                comando.CommandText = Query;
                object result = comando.ExecuteScalar();
                comando.ExecuteNonQuery();
                if(result != null)
                {
                    encontrado = true;
                }
                else
                {
                    encontrado = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return encontrado;
        }

        public void ActualizarPuntaje(string user, int puntaje, int nivel)
        {
            try
            {
                AbrirConexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = bd;
                String Query = "UPDATE Puntajes SET PuntajeMax = @p WHERE ID = @usr and Nivel = @nivel";
                comando.Parameters.AddWithValue("@usr", user);
                comando.Parameters.AddWithValue("@p", puntaje);
                comando.Parameters.AddWithValue("@nivel", nivel);
                comando.CommandText = Query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void PuntajeRanking(string user, int puntaje, int nivel)
        {
            try
            {
                AbrirConexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = bd;
                String Query = $"UPDATE Nivel SET MaxScore = @p WHERE ID = @nivel ";
                comando.Parameters.AddWithValue("@p", puntaje);
                comando.Parameters.AddWithValue("@nivel", nivel);
                comando.CommandText = Query;
                comando.ExecuteNonQuery();
                String Query2 = $"UPDATE Nivel SET Usuario = @usr WHERE ID = @nivel ";
                comando.Parameters.AddWithValue("@usr", user);
                comando.Parameters.AddWithValue("@nivel", nivel);
                comando.CommandText = Query2;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void ActualizarNivel(string user, int nivel)
        {
            try
            {
                AbrirConexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = bd;
                String Query = "UPDATE Usuario SET Nivelmax = @nivel WHERE ID = @usr";
                comando.Parameters.AddWithValue("@usr", user);
                comando.Parameters.AddWithValue("@nivel", nivel);
                comando.CommandText = Query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void ModificarUsuario(string columna, string dato, string user)
        {
            try
            {
                AbrirConexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = bd;
                String Query = $"UPDATE Usuario SET {columna} = @valor WHERE ID = @usr";
                comando.Parameters.AddWithValue("@usr", user);
                comando.Parameters.AddWithValue("valor", dato);
                comando.CommandText = Query;
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

        }

        private void CrearPuntaje(string user,int nivel)
        {
            try
            {
                AbrirConexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = bd;
                String Query = "Insert INTO Puntajes (ID,Nivel,PuntajeMax) VALUES (@id,@nivel,@score)";
                comando.Parameters.AddWithValue("@id", user);
                comando.Parameters.AddWithValue("@nivel", nivel);
                comando.Parameters.AddWithValue("@score", 0);
                comando.CommandText = Query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                CerrarConexion();
            }
        }

        public int ConsultarPuntaje(String usuario, int nivel)
        {
            int respuesta = 0;
            try
            {
                AbrirConexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = bd;
                String Query = $"Select PuntajeMax from Puntajes Where ID = @val and Nivel = @valor2";
                comando.Parameters.AddWithValue("@val", usuario);
                comando.Parameters.AddWithValue("@valor2", nivel);
                comando.CommandText = Query;
                object result = comando.ExecuteScalar();
                comando.ExecuteNonQuery();
                respuesta = int.Parse(result.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                CerrarConexion();
            }
            return respuesta;
        }

        public DataTable PuntajesAltos()
        {
            DataTable tabla = new DataTable();
            try
            {
                AbrirConexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = bd;
                String Query = $"Select * from Nivel";
                comando.CommandText= Query;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                CerrarConexion();
            }

            return tabla;
        }

    }
}
