using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
namespace Logica
{
    public class CLogicaAdmin
    {
        CDatosAdmin a = new CDatosAdmin();
        public string AddPrivilegios(string NomCli, int estado)
        {
            // string IP = ip.ObtenerIp();

            string result = a.AddInv(NomCli,estado);

            return result;
        }
    }
}
