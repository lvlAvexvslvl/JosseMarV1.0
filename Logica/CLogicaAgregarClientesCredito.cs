using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos;
using System.Windows.Forms;
namespace Logica
{
    public class CLogicaAgregarClientesCredito
    {
        CDatosAgregarClientesCredito add = new CDatosAgregarClientesCredito();
        // CLogicaObtenerIP ip = new CLogicaObtenerIP();
        public string AddClientes(string Nombre, string Apellido, string NumeroTelefono, int Tipotel, string Direccion, string Cedula)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AgregarClientes(Nombre, Apellido, NumeroTelefono,Tipotel, Direccion, Cedula);


            if (result.Trim() == "G")
            {
                MessageBox.Show("El cliente se agregó correctamente. :)");
                return result;
            }
            else
            {
                if (result.Trim() == "N")
                {
                    MessageBox.Show("Lo sentimos. EL Cliente no se puedo agregar. :(");
                   
                }
                else if (result.Trim() == "C")
                {
                    MessageBox.Show("Lo sentimos. La cedula que intenta agregar ya existe. :(");

                }


                return result;

            }
        }

        public string AddClientes2(string Nombre, string Apellido, string NumeroTelefono, int Tipotel, string Direccion, string Cedula)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AgregarClientes(Nombre, Apellido, NumeroTelefono, Tipotel, Direccion, Cedula);


            if (result.Trim() == "G")
            {
                //MessageBox.Show("El cliente se agregó correctamente. :)");
                return result;
            }
            else
            {
                if (result.Trim() == "N")
                {
                    //MessageBox.Show("Lo sentimos. EL Cliente no se puedo agregar. :(");
                    return result;
                }
                else if (result.Trim() == "C")
                {
                    //MessageBox.Show("Lo sentimos. La cedula que intenta agregar ya existe. :(");
                    return result;
                }


                return result;

            }
        }
        public string EditarCCC(int ID, string Nombre, string Apellido, string NumeroTelefono, int Tipotel, string Direccion, string Cedula)
        {
            // string IP = ip.ObtenerIp();

            string result = add.EditarCC(ID, Nombre, Apellido, NumeroTelefono, Tipotel, Direccion, Cedula);


            if (result.Trim() == "G" || result.Trim() == "N")
            {
                MessageBox.Show("El cliente se actualizó correctamente. :)");
                return result;
            }
           
                return result;

        }
    }
}
