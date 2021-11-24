using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class CDatosVentas
    {
        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter res;

        public string AgregarVenta(int IdProducto, int IdCliente, double descuento, double cantidadVendida,string FVenta, double SubT,
             double Total, int IdUsuario)
        {
            //SqlParameter x;
            conexion.CerrarConexion();
            try
            {


                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarVentas";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdProducto", IdProducto);
                comando.Parameters.AddWithValue("@IdCliente", IdCliente);
                comando.Parameters.AddWithValue("@Descuento", descuento);
                comando.Parameters.AddWithValue("@CantidadVendida", cantidadVendida);
                comando.Parameters.AddWithValue("@FechaVenta", FVenta);
                comando.Parameters.AddWithValue("@SubTotal", SubT);
                
                comando.Parameters.AddWithValue("@Total", Total);
                comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                
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
