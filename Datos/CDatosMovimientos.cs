using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class CDatosMovimientos
    {
        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand(); 
    CDatosConsulta c = new CDatosConsulta();
        public string MovimientoVenta(int idVenta, double Total)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMMovimientoVenta";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idVenta", idVenta);
                comando.Parameters.AddWithValue("@Total", Total);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();


                return "Guardado";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror");
                return "ERROR3";
            }

        }
    
    public string MovimientoCompra(int idCompra, double Total)
    {
        try
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "JSMMovimientoCompra";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCompra", idCompra);
            comando.Parameters.AddWithValue("@Total", Total);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

            return "Guardado";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex + "Eroror");
            return "ERROR3"+ex;
        }

    }

        public string MovimientoDevolucion(int idMDevolucion, double Total)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMMovimientoDevolucion";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idDevolucionV", idMDevolucion);
                comando.Parameters.AddWithValue("@Total", Total);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return "Guardado";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror");
                return "ERROR3" + ex;
            }

        }

        public string AbrirCaja(double Total)
    {
    try
    {
        comando.Connection = conexion.AbrirConexion();
        comando.CommandText = "JSMAbrirCaja";
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("@Total", Total);
        comando.ExecuteNonQuery();
        comando.Parameters.Clear();

        return "Guardado";
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex + "Eroror");
        return "ERROR3";
    }

    }
    
  public string CerrarCaja()
{
    try
    {
        comando.Connection = conexion.AbrirConexion();
        comando.CommandText = "JSMCerrarCaja";
        comando.CommandType = CommandType.StoredProcedure;
        comando.ExecuteNonQuery();
        comando.Parameters.Clear();

                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                string id = c.CSimple("SELECT MAX(idMovimientos) FROM Movimientos WHERE Movimientos.tipoMovimiento = 4; ");
        return c.CSimple("SELECT Movimientos.TotalFactura FROM Movimientos WHERE Movimientos.Fecha='"+fecha+ "' AND Movimientos.tipoMovimiento = 4 AND Movimientos.idMovimientos = '"+id+"'");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex + "Eroror");
        return "ERROR88" + ex;
    }

        }

        public string MontoActual()
        {
            try
            {
                string result = "";
                DataTable dt = new DataTable();
                SqlCommand sql = new SqlCommand("JSMMontoActual", conexion.AbrirConexion());
                sql.CommandType = CommandType.StoredProcedure;
                sql.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                   result = Convert.ToString(dt.Rows[0][0]);
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror");
                return "ERROR3" + ex;
            }

        }

        public string SaldoDia(double Total, int tipo)
        {
            
            try
            {
               
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMSaldoDiario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Monto", Total);
                comando.Parameters.AddWithValue("@Tipo", tipo);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return "Guardado";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror");
                return "Er"+ ex.ToString();
            }

        }

    }
}
