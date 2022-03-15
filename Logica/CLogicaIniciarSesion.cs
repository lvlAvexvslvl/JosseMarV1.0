using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
namespace Logica
{
  public  class CLogicaIniciarSesion
    {
        CDatosInicarSesion iniciar = new CDatosInicarSesion();
        CLogicaObtenerIP ip = new CLogicaObtenerIP();
        string info = "";
        public string IniciarS(string User, string Pass, string IP)
        {


            string result = iniciar.IniciarSesion(User, Pass, IP);
            // Console.WriteLine(result + "agasg");
            if (result.Trim() == "F")
            {
                info = "Su cuenta aún no ha sido validada por el admin. :(";
                MessageBox.Show(info);
                return result;
            }

            else if (result.Trim() == "S")
            {
                //info = "Bienvenido Sr. :)";
                //MessageBox.Show(info);

                return result;
            }

            else if (result.Trim() == "A")
            {
                info = "Espere...";
                MessageBox.Show(info);
                return result;
            }
            else if (result.Trim() == "E")
            {
                MessageBox.Show("Error, Usuario o contraseña incorrectos. :(", "ERROR EN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }

            else if (result.Trim() == "C")
            {
                MessageBox.Show("Lo sentimos... Su cuenta se encuentra bloqueada. :(", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }
            else if (result.Trim() == "Z")
            {
                MessageBox.Show("Su cuenta no ha sido verificada por el Admin. :(", "Notificacíon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return result;
            }
            else if (result.Trim() == "U")
            {
                MessageBox.Show("Su cuenta no tiene los privilegios necesarios para entrar al sistema. :)", "Notificacíon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }

            return result;

        }
        public void CerrarSesion(string id)
        {
            int ID = Convert.ToInt32(id);
            iniciar.CerrarSesion(ID);
        }
        public void MantenerSesion(string id)
        {
            int ID = Convert.ToInt32(id);
            iniciar.MantenerSesion(ID);
        }
        public string Loginl(string User, string Pass)
        {
            string IP = ip.ObtenerIp();

            string result = iniciar.IniciarSesion(User, Pass, IP);
            // Console.WriteLine(result + "agasg");
            if (result.Trim() == "O")
            {

                return "OK";
            }
            else
            {
                if (result.Trim() == "A")
                {
                    MessageBox.Show("Error, El usuario o contraseña son incorrectos", "ERROR EN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (result.Trim() == "B")
                    {
                        MessageBox.Show("Error, Ya se encuentra iniciada la sesión", "ERROR EN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return result;

        }
    }
}
