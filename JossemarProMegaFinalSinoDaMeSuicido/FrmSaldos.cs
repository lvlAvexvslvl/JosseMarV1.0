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
    public partial class FrmSaldos : Form
    {
        public FrmSaldos()
        {
            InitializeComponent();
        }
        CLogicaMovimientos mov = new CLogicaMovimientos();
        CLogicaConsultas c = new CLogicaConsultas();
        private void FrmSaldos_Load(object sender, EventArgs e)
        {
            lblHoy.Text = "C$ " + mov.MontoActual();
            Cargar();
        }
        private void Cargar()
        {
           int mes = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int año = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            DateTime primerD = new DateTime(año,mes,1);
            DateTime ultimoD = primerD.AddMonths(1).AddDays(-1);
            string pd = primerD.ToString("yyyy-MM-dd");
            string ud = ultimoD.ToString("yyyy-MM-dd");
            MessageBox.Show(pd + " - " + ud);
            dgvDiario.DataSource = c.ConsultaTab("SELECT * FROM SaldoDiario WHERE SaldoDiario.Fecha BETWEEN ('"+pd+"') AND ('"+ud+"') ;"); 
        }
    }
}
