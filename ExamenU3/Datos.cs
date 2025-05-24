using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExamenU3
{
    public class Datos
    {
        string cadenaConexion = "Data Source=DESKTOP-K7AK4ED\\SQLEXPRESS;Initial Catalog=Productos;Integrated Security=true";
        SqlConnection conexion = null;

        private SqlConnection abrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                return null;
            }
        }

        public bool prueba()
        {
            try
            {
                abrirConexion();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        private void cerrarConexion()
        {
            try
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.ToString());
            }
        }

        public bool EjecutarComando(string cmd)
        {
            try
            {
                SqlCommand comando = new SqlCommand(cmd, abrirConexion());
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el comando: " + ex.ToString());
                return false;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public DataSet comandoDS(string cmd)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd, abrirConexion());
                adaptador.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el comandoDS: " + ex.ToString());
                return null;
            }
            finally
            {
                //cerrarConexion();
            }
        }
    }
}
