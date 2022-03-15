using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;
namespace Logica
{
   public class CLogicaAgregarCompra
    {
        CDatosAgregarCompra add = new CDatosAgregarCompra();
        // CLogicaObtenerIP ip = new CLogicaObtenerIP();
        public string AddCompra(string Nombreprod, int IdProveedor, string FechaIngreso,
            string Descripcion, int IdUnidadM, int NFactura, double TotalC, int IdCategoria, 
            int IdUsuario, double CantidadArt, double PrecioU,string caducidad,string marca,double Precioventa)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AgregarCompra(Nombreprod, IdProveedor, FechaIngreso, Descripcion,  
                IdUnidadM,  NFactura,  TotalC, IdCategoria,  IdUsuario, CantidadArt,PrecioU,caducidad, marca,Precioventa);


            //if (result.Trim() == Convert.ToString(0))
            //{
            //    MessageBox.Show("Lo sentimos. La compra no se pudo realizar. :(");
            //    return result;
            //}
            //else
            //{
            //    if (result.Trim() != Convert.ToString(0))
            //    {
            //        MessageBox.Show("La compra se agregó con éxito. :)");
            //        return result;
            //    }

             return result;

            //}
        }

        public string AddProducto(string IdCompra,string IdEstante, double stock)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AgregarProducto(Convert.ToInt16(IdCompra),Convert.ToInt16(IdEstante),stock);


            if (result.Trim() == "N")
            {
                MessageBox.Show("Lo sentimos. El producto no se pudo agregar. :(");
                return result;
            }
            
                if (result.Trim() == "G")
                {
                    MessageBox.Show("El producto se agregó con éxito. :)");
                    return result;
                }

                return result;

        }

        public string EditCompra(int IdProd, string Nombreprod, int IdProveedor, string FechaIngreso,
            string Descripcion, int IdUnidadM, int NFactura, double TotalC, int IdCategoria,
            int IdUsuario, double CantidadArt, double PrecioU, string caducidad, string marca, double Precioventa)
        {

            string result = add.EditarProdCompra(IdProd,Nombreprod, IdProveedor, FechaIngreso, Descripcion,
                IdUnidadM, NFactura, TotalC, IdCategoria, IdUsuario, CantidadArt, PrecioU, caducidad, marca, Precioventa);

            return result;

        }
    }
}
