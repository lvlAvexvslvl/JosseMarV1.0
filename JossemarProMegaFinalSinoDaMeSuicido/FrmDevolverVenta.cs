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
    public partial class FrmDevolverVenta : Form
    {
        public FrmDevolverVenta()
        {
            InitializeComponent();
        }

        CLogicaConsultas sql = new CLogicaConsultas();

        private void FrmDevolverVenta_Load(object sender, EventArgs e)
        {
            DgvRetirarDevolucion.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvRetirarDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgvDesperfectos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvDesperfectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LlenarDataG("");
            LlenarDataG2("");
            DgvRetirarDevolucion.Columns["IdCliente"].Visible = false;
            DgvRetirarDevolucion.Columns["IdFacturaVenta"].Visible = false;
            DgvRetirarDevolucion.Columns["IdEstadoV"].Visible = false;

            DgvDesperfectos.Columns["IdCliente"].Visible = false;
            DgvDesperfectos.Columns["IdFacturaVenta"].Visible = false;
            DgvDesperfectos.Columns["IdEstadoV"].Visible = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Add";
            DgvRetirarDevolucion.Columns.Add(btn);

            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.Name = "Add";
            DgvDesperfectos.Columns.Add(btn2);
        }

        void LlenarDataG(string a)
        {
            DgvRetirarDevolucion.DataSource = sql.ConsultaTab("SELECT vs_VentasUnificadas.NF as NFactura,vs_VentasUnificadas.NombreCli as Nombre_C, vs_VentasUnificadas.ApellidoCli as Apellido_C, vs_VentasUnificadas.PrecioDescuento AS P_Descuento, vs_VentasUnificadas.SubTotal as SubTotal, vs_VentasUnificadas.Total as Total, vs_VentasUnificadas.FechaVenta as F_Venta, vs_VentasUnificadas.IdCliente, vs_VentasUnificadas.IdFacturaVenta, vs_VentasUnificadas.IdEstadoV FROM vs_VentasUnificadas WHERE vs_VentasUnificadas.IdEstadoV = '3' AND vs_VentasUnificadas.NF LIKE'%" + a + "%'");

        }

        void LlenarDataG2(string a)
        {
            DgvDesperfectos.DataSource = sql.ConsultaTab("SELECT vs_VentasUnificadas.NF as NFactura,vs_VentasUnificadas.NombreCli as Nombre_C, vs_VentasUnificadas.ApellidoCli as Apellido_C, vs_VentasUnificadas.PrecioDescuento AS P_Descuento, vs_VentasUnificadas.SubTotal as SubTotal, vs_VentasUnificadas.Total as Total, vs_VentasUnificadas.FechaVenta as F_Venta, vs_VentasUnificadas.IdCliente, vs_VentasUnificadas.IdFacturaVenta, vs_VentasUnificadas.IdEstadoV FROM vs_VentasUnificadas WHERE vs_VentasUnificadas.IdEstadoV = '2' AND vs_VentasUnificadas.NF LIKE'%" + a + "%'");

        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LlenarDataG(txtBuscar.Text.Trim());
        }

        private void DgvRetirarDevolucion_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.DgvRetirarDevolucion.Columns[e.ColumnIndex].Name == "Add" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celAdd = this.DgvRetirarDevolucion.Rows[e.RowIndex].Cells["Add"] as DataGridViewButtonCell;
                Icon iconAdd = new Icon(Environment.CurrentDirectory + @"\\icons8_eye_16.ico");

                e.Graphics.DrawIcon(iconAdd, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.DgvRetirarDevolucion.Rows[e.RowIndex].Height = iconAdd.Height + 8;
                this.DgvRetirarDevolucion.Columns[e.ColumnIndex].Width = iconAdd.Width + 8;

                e.Handled = true;
            }
        }

        private void DgvRetirarDevolucion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvRetirarDevolucion.Columns[e.ColumnIndex].Name == "Add")
            {
                //foreach (DataGridViewRow row in DgvInventario.SelectedRows)
                //{
                string nomProd = Convert.ToString(DgvRetirarDevolucion.CurrentRow.Cells[9].Value).Trim();
                FrmMostrarDevolucionesE prod = new FrmMostrarDevolucionesE(nomProd);
                prod.ShowDialog();
                LlenarDataG("");
                //}

            }
        }

        private void DgvDesperfectos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.DgvDesperfectos.Columns[e.ColumnIndex].Name == "Add" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celAdd = this.DgvDesperfectos.Rows[e.RowIndex].Cells["Add"] as DataGridViewButtonCell;
                Icon iconAdd = new Icon(Environment.CurrentDirectory + @"\\icons8_eye_16.ico");

                e.Graphics.DrawIcon(iconAdd, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.DgvDesperfectos.Rows[e.RowIndex].Height = iconAdd.Height + 8;
                this.DgvDesperfectos.Columns[e.ColumnIndex].Width = iconAdd.Width + 8;

                e.Handled = true;
            }
        }

        private void DgvDesperfectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvDesperfectos.Columns[e.ColumnIndex].Name == "Add")
            {
                //foreach (DataGridViewRow row in DgvInventario.SelectedRows)
                //{
                string nomProd = Convert.ToString(DgvDesperfectos.CurrentRow.Cells[9].Value).Trim();
                FrmMostrarDesperfectosE prod = new FrmMostrarDesperfectosE(nomProd);
                prod.ShowDialog();
                LlenarDataG("");
                //}

            }
        }
    }
}
