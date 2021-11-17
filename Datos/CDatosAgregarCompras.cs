using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    class CDatosAgregarCompras
    {
        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public void GuardarCompraProv(string NombreUsser, string Nombreproveedor, string FechaCompra, string DescripcionCompra, double TotalCompra, int Usuario, int NumeroFactura)
        {
            //SqlParameter x;

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "JSMDetalleCompra";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreUsser", NombreUsser);
            comando.Parameters.AddWithValue("@Nombreproveedor", Nombreproveedor);
            // comando.Parameters.AddWithValue("@NombreProducto", NombreProducto);
            comando.Parameters.AddWithValue("FechaCompra", FechaCompra);
            comando.Parameters.AddWithValue("@DescripcionCompra", DescripcionCompra);
            comando.Parameters.AddWithValue("@TotalCompra", TotalCompra);
            comando.Parameters.AddWithValue("@IdUsuario", Usuario);
            comando.Parameters.AddWithValue("@NumeroFactura", NumeroFactura);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

    }
}
