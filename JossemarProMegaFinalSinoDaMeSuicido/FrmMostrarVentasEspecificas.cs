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
    public partial class FrmMostrarVentasEspecificas : Form
    {
        public FrmMostrarVentasEspecificas(string a)
        {
            InitializeComponent();
            b = a;
        }
        string b = "";
        int idV = 0;
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaLlenarCmb fil = new CLogicaLlenarCmb();
        CLogicaObtenerIP ip = new CLogicaObtenerIP();
        CLogicaVentas vtc = new CLogicaVentas();
        string idp2;
        void MostrarVentaE()
        {
            DgvProd.DataSource = fil.MostrarVentasE(b);
        }

        private void LlenarCmb()
        {
            CbxMotivo.DataSource = fil.cmbDescriEstadoDevolucionV();
            CbxMotivo.DisplayMember = "DescripcionDv";
            CbxMotivo.ValueMember = "IdEstadoDV";
        }

        private void FrmMostrarVentasEspecificas_Load(object sender, EventArgs e)
        {
            MostrarVentaE();
            LlenarCmb();
            DgvProd.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvProd.Columns["IdFacturaVenta"].Visible = false;
            DgvProd.Columns["IdProducto"].Visible = false;
            DgvProd.Columns["IdVentaProd"].Visible = false;
            DgvProd.Columns["IdEstadoProducto"].Visible = false;
            DgvProd.Columns["IdVenta"].Visible = false;


            string localIP = ip.ObtenerIp();
            // MessageBox.Show("Ip = "+localIP);
            idp2 = sql.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");

        }
        private void Movimiento()
        {
            CLogicaMovimientos lg = new CLogicaMovimientos();
            string note = Convert.ToString(idV);
            string total = sql.ConsultaSimple("SELECT SUM(Ventass.Total) FROM Ventass WHERE Ventass.IdFacturaVenta = "+idV);
            lg.MovDevolucion(note, total);
            lg.SaldoD(total, 3);
        }
        void CapturarDtFact()
        {
            int a = DgvProd.RowCount;
            string res = "";
            int tipo = Convert.ToInt32(CbxMotivo.SelectedIndex.ToString());
            tipo = tipo + 1;
            //MessageBox.Show("Tipo = " + tipo);
            if (a > 0)
            {

                int IdU = Convert.ToInt32(idp2);
                for (int i = 0; i < a; i++)
                {
                    idV = Convert.ToInt32(DgvProd.Rows[i].Cells[8].Value);
                    int idp = Convert.ToInt32(DgvProd.Rows[i].Cells[11].Value);

                    //MessageBox.Show("IDV = " + idV);
                    //MessageBox.Show("IDP = " + idp);
                    //MessageBox.Show("IDU = " + IdU);
                    //MessageBox.Show("tipo = " + tipo);

                    res = vtc.CancelarAllNFact(idV, idp, IdU, tipo);

                   //MessageBox.Show("res = "+res);
                }
                if (res.Trim() == "G")
                {
                    MessageBox.Show("La Factura se canceló con éxito. :)", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Movimiento();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al cancelar la factura", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Res = " + res);
                }
            }

            else
            {
                MessageBox.Show("Favor Ingresar un Numero de Factura Válido. :)", "Avíso",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void btnCancelarF_Click(object sender, EventArgs e)
        {
            //Aqui debe de ir el metodo que cancele la factura
            DialogResult result = MessageBox.Show("¿Deseas Cancelar toda esta facura?", "Avíso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                CapturarDtFact();
            }
            else if (result == DialogResult.Cancel)
            {

            }
            
        }

        private void CbxMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int tipo = Convert.ToInt32(CbxMotivo.SelectedIndex.ToString());
            //MessageBox.Show("Tipo = " + tipo);
        }
    }
}
