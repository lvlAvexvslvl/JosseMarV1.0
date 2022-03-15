using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class CDatosControlInventario
    {

        private CConexion conexion = new CConexion();

        public DataTable VerProductosVencidos()
        {
            DataTable tab = new DataTable();
            SqlCommand sql = new SqlCommand("JSMMostrarProductosCaducados", conexion.AbrirConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sql);
            da.Fill(tab);
            return tab;
        }
    }
}
