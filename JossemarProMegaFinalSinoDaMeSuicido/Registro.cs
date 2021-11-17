using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        string result = "";
        void capturarDatos()
        {
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string nombreUsuario = TxtNameUsuario.Text;
            string pass = TxtContraseña.Text;
            string confirmarPass = TxtConfirmarContraseña.Text;

            if (pass.Trim() != confirmarPass.Trim())
            {
                result = "Las contraseñas ingresadas, no coinciden. :(";
                MessageBox.Show(result, "Error 404 :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CLogicaRegistrar a = new CLogicaRegistrar();
                Inicio i = new Inicio();
                Registro r = new Registro();
                string msg = a.register(nombre, apellido, nombreUsuario, pass);
                result = "Ta bien";

                MessageBox.Show(msg);
                r.Close();
                i.Show();
            }


        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            capturarDatos();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Inicio a = new Inicio();
            a.Show();
            this.Close();
        }
    }
}
