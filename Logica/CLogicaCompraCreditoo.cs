using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;

namespace Logica
{
    public class CLogicaCompraCreditoo
    {
        CDatosAgregarCompra add = new CDatosAgregarCompra();

        public string LogicaAddCompraCredito(double Interes, double MontoInteres, string fecha, double SaldoPendiente, double SaldoTotal)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AgregarCompraCredito(Interes, MontoInteres, fecha, SaldoPendiente, SaldoTotal);


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

        public string LogicaAddCuotitas(int NCuota, double MontoCuota, string fecha, int Estado)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AgregarCuota(NCuota, MontoCuota, fecha, Estado);


            if (result.Trim() == Convert.ToString(0))
            {
                MessageBox.Show("Lo sentimos. La cuota no se puedo agregar. :(");
                return result;
            }
            else
            {
                if (result.Trim() != Convert.ToString(0))
                {
                    MessageBox.Show("La cuota se agregó correctamente. :)");
                }

                return result;

            }

        }
    }
}
