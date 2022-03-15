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
    public partial class FrmVentasCreditoEspecifico : Form
    {
        public FrmVentasCreditoEspecifico(string a)
        {
            InitializeComponent();
            b = a;
        }
        string b;
        CLogicaConsultas sql = new CLogicaConsultas();
        void MostrarProdAll()
        {
            DgvProd.DataSource = sql.ConsultaTab("SELECT vs_VentasProdCreditoE.NombreProducto as Producto, vs_VentasProdCreditoE.Marca, vs_VentasProdCreditoE.DescripcionC as Categoria, vs_VentasProdCreditoE.Descripcion, vs_VentasProdCreditoE.FechaVenta as F_Venta, vs_VentasProdCreditoE.IdVentasCredito, vs_VentasProdCreditoE.IdProducto, vs_VentasProdCreditoE.IdventaProdCredito, vs_VentasProdCreditoE.IdEstadoProd, vs_VentasProdCreditoE.IdEstado FROM vs_VentasProdCreditoE WHERE vs_VentasProdCreditoE.IdVentasCredito = '"+b+ "' AND vs_VentasProdCreditoE.IdEstadoProd <>'2'");
        }

        private void FrmVentasCreditoEspecifico_Load(object sender, EventArgs e)
        {
            DgvProd.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MostrarProdAll();
            DgvProd.Columns["IdProducto"].Visible = false;
            DgvProd.Columns["IdventaProdCredito"].Visible = false;
            DgvProd.Columns["IdVentasCredito"].Visible = false;
            DgvProd.Columns["IdEstadoProd"].Visible = false;
            DgvProd.Columns["IdEstado"].Visible = false;
        }
    }
}
