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
    public partial class FrmEditarDevolucion : Form
    {
        public FrmEditarDevolucion(FrmDevolverProductocs dp)
        {
            InitializeComponent();
        }
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaObtenerFecha fcz = new CLogicaObtenerFecha();
        CLogicaVentas ventas = new CLogicaVentas();
        int idvp;

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHanler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }

        }

        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHanler.Invoke(this, args);
        }

        void inicializarLoad()
        {
            DgvRetirarDevolucion.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvRetirarDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LlenarDataG("");
        }
        private void FrmEditarDevolucion_Load(object sender, EventArgs e)
        {
            inicializarLoad();
        }

        void LlenarDataG(string a)
        {
                DgvRetirarDevolucion.DataSource = sql.ConsultaTab("SELECT vs_RetirarDevolucion2.NF as NFactura, vs_RetirarDevolucion2.IdVentaProd as idvp, vs_RetirarDevolucion2.NombreCli as Nombre_C, vs_RetirarDevolucion2.ApellidoCli as Apellido_C, vs_RetirarDevolucion2.NombreProducto Producto,vs_RetirarDevolucion2.Marca, vs_RetirarDevolucion2.Cantidad as Cant_Vendida, vs_RetirarDevolucion2.FechaVenta as F_Venta, vs_RetirarDevolucion2.FechaCaducidad as F_Caducidad, vs_RetirarDevolucion2.FechaDev FROM vs_RetirarDevolucion2 WHERE vs_RetirarDevolucion2.IdEstadoProducto = 2 AND vs_RetirarDevolucion2.NF LIKE'%" + a+"%'");
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LlenarDataG("");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LlenarDataG(txtBuscar.Text);
        }

        void RetirarDev()
        {
            DialogResult result = MessageBox.Show("¿Está seguro de retirar esta devolución?", "Avíso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in DgvRetirarDevolucion.SelectedRows)
                {
                     idvp = Convert.ToInt32(DgvRetirarDevolucion.CurrentRow.Cells[1].Value);
                    string res = ventas.RetirarDev(idvp);
                    LlenarDataG("");
                    if (res.Trim()=="G")
                    MessageBox.Show("Devolución retirada con éxito. :)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else
                    {
                        MessageBox.Show(res);
                    }
                }
                

            }
            else if (result == DialogResult.Cancel)
            {
                RetirarDev();
            }
        }

        private void btnCancelarF_Click(object sender, EventArgs e)
        {
            RetirarDev();
            Actualizar();
        }
    }
}
