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
    public partial class FrmProductosAlls : Form
    {
        public FrmProductosAlls(string nom)
        {
            InitializeComponent();
            nomProd = nom;
        }
        string nomProd;
        CLogicaConsultas sql = new CLogicaConsultas();
        void ProductosAlls()
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto = '" + nomProd+ "' AND vs_BtnViewInventario.IdEstado =1");
        }

        void FechasCaducidad()
        {
            DgvCaducidad.DataSource = sql.ConsultaTab("SELECT Compra.FechaCaducidad FROM Compra WHERE Compra.Stock <> '.00' AND Compra.FechaCaducidad <> '0000-00-00'");
        }
        private void FrmProductosAlls_Load(object sender, EventArgs e)
        {
            DgvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductosAlls();
            FechasCaducidad();
            DgvProductos.Columns["ID"].Visible = false;
            DgvProductos.Columns["NFactura"].Visible = false;
        }

        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //FrmVentas v = new FrmVentas("");
            
            //foreach (DataGridViewRow row in DgvProductos.SelectedRows)
            //{
            //    v.Datasave(Convert.ToString(DgvProductos.CurrentRow.Cells[0].Value).Trim());
            //    v.CapturarDatosExternos(Convert.ToString(DgvProductos.CurrentRow.Cells[2].Value).Trim(), Convert.ToString(DgvProductos.CurrentRow.Cells[5].Value).Trim(), Convert.ToString(DgvProductos.CurrentRow.Cells[10].Value).Trim());
            //}

        }

        private void DgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
