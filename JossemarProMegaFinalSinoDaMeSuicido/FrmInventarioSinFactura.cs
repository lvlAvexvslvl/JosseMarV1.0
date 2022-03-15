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
    public partial class FrmInventarioSinFactura : Form
    {
        public FrmInventarioSinFactura()
        {
            InitializeComponent();
        }
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaLlenarCmb sf = new CLogicaLlenarCmb();
        void MostrarISF(string a)
        {
            DgvPsf.DataSource = sf.MostrarInventarioSinFactura(a);

        }
        void ViewProdAndCantInventario()
        {
            LblTotalProductos.Text = sf.MostrarTotalProdSinFact();
            string precioInv = sf.MostrarCantTotalProdSinFact();
            double PreInv = Convert.ToDouble(precioInv);
            string format = String.Format("{0:#,##0.00}", PreInv);
            LblTotalInventario.Text = format;
        }


        private void FrmInventarioSinFactura_Load(object sender, EventArgs e)
        {
            DgvPsf.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvPsf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MostrarISF("");
            ViewProdAndCantInventario();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarISF(TxtBuscar.Text);
        }
    }
}
