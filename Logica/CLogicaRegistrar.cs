using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;
namespace Logica
{
   public class CLogicaRegistrar
    {
        CDatosRegistrar add = new CDatosRegistrar();
        // CLogicaObtenerIP ip = new CLogicaObtenerIP();
        public string register(string Nombre, string Apellido, string UserName, string Password)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AgregarUsuario(Nombre, Apellido, UserName, Password);

            if (result.Trim() == "S")
            {
                return "Usuario Agregado correctamente";
            }
            else
            {
                if (result.Trim() == "N")
                {
                    MessageBox.Show("Lo sentimos. EL nombre de usuario que eligió ya está en uso. :(");
                }

                return result;

            }
        }
    }
}
