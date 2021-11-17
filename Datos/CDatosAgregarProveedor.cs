using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
   public class CDatosAgregarProveedor
    {
        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter res;

        public string AgregarProveedor(string NombreE, string Direccion, string NumeroTelefono, int Tipotel)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgreagarProveedores";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreEmpresa", NombreE);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@TelefonoEmpresa", NumeroTelefono);
                comando.Parameters.AddWithValue("@IdTipoTelefonoE", Tipotel);

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

        public void Editar(int id, string nombre, string direccion, string TelefonoE, int TipoTel)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "JSMEditarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdProveedor", id);
            comando.Parameters.AddWithValue("@NombreEmpresa", nombre);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@TelefonoEmpresa", TelefonoE);
            comando.Parameters.AddWithValue("@IdTipoTelefonoE", TipoTel);
            
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

    }
}
