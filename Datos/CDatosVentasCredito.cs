using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
   public class CDatosVentasCredito
    {
        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter res;

        public string AgregarVentasContado2(int IdCliente, double descuento, double SubT,
            double Total, int IdUsuario)
        {
            //SqlParameter x;
            conexion.CerrarConexion();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarVentasContado2";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IdCliente", IdCliente);
                comando.Parameters.AddWithValue("@Descuento", descuento);
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
                return Convert.ToString(ex);
            }

        }

        //METODO PARA LLENAR LA TABLA DE VENTAS AL CREDITO
        public string AgregarVentasCredito2(int IdFacturaV, double InteresPorcentual, double DeudaTotal,
            string FechaCancelar, double Abono)
        {
            //SqlParameter x;
            conexion.CerrarConexion();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarVentasCredito";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IdFacturaV", IdFacturaV);
                comando.Parameters.AddWithValue("@InteresPorcentual", InteresPorcentual);
                comando.Parameters.AddWithValue("@DeudaTotal", DeudaTotal);
                comando.Parameters.AddWithValue("@FechaCancelar", FechaCancelar);
             
                //comando.Parameters.AddWithValue("@FechaCancelado", IdUsuario);
                comando.Parameters.AddWithValue("@Abono", Abono);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror");
                return Convert.ToString(ex);
            }

        }
        //METODO PARA LLENAR LA TABLA DE VENTAS CREDITO PRODUCTO
        public string AgregarVentasProducto(int IdVentasCredito, int IdProducto, double Cantidad)
        {
            //SqlParameter x;
            conexion.CerrarConexion();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMVentasCreditoProducto";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IdVentasCredito", IdVentasCredito);
                comando.Parameters.AddWithValue("@IdProducto", IdProducto);
                comando.Parameters.AddWithValue("@Cantidad", Cantidad);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror");
                return Convert.ToString(ex);
            }

        }
    }
}
