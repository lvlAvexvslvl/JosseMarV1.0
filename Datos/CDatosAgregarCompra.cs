using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class CDatosAgregarCompra
    {
        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter res;

        public string AgregarCompra(string Nombreprod, int IdProveedor, string FechaIngreso, 
            string Descripcion, int IdUnidadM, int NFactura, double TotalC, int IdCategoria, int
            IdUsuario, double CantidadArt, double PrecioU,string caducidad, string Marca,double PrecioVenta)
        {
            //SqlParameter x;
            conexion.CerrarConexion();
            try
            {
                

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarCompra";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreProd", Nombreprod);
                comando.Parameters.AddWithValue("@IdProveedor", IdProveedor);
                comando.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
                comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                comando.Parameters.AddWithValue("@IdUnidadMedidad", IdUnidadM);
                comando.Parameters.AddWithValue("@NumeroFactura", NFactura);
                comando.Parameters.AddWithValue("@TotalCompra", TotalC);
                comando.Parameters.AddWithValue("@IdCategoria", IdCategoria);
                comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                comando.Parameters.AddWithValue("@stock", CantidadArt);
                comando.Parameters.AddWithValue("@PrecioUnitario", PrecioU);
                comando.Parameters.AddWithValue("@FechaCaducidad", caducidad);
                comando.Parameters.AddWithValue("@Marca", Marca);
                comando.Parameters.AddWithValue("@PrecioVenta", PrecioVenta);

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

        public string AgregarProducto(int IdCompra,int IdEstante, double stock)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdCompra", IdCompra);
                //comando.Parameters.AddWithValue("@Precioventa", PrecioVenta);
                comando.Parameters.AddWithValue("@IdEstante", IdEstante);
                comando.Parameters.AddWithValue("@Stock", stock);
                
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
