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
        CLogicaVerSaldosAnuales view = new CLogicaVerSaldosAnuales();
        CLogicaObtenerFecha fc = new CLogicaObtenerFecha();
        private void FrmSaldos_Load(object sender, EventArgs e)
        {
            dgvDiario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvDiario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvMensual.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMensual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DateTime date = Convert.ToDateTime(fc.ObtenerFechaSinHora());
            string date2 = date.ToString("yyyy-MM-dd");
           // MessageBox.Show(date2);
            lblHoy.Text = "C$ " + c.ConsultaSimple("SELECT MAX(SaldoDiario.Total) FROM SaldoDiario WHERE SaldoDiario.Fecha = '"+date2+"'");
            lblDev.Text = c.ConsultaSimple("SELECT MAX(SaldoDiario.Devoluciones) FROM SaldoDiario WHERE SaldoDiario.Fecha = '"+ date2+"'");
            
            Cargar();
            CargarSaldosAnuales();
            this.dgvDiario.Columns["idSaldoD"].Visible = false;
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

        private void CargarSaldosAnuales()
        {
            dgvMensual.DataSource = view.VerProductosVentas();
        }
    }
}
