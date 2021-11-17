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
    public class CLogicaLlenarCmb
    {
        public DataTable cmbCategoria()
        {

            String sql2 = "SELECT IdCategoria, DescripcionC FROM Categoria WHERE Categoria.IdEstadoCategoria = '1'";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable cmbProveedores()
        {

            String sql2="SELECT IdProveedor, Proveedor.NombreEmpresa FROM Proveedor WHERE Proveedor.IdEstado = '1'";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable cmbUnidadM()
        {

            String sql2 = "SELECT UnidadMedida.IdUnidadM, UnidadMedida.DescripcionTipoUM FROM UnidadMedida";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

    }
}
