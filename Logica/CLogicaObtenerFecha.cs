using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
  public  class CLogicaObtenerFecha
    {
        public string ObtenerFecha()
        {
            //DateTime fecha =  DateTime.Today;
            string fe = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
            return fe;
        }
        public string ObtenerFechaSinHora()
        {
            //DateTime fecha =  DateTime.Today;
            string fe = DateTime.Now.ToString("yyy/MM/dd");
            return fe;
        }
        public string ObtenerHora()
        {
            //DateTime fecha =  DateTime.Today;
            string h = DateTime.Now.ToString("hh:mm:ss");
            return h;
        }
        public string ObtenerFechaSencilla()
        {
            //string fe = DateTime.Now.ToString("dd-MM-yyyy");
            string fe = DateTime.Now.ToLongDateString();
            return fe;
        }
    }
}
