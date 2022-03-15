using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
   public class CDatosAddSinFactura
    {
        //Con esto hacemos la conexion a Server en la BDD

        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter res;

        public string AddSinFactura(string Nombre, string Descripcion, double PrecioVenta, int IdCategoria, int IdEstante, int IdUnidadMedida, string FechaCaducidad, double Stock, string Marca)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarProductosSinFactura";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombreproducto", Nombre);
                comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                comando.Parameters.AddWithValue("@PrecioVenta", PrecioVenta);
                comando.Parameters.AddWithValue("@IdCategoria", IdCategoria);
                comando.Parameters.AddWithValue("@IdEstante", IdEstante);
                comando.Parameters.AddWithValue("@IdunidadMedida", IdUnidadMedida);
                comando.Parameters.AddWithValue("@FechaCaducidad", FechaCaducidad);
                comando.Parameters.AddWithValue("@Stock", Stock);
                comando.Parameters.AddWithValue("@Marca", Marca);



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


        public string EditarSinFactura(int id,string Nombre, string Descripcion, double PrecioVenta, int IdCategoria, int IdEstante, int IdUnidadMedida, string FechaCaducidad, double Stock, string Marca)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarSinFactura";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdProductoSinNF ", id);
                comando.Parameters.AddWithValue("@NombreProducto ", Nombre);
                comando.Parameters.AddWithValue("@DescripcionPSNF ", Descripcion);
                comando.Parameters.AddWithValue("@PrecioVenta ", PrecioVenta);
                comando.Parameters.AddWithValue("@IdCategoria ", IdCategoria);
                comando.Parameters.AddWithValue("@IdEstante", IdEstante);
                comando.Parameters.AddWithValue("@IdUnidadMedida ", IdUnidadMedida);
                comando.Parameters.AddWithValue("@FechaCaducidad ", FechaCaducidad);
                comando.Parameters.AddWithValue("@Stock ", Stock);
                comando.Parameters.AddWithValue("@Marca ", Marca);



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
