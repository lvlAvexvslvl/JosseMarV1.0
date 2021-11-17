using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class CDatosAgregarClientesCredito
    {
        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter res;

        public string AgregarClientes(string Nombre, string Apellido, string NumeroTelefono,int Tipotel, string Direccion, string Cedula)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarClientesCredito";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreCli", Nombre);
                comando.Parameters.AddWithValue("@ApellidoCli", Apellido);
                comando.Parameters.AddWithValue("@NumeroTelefono", NumeroTelefono);
                comando.Parameters.AddWithValue("@IdTipoTel", Tipotel);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@Cedula", Cedula);
            
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

        public string EditarCC(int ID, string Nombre, string Apellido, string NumeroTelefono, int Tipotel, string Direccion, string Cedula)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMEditarClienteCredito";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdClienteCredito", ID);
                comando.Parameters.AddWithValue("@NombreCli", Nombre);
                comando.Parameters.AddWithValue("@ApellidoCli", Apellido);
                comando.Parameters.AddWithValue("@NumeroTelefono", NumeroTelefono);
                comando.Parameters.AddWithValue("@IdTipoTel", Tipotel);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@Cedula", Cedula);

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
    }
}
