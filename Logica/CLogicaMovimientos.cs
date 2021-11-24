using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class CLogicaMovimientos
    {
        CDatosMovimientos Mov = new CDatosMovimientos();

        public string MovimientoVenta(string idVenta, string Total)
        {
            int idVenta2 = Convert.ToInt32(idVenta.Trim());
            double tot = Convert.ToDouble(Total.Trim());
            return Mov.MovimientoVenta(idVenta2, tot);
        }

        public string MovimientoCompras(string idCompra, string Total)
        {
           int idCompra2 = Convert.ToInt32(idCompra.Trim());
            double tot = Convert.ToDouble(Total.Trim());
            return Mov.MovimientoCompra(idCompra2, tot);
        }

        public string AbrirCaja(string Total)
        {
            double tot = Convert.ToDouble(Total.Trim());
            return Mov.AbrirCaja( tot);
        }

        public string CerrarCaja()
        {
            return Mov.CerrarCaja();
        }

        public string MovDevolucion(string idMovDevolucion, string total)
        {
            int id = Convert.ToInt32(idMovDevolucion.Trim());
            int tot = Convert.ToInt32(total.Trim());
            return Mov.MovimientoDevolucion(id, tot);

        }
        public string MontoActual()
        {
            return Mov.MontoActual();
        }

        public string SaldoD(string Monto, int Tipo)
        {
           return Mov.SaldoDia(Convert.ToDouble(Monto), Tipo);
        }
    }
}
