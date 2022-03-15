using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;
using System.Data;
namespace Logica
{
    public class CLogicaMostrarProductosCaducados
    {
        CDatosControlInventario vtc = new CDatosControlInventario();
        public DataTable VerProductosVentas()
        {

            DataTable dt = new DataTable();

            dt = vtc.VerProductosVencidos();


            return dt;
        }
    }
}
