using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
   public class CLogicaVentasCredito
    {
        CDatosVentasCredito add = new CDatosVentasCredito();
        // CLogicaObtenerIP ip = new CLogicaObtenerIP();
        public string AddVenta(int IdCliente, double descuento, double SubT,
         double Total, int IdUsuario)
        {
            string result = add.AgregarVentasContado2(IdCliente, descuento, SubT,
            Total, IdUsuario);

            return result;
        }

        //METODO PARA LLENAR LA TABLA DE VENTAS CREDITO
        public string AgregarVentasCredito(int IdFacturaV, double InteresPorcentual, double DeudaTotal,
            string FechaCancelar, double Abono)
        {
            string result = add.AgregarVentasCredito2(IdFacturaV,InteresPorcentual,DeudaTotal,
             FechaCancelar, Abono);

            return result;
        }
        //AGREGAR VENTAS PRODUCTO CREDITO
        public string AgregarVentasCreditoProd(int IdVentasCredito, int IdProducto, double Cantidad)
        {
            string result = add.AgregarVentasProducto(IdVentasCredito, IdProducto,  Cantidad);

            return result;
        }

    }
}
