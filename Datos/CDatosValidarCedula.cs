using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Datos
{
   public class CDatosValidarCedula
    {
        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter res;
        public string ValidarCedula(string Cedula)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "IsValidCedula";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NroCedula", Cedula);
                
                res = comando.Parameters.AddWithValue("RETURNS", "");
                comando.Parameters["RETURNS"].Direction = ParameterDirection.ReturnValue;

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

        public void ValidarCedula2(DataGridView data, string Cedula)
        {
            DataTable tab = new DataTable();
            SqlCommand sql = new SqlCommand("IsValidCedula", conexion.AbrirConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@NroCedula", Cedula);
            sql.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sql);
            da.Fill(tab);
            data.DataSource = tab;
        }
    }
}
