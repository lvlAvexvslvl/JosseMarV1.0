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
            comando.Parameters.AddWithValue("@idVenta", idCompra);
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
        return c.CSimple("SELECT Movimientos.TotalFactura FROM Movimientos WHERE Movimientos.Fecha='"+fecha+"' AND Movimientos.tipoMovimiento = 4;");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex + "Eroror");
        return "ERROR3";
    }

        }
      
    }
}
