using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
    public class CLogicaContadorCedula
    {
        CDatosContadorCedula cont = new CDatosContadorCedula();
        public string ContadorCedula(string cedula)
        {
            string result = cont.BuscarCedula(cedula);

                return result;
            
        }

        public string ContadorCedulaEmpleado(string cedula)
        {
            string result = cont.BuscarCedulaEmpleados(cedula);

            return result;

        }

        public string ContadorTelefonos(string telefono)
        {
            string result = cont.ContadorTel(telefono);

            return result;

        }
    }
}
