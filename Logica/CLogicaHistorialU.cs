using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
   public class CLogicaHistorialU
    {
        public void AgregarHistorialU(string Fecha, int IdUsuario, string ipMaquina)
        {
            CDatosHistorialU hs = new CDatosHistorialU();
            hs.AgregarHistorialU(Fecha, IdUsuario, ipMaquina);
        }
    }
}
