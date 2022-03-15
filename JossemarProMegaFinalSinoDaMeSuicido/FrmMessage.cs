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
    public partial class FrmMessage : Form
    {
        public FrmMessage()
        {
            InitializeComponent();
        }
        CLogicaLlenarCmb fill = new CLogicaLlenarCmb();
        void cmbEstadoProducts()
        {
            CmbMD.DataSource = fill.cmbDescriEstadoDevolucionV();
            CmbMD.DisplayMember = "DescripcionDv";
            CmbMD.ValueMember = "IdEstadoDV";

        }

        private void FrmMessage_Load(object sender, EventArgs e)
        {
            cmbEstadoProducts();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (CmbMD.SelectedValue.ToString() == "1")
            {
                
                CLogicaConsultas c = new CLogicaConsultas();
                CLogicaObtenerIP ip = new CLogicaObtenerIP();
                CLogicarecibirId recibirId = new CLogicarecibirId();
                string localIP = ip.ObtenerIp();

               string idp2 = c.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");

              string  a = idp2;
                FrmDevolverProductocs f = new FrmDevolverProductocs(a);
                f.recibir(1);

            }
            else if (CmbMD.SelectedValue.ToString() == "2")
            {

                CLogicaConsultas c = new CLogicaConsultas();
                CLogicaObtenerIP ip = new CLogicaObtenerIP();
                CLogicarecibirId recibirId = new CLogicarecibirId();
                string localIP = ip.ObtenerIp();

                string idp2 = c.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");

                string a = idp2;
                FrmDevolverProductocs f = new FrmDevolverProductocs(a);
                f.recibir(2);
            }
        }
    }
}
