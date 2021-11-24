using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class CLogicaVentas
    {
        
            CDatosVentas add = new CDatosVentas();
            // CLogicaObtenerIP ip = new CLogicaObtenerIP();
            public string AddVenta(int IdProducto, int IdCliente, double descuento, double cantidadVendida, string FVenta, double SubT, double Total, int IdUsuario)
            {
                // string IP = ip.ObtenerIp();

                string result = add.AgregarVenta(IdProducto,IdCliente, descuento, cantidadVendida, FVenta,  SubT,
               Total, IdUsuario);


               
                return result;

                
            }
    }
}
