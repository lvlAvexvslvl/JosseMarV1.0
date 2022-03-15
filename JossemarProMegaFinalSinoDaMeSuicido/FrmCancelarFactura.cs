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
    public partial class FrmCancelarFactura : Form
    {
        public FrmCancelarFactura()
        {
            InitializeComponent();
        }
        
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaLlenarCmb met = new CLogicaLlenarCmb();
        CLogicaObtenerIP ip = new CLogicaObtenerIP();
        CLogicaVentas vtc = new CLogicaVentas();
        string idp2;
        string res = "", idV;
        void DgvIdProductoVenta(string a)
        {
            DgvIdProductos.DataSource = met.LlenarDgvIdProductoVenta(a);
        }

        void InicializarLoad()
        {
            string localIP = ip.ObtenerIp();

            idp2 = sql.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");
            
           // MessageBox.Show("Mac" + idp2);
        }

        private void FrmCancelarFactura_Load(object sender, EventArgs e)
        {
            DgvIdProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvIdProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InicializarLoad();
        }

        void CapturarDtFact()
        {
            if(TxtNFact.Text != "")
            {
                int a = DgvIdProductos.RowCount;
                if (a > 0)
                {
                    int NF = Convert.ToInt32(TxtNFact.Text);
                    int IdU = Convert.ToInt32(idp2);
                    for (int i = 0; i < a; i++)
                    {
                        
                        int idp = Convert.ToInt32(DgvIdProductos.Rows[i].Cells[0].Value);

                        MessageBox.Show("" + idp);
                       // res = vtc.CancelarAllNFact(NF, idp, IdU);
                    }
                    if (res.Trim()=="G")
                    {
                        MessageBox.Show("La Factura se canceló con éxito. :)","Avíso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //MessageBox.Show("Hubo un error al cancelar la factura", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Res = "+res);
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor Ingresar un Numero de Factura Válido. :)");
            }
            
        }
        
        private void btnCancelarF_Click_1(object sender, EventArgs e)
        {
            if(TxtNFact.Text != "")
            {
                CapturarDtFact();
                this.Close();
            }
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNFact_TextChanged(object sender, EventArgs e)
        {
            string exis = sql.ConsultaSimple("SELECT COUNT(*) FROM Ventass WHERE Ventass.NF = "+TxtNFact.Text.Trim());
            if(exis == "1")
            {
                idV = sql.ConsultaSimple("SELECT Ventass.IdFacturaVenta FROM Ventass WHERE Ventass.NF = " + TxtNFact.Text.Trim());
                DgvIdProductos.DataSource = met.LlenarDgvIdProductoVenta(idV);
            }
              
        }

        private void TxtNFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
    }
}
