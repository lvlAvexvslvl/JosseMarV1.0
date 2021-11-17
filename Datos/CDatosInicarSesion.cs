using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class CDatosInicarSesion
    {
        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter res;
        public string IniciarSesion(string UserName, string Password, string IpMaquina)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMIniciarSesion";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@UserName", UserName);
                comando.Parameters.AddWithValue("@Password", Password);
                comando.Parameters.AddWithValue("@ipMaquina", IpMaquina);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror");
                return "ERROR3";
            }

        }

        public void CerrarSesion(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SPCerrarSesion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idUsuario", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void MantenerSesion(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SPMantenerSesion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
    }
}
