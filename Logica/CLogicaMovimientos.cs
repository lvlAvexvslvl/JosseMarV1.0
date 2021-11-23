using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
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
    }
}
