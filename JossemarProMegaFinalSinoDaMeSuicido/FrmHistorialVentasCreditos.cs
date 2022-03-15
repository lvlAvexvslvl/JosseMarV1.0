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
    public partial class FrmHistorialVentasCreditos : Form
    {
        public FrmHistorialVentasCreditos()
        {
            InitializeComponent();
        }

        CLogicaConsultas sql = new CLogicaConsultas();

        void MostrarVentasCreditoG(string a)
        {
            DgvHistorialV.DataSource = sql.ConsultaTab("SELECT vs_HistorialVentasCreditosOrigin.NF as NFactura, vs_HistorialVentasCreditosOrigin.NombreCli as Nombre, vs_HistorialVentasCreditosOrigin.ApellidoCli as Apellido, vs_HistorialVentasCreditosOrigin.InteresPorcentual as Interés, vs_HistorialVentasCreditosOrigin.Abono,vs_HistorialVentasCreditosOrigin.SubTotal, vs_HistorialVentasCreditosOrigin.Total, vs_HistorialVentasCreditosOrigin.EstadoDeuda as Credito_Estado, vs_HistorialVentasCreditosOrigin.DeudaTotal, vs_HistorialVentasCreditosOrigin.FechaACancelar, vs_HistorialVentasCreditosOrigin.FechaCancelado, vs_HistorialVentasCreditosOrigin.IdUsuario,vs_HistorialVentasCreditosOrigin.IdEstadoV, vs_HistorialVentasCreditosOrigin.IdVentasCredito, vs_HistorialVentasCreditosOrigin.IdFacturaV, vs_HistorialVentasCreditosOrigin.IdCliente FROM vs_HistorialVentasCreditosOrigin WHERE vs_HistorialVentasCreditosOrigin.IdEstadoV = 5 AND vs_HistorialVentasCreditosOrigin.NF LIKE'%"+a+"%'");
        }

        private void FrmHistorialVentasCreditos_Load(object sender, EventArgs e)
        {
            DgvHistorialV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvHistorialV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MostrarVentasCreditoG("");
            DgvHistorialV.Columns["FechaCancelado"].Visible = false;
            DgvHistorialV.Columns["IdUsuario"].Visible = false;
            DgvHistorialV.Columns["IdEstadoV"].Visible = false;
            DgvHistorialV.Columns["IdVentasCredito"].Visible = false;
            DgvHistorialV.Columns["IdFacturaV"].Visible = false;
            DgvHistorialV.Columns["IdCliente"].Visible = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Add";
            DgvHistorialV.Columns.Add(btn);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarVentasCreditoG(TxtBuscar.Text.Trim());
        }

        private void DgvHistorialV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.DgvHistorialV.Columns[e.ColumnIndex].Name == "Add" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celAdd = this.DgvHistorialV.Rows[e.RowIndex].Cells["Add"] as DataGridViewButtonCell;
                Icon iconAdd = new Icon(Environment.CurrentDirectory + @"\\icons8_eye_16.ico");

                e.Graphics.DrawIcon(iconAdd, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.DgvHistorialV.Rows[e.RowIndex].Height = iconAdd.Height + 8;
                this.DgvHistorialV.Columns[e.ColumnIndex].Width = iconAdd.Width + 8;

                e.Handled = true;
            }
        }

        private void DgvHistorialV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            if (this.DgvHistorialV.Columns[e.ColumnIndex].Name == "Add")
            {
                string nomProd = Convert.ToString(DgvHistorialV.CurrentRow.Cells[14].Value).Trim();
                FrmVentasCreditoEspecifico prod = new FrmVentasCreditoEspecifico(nomProd);
                prod.ShowDialog();
                MostrarVentasCreditoG("");
            }
        }
    }
}
