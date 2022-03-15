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
    public partial class FrmActividades : Form
    {
        CLogicaMovimientos log = new CLogicaMovimientos();
        CLogicaConsultas lc = new CLogicaConsultas();
        string fecha = DateTime.Now.ToString("yyyy-MM-dd");
       
        public FrmActividades()
        {
            InitializeComponent();
        }

        private void FrmActividades_Load(object sender, EventArgs e)
        {
            dgvCompras.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDetalles.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvVerMov.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvVerMov.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Existir();
            CargarVista();
            this.dgvVerMov.Columns["idMovimientos"].Visible = false;
            this.dgvDetalles.Columns["idMovimientos"].Visible = false;
            this.dgvCompras.Columns["idMovimientos"].Visible = false;
        }
        
        private void Existir()
        {
           string id = lc.ConsultaSimple("SELECT MAX(idMovimientos) FROM Movimientos WHERE Movimientos.Fecha = '" + fecha + "' AND Movimientos.tipoMovimiento = 4;");
            string val = lc.ConsultaSimple("SELECT COUNT(*) FROM Movimientos WHERE Movimientos.Fecha = '" + fecha + "' AND Movimientos.tipoMovimiento = 3 AND idMovimientos >'"+id+"';");
          //  MessageBox.Show(val);
            if (val != null || val != "")
            {
               int valor = Convert.ToInt32(val.Trim());
                if(valor > 0)
                {
                    gbAbrir.Enabled = true;
                }
                else
                {
                    gbCerrar.Enabled = false;
                }
            }
        }

        private void CargarVista()
        {
            dgvVerMov.DataSource = lc.ConsultaTab("SELECT Movimientos.idMovimientos,Movimientos.Fecha,Movimientos.Descripcion,tipoMovimiento.Descripcion AS Tipo, Movimientos.TotalFactura AS Total FROM Movimientos, tipoMovimiento WHERE Movimientos.Fecha = '" + fecha + "' AND Movimientos.tipoMovimiento = tipoMovimiento.idTipoM;");
            dgvDetalles.DataSource = lc.ConsultaTab("SELECT Movimientos.idMovimientos,Movimientos.Fecha,Movimientos.Descripcion, Movimientos.TotalFactura AS Total FROM Movimientos WHERE Movimientos.Fecha = '" + fecha + "' AND Movimientos.tipoMovimiento = 2;");
            dgvCompras.DataSource = lc.ConsultaTab("SELECT Movimientos.idMovimientos,Movimientos.Fecha,Movimientos.Descripcion, Movimientos.TotalFactura AS Total FROM Movimientos WHERE Movimientos.Fecha = '" + fecha + "' AND Movimientos.tipoMovimiento = 1;");
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if(txtMonto.Text != "")
            {
                log.AbrirCaja(txtMonto.Text.ToString().Trim());
                gbAbrir.Enabled = false;
                gbCerrar.Enabled = true;
                CargarVista();
                lblMonto.Text = "C$ 0";
            }
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            string dat = log.CerrarCaja();
            MessageBox.Show(dat);
            lblMonto.Text = "C$ " + dat;
            gbAbrir.Enabled =true;
            gbCerrar.Enabled = false;
            CargarVista();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosPuntosyComas(e);
        }
    }
}
