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
    public partial class FrmMostrarDesperfectosE : Form
    {
        public FrmMostrarDesperfectosE(string a)
        {
            InitializeComponent();
            b = a;
        }
        string b;
        CLogicaConsultas sql = new CLogicaConsultas();

        void MostrarDevProd()
        {
            DgvProd.DataSource = sql.ConsultaTab("SELECT vs_DevolucionProveedores.NFact as NFactura, vs_DevolucionProveedores.NombreProducto as Producto, vs_DevolucionProveedores.Marca, vs_DevolucionProveedores.DescripcionC as Categoria,vs_DevolucionProveedores.Descripcion2 as Descripción,vs_DevolucionProveedores.Descripcion as Motivo, vs_DevolucionProveedores.FechaDev AS F_Devolución, vs_DevolucionProveedores.IdVentaProd, vs_DevolucionProveedores.IdVenta, vs_DevolucionProveedores.IdProducto, vs_DevolucionProveedores.IdEstadoProducto FROM vs_DevolucionProveedores WHERE vs_DevolucionProveedores.IdVenta ='" + b + "' AND vs_DevolucionProveedores.IdEstadoProducto = '2'");
        }
        private void FrmMostrarDesperfectosE_Load(object sender, EventArgs e)
        {
            DgvProd.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            MostrarDevProd();
            DgvProd.Columns["IdVentaProd"].Visible = false;
            DgvProd.Columns["IdVenta"].Visible = false;
            DgvProd.Columns["IdProducto"].Visible = false;
            DgvProd.Columns["IdEstadoProducto"].Visible = false;
           
        }
    }
}
