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
    public class CLogicaAgregarEmpleados
    {

        CDatosAgregarEmpleados add = new CDatosAgregarEmpleados();
        // CLogicaObtenerIP ip = new CLogicaObtenerIP();
        public string AddEmpleados(int idTipoE, string cedula, string nombre, string apellido, string NTel, int IdTipoT, string direccion)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AgregarEmpleados(idTipoE, cedula,  nombre, apellido,  NTel,  IdTipoT, direccion);


            if (result.Trim() == "G")
            {
                MessageBox.Show("El empleado se agregó correctamente. :(", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return result;
            }
            
             else if (result.Trim() == "T")
                {
                MessageBox.Show("El Numero de teléfono que ingresó ya existe. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return result;
             }

            else if (result.Trim() == "N")
            {
                MessageBox.Show("El Numero de cédula que ingresó ya existe. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }


            return result;

            
        }
        public void Prueba()
        {
            DialogResult rs = new DialogResult();
          rs =  MessageBox.Show("Pruebita...","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            if(rs == DialogResult.OK)
            {
                Console.WriteLine("Si da esta chingadera");
            }else if(rs == DialogResult.Cancel)
            {
                Console.WriteLine("Salado, no da ...");
            }

        }
        public DataTable cmbEmpleados()
        {

            String sql2 = "SELECT IdTipoEmpleado, DescripcionTE FROM TipoEmpleado";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public string EditarE(int IdEmpleado, int idTipoE, string cedula, string nombre, string apellido, string NTel, int IdTipoT, string direccion)
        {
            string result = add.EditarE(IdEmpleado, idTipoE, cedula, nombre,  apellido,  NTel, IdTipoT,  direccion);


            if (result.Trim() == "G")
            {
                MessageBox.Show("El empleado se Actualizó correctamente. :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return result;
            }
            return result;
        }
    }
}
