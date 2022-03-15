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
    public partial class FrmMostrarDevolucionesE : Form
    {
        public FrmMostrarDevolucionesE(string a)
        {
            InitializeComponent();
            b = a;
        }
        string b = "";

        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaLlenarCmb fil = new CLogicaLlenarCmb();

        void MostrarDevolucionesE()
        {
            DgvProd.DataSource = fil.MostrarDevolucionesE(b);
        }

        private void FrmMostrarDevolucionesE_Load(object sender, EventArgs e)
        {
            MostrarDevolucionesE();
            DgvProd.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProd.Columns["IdFacturaVenta"].Visible = false;
            DgvProd.Columns["IdProducto"].Visible = false;
            DgvProd.Columns["IdVentaProd"].Visible = false;
            DgvProd.Columns["IdEstadoProducto"].Visible = false;
            DgvProd.Columns["IdVenta"].Visible = false;
        }
    }
}
