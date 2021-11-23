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
    public partial class FrmVentas : Form
    {
        public FrmVentas(string ids)
        {
            InitializeComponent();
            id = ids;
        }

        string id;
        CLogicaConsultas sql = new CLogicaConsultas();

        void ProductosUnificados(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_ProductosExistentes.NombreProducto AS Producto, vs_ProductosExistentes.Marca AS Marca, vs_ProductosExistentes.DescripcionC AS Categoria,vs_ProductosExistentes.DescripcionTipoUM as UMedida, vs_ProductosExistentes.Descripcion FROM vs_ProductosExistentes WHERE vs_ProductosExistentes.NombreProducto LIKE '%" + a + "%' OR vs_ProductosExistentes.Marca LIKE '%" + a + "%' OR vs_ProductosExistentes.DescripcionC LIKE'%" + a + "%' GROUP BY vs_ProductosExistentes.NombreProducto,vs_ProductosExistentes.Marca,vs_ProductosExistentes.DescripcionC,vs_ProductosExistentes.DescripcionTipoUM,vs_ProductosExistentes.Descripcion");
           
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            LblUsuario.Text = id;
            DgvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductosUnificados("");
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Add";
            DgvProductos.Columns.Add(btn);
           // DgvProductos.Columns["Add"].Visible = false;
            int conteo = DgvProductos.Rows.Count;
            MessageBox.Show("Cantidad de Productos = " + conteo);
            Datasave("");
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            ProductosUnificados(TxtBuscar.Text);
        }

        private void DgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.DgvProductos.Columns[e.ColumnIndex].Name == "Add" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celAdd = this.DgvProductos.Rows[e.RowIndex].Cells["Add"] as DataGridViewButtonCell;
                Icon iconAdd = new Icon(Environment.CurrentDirectory + @"\\icons8_eye_16.ico");

                e.Graphics.DrawIcon(iconAdd, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.DgvProductos.Rows[e.RowIndex].Height = iconAdd.Height + 8;
                this.DgvProductos.Columns[e.ColumnIndex].Width = iconAdd.Width + 8;

                e.Handled = true;

                //DgvProductos.Columns["Add"].Visible = false;
            }
        }

        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvProductos.Columns[e.ColumnIndex].Name == "Add")
            {
                //foreach (DataGridViewRow row in DgvInventario.SelectedRows)
                //{
                string nomProd = Convert.ToString(DgvProductos.CurrentRow.Cells[1].Value).Trim();
                FrmProductosAlls prod = new FrmProductosAlls(nomProd);
                prod.Show();
                //}

            }
        }

       public string Datasave(string idP)
        {
            MessageBox.Show("ID PROD = "+idP);
            return idP;
        }
    }
}
