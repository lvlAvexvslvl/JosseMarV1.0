using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;
namespace Logica
{
    public class CLogicaAgregarProveedor
    {
        CDatosAgregarProveedor add = new CDatosAgregarProveedor();
        public string AddProveedor(string NombreE, string Direccion, string NumeroTelefono, int Tipotel)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AgregarProveedor(NombreE,Direccion,NumeroTelefono,Tipotel);

            if (result.Trim() == "G")
            {
                MessageBox.Show("El Proveedor se agregó correctamente. :)");
                return result;
            }

           else if (result.Trim() == "N")
            {
                MessageBox.Show("Lo sentimos. EL Proveedor no se puedo agregar. :(");
                return result;
            }

            else if(result.Trim() == "E")
            {
                MessageBox.Show("El proveedor ya existe. :'(");
                return result;
            }
              
                return result;
        }

        public void Editar(int id, string nombre, string direccion, string TelefonoE, int TipoTel)
        {
            add.Editar(Convert.ToInt16(id), nombre, direccion, TelefonoE,  Convert.ToInt16(TipoTel));
        }

    }
}
