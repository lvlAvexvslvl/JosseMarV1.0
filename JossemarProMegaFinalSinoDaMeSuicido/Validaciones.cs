using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public class Validaciones
    {
        public static void SoloNumeros(KeyPressEventArgs Pe)
        {
            if (char.IsDigit(Pe.KeyChar))
            {
                Pe.Handled = false;
            }
            else if (char.IsControl(Pe.KeyChar))
            {
                Pe.Handled = false;
            }
            else
            {
                Pe.Handled = true;
            }

        }

        public static void SoloNumerosPuntosyComas(KeyPressEventArgs Pe)
        {
            if (char.IsDigit(Pe.KeyChar) || char.IsNumber(Pe.KeyChar) || char.IsControl(Pe.KeyChar)
                || Pe.KeyChar == ',' || Pe.KeyChar == '.')
            {
                Pe.Handled = false;
            }
            else if (char.IsControl(Pe.KeyChar))
            {
                Pe.Handled = false;
            }
            else
            {
                Pe.Handled = true;
            }
           
        }

        public static void SoloLetras(KeyPressEventArgs Pe)
        {
            if (char.IsLetter(Pe.KeyChar))
            {
                Pe.Handled = false;
            }
            else if (char.IsControl(Pe.KeyChar))
            {
                Pe.Handled = false;
            }
            else if (char.IsSeparator(Pe.KeyChar))
            {
                Pe.Handled = false;
            }
            else
            {
                Pe.Handled = true;
            }

        }



    }
}
