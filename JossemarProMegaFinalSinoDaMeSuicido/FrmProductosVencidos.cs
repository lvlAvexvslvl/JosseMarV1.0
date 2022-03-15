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
    public partial class FrmProductosVencidos : Form
    {
        public FrmProductosVencidos()
        {
            InitializeComponent();
        }

        CLogicaMostrarProductosCaducados prod = new CLogicaMostrarProductosCaducados();

        void ProductosVencidos()
        {
            DgvProductos.DataSource = prod.VerProductosVentas();
        }
        private void FrmProductosVencidos_Load(object sender, EventArgs e)
        {
            DgvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductosVencidos();
            DgvProductos.Columns["IdCompra"].Visible = false;
            
        }
    }
}
