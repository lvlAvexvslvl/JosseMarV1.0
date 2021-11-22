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
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioUnitario AS PrecioUnitario,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto = '"+nomProd+"'");
        }

        private void FrmProductosAlls_Load(object sender, EventArgs e)
        {
            DgvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductosAlls();
            DgvProductos.Columns["ID"].Visible = false;
            DgvProductos.Columns["NFactura"].Visible = false;
        }
    }
}
