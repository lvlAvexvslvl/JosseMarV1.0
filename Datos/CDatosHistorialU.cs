using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
   
    public class CDatosHistorialU
    {
        private CConexion conexion = new CConexion();
        SqlCommand comando = new SqlCommand();
        public void AgregarHistorialU(string Fecha, int IdUsuario, string ipMaquina)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "JSMHistorialUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fecha", Convert.ToDateTime(Fecha));
            comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            comando.Parameters.AddWithValue("@ipMaquina", ipMaquina);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();



        }
    }
}
