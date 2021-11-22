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
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }
        CLogicaConsultas sql = new CLogicaConsultas();

         void InventarioUnificado(string a)
         {
            DgvInventario.DataSource = sql.ConsultaTab("SELECT vs_ProductosExistentes.NombreProducto AS Producto, vs_ProductosExistentes.Marca AS Marca, vs_ProductosExistentes.DescripcionC AS Categoria,vs_ProductosExistentes.DescripcionTipoUM as UMedida, vs_ProductosExistentes.Descripcion FROM vs_ProductosExistentes WHERE vs_ProductosExistentes.NombreProducto LIKE '%"+a+"%' OR vs_ProductosExistentes.Marca LIKE '%"+a+ "%' OR vs_ProductosExistentes.DescripcionC LIKE'%"+a+"%' GROUP BY vs_ProductosExistentes.NombreProducto,vs_ProductosExistentes.Marca,vs_ProductosExistentes.DescripcionC,vs_ProductosExistentes.DescripcionTipoUM,vs_ProductosExistentes.Descripcion");
            //DataGridViewTextBoxColumn Imagen = new DataGridViewTextBoxColumn();
            //Imagen.HeaderText = "Imagen";
            //DgvInventario.Columns.Insert(DgvInventario.Columns.Count , Imagen);
            //DgvInventario.Columns["Imagen"].Visible=false;

           
            //DgvInventario.Name = "Imagen";
            //DgvInventarioColumns.Insert(TABLAEMPACADORES.Columns.Count, col);
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            DgvInventario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //DgvInventario.DataSource = sql.ConsultaTab("SELECT vs_ProductosExistentes.NombreProducto AS Producto, vs_ProductosExistentes.Marca AS Marca, vs_ProductosExistentes.DescripcionC AS Categoria,vs_ProductosExistentes.DescripcionTipoUM, vs_ProductosExistentes.Descripcion FROM vs_ProductosExistentes WHERE vs_ProductosExistentes.NombreProducto LIKE '%%' AND vs_ProductosExistentes.Marca LIKE '%%' GROUP BY vs_ProductosExistentes.NombreProducto,vs_ProductosExistentes.Marca,vs_ProductosExistentes.DescripcionC,vs_ProductosExistentes.DescripcionTipoUM,vs_ProductosExistentes.Descripcion");
            InventarioUnificado("");

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Add";
            DgvInventario.Columns.Add(btn);

            int conteo = DgvInventario.Rows.Count;
            MessageBox.Show("Cantidad de Productos = "+conteo);
        }

        

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            InventarioUnificado(TxtBuscar.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void DgvInventario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.DgvInventario.Columns[e.ColumnIndex].Name == "Add" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celAdd = this.DgvInventario.Rows[e.RowIndex].Cells["Add"] as DataGridViewButtonCell;
                Icon iconAdd = new Icon(Environment.CurrentDirectory + @"\\icons8_eye_16.ico");
                
                e.Graphics.DrawIcon(iconAdd, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.DgvInventario.Rows[e.RowIndex].Height = iconAdd.Height + 8;
                this.DgvInventario.Columns[e.ColumnIndex].Width = iconAdd.Width + 8;

                e.Handled = true;
            }
           
        }

        private void DgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvInventario.Columns[e.ColumnIndex].Name =="Add")
            {
                //foreach (DataGridViewRow row in DgvInventario.SelectedRows)
                //{
                    string nomProd = Convert.ToString(DgvInventario.CurrentRow.Cells[1].Value).Trim();
                FrmProductosAlls prod = new FrmProductosAlls(nomProd);
                prod.Show();
                //}
               
            }
        }
    }
}
