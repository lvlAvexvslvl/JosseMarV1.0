using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;
namespace Logica
{
    public class CLogicaAgregarClientes
    {
        CDatosAgregarClientes add = new CDatosAgregarClientes();
        // CLogicaObtenerIP ip = new CLogicaObtenerIP();
        public string AddClientes(string Nombre, string Apellido)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AgregarCliente(Nombre, Apellido);


            if (result.Trim() == Convert.ToString(0))
            {
                MessageBox.Show("Lo sentimos. EL Cliente no se puedo agregar. :(");
                return result;
            }
            else
            {
                if (result.Trim() != Convert.ToString(0))
                {
                    MessageBox.Show("El cliente se agregó correctamente. :)");
                }

                return result;

            }
        }

        public string EditarCC(int id, string nombre, string apellido)
        {
            // string IP = ip.ObtenerIp();

            string result = add.Editar(id, nombre, apellido);


            if (result.Trim() == Convert.ToString(0) || result.Trim() != Convert.ToString(0))
            {
                MessageBox.Show("El cliente se actualizó correctamente :).");
                return result;
            }
            return result;
        }
    }
}
