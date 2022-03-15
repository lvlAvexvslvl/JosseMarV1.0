using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;
namespace Logica
{
    public class CLogicaAddSinFactura
    {
        CDatosAddSinFactura add = new CDatosAddSinFactura();

        public string LogicaAddSinFactura(string Nombre, string Descripcion, double PrecioVenta, int IdCategoria, int IdEstante, int IdUnidadMedida, string FechaCaducidad, double Stock, string Marca)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AddSinFactura(Nombre, Descripcion, PrecioVenta, IdCategoria, IdEstante, IdUnidadMedida, FechaCaducidad, Stock, Marca);


            if (result.Trim() == Convert.ToString(0))
            {
                MessageBox.Show("Lo sentimos. La compra no se puedo agregar. :(");
                return result;
            }
            else
            {
                if (result.Trim() != Convert.ToString(0))
                {
                    MessageBox.Show("La compra se agregó correctamente. :)");
                }

                return result;

            }
        }

        public string LogicaEditarSinFactura(int id, string Nombre, string Descripcion, double PrecioVenta, int IdCategoria, int IdEstante, int IdUnidadMedida, string FechaCaducidad, double Stock, string Marca)
        {
            // string IP = ip.ObtenerIp();

            string result = add.EditarSinFactura(id, Nombre, Descripcion, PrecioVenta, IdCategoria, IdEstante, IdUnidadMedida, FechaCaducidad, Stock, Marca);


            if (result.Trim() == Convert.ToString(0))
            {
                MessageBox.Show("Lo sentimos. La compra no se puedo agregar. :(");
                return result;
            }
            else
            {
                if (result.Trim() != Convert.ToString(0))
                {
                    MessageBox.Show(" producto se edito correctamente. :)");
                }

                return result;

            }
        }

    }
}