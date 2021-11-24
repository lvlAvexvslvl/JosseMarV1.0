using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class CDatosAgregarClientes
    {
        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter res;
        public string AgregarCliente(string Nombre, string Apellido)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarClientes";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreCli", Nombre);
                comando.Parameters.AddWithValue("@ApellidoCli", Apellido);
              

                res = comando.Parameters.AddWithValue("@ult", "");
                comando.Parameters["@ult"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror");
                return "ERROR3"+ex;
            }

        }

        public string Editar(int id, string nombre, string apellido)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMEditarClienteCorriente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdCliente", id);
                comando.Parameters.AddWithValue("@NombreCli", nombre);
                comando.Parameters.AddWithValue("@ApellidoCli", apellido);


                res = comando.Parameters.AddWithValue("@ult", "");
                comando.Parameters["@ult"].Direction = ParameterDirection.Output;

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


    }
}
