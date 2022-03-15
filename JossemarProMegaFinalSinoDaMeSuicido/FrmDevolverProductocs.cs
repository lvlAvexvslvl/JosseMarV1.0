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
using Microsoft.VisualBasic;
namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class FrmDevolverProductocs : Form
    {
        public FrmDevolverProductocs(string a)
        {
            InitializeComponent();
            id = a;
        }
        string id;
        CLogicaLlenarCmb fill = new CLogicaLlenarCmb();
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaObtenerFecha fcz = new CLogicaObtenerFecha();
        CLogicaVentas ventas = new CLogicaVentas();
        int estadov = 0;
        /*void cmbEstadoProducts()
        {
            //CmbMD.DataSource = fill.cmbDescriEstadoDevolucionV();
            //CmbMD.DisplayMember = "DescripcionDv";
            //CmbMD.ValueMember = "IdEstadoDV";

        }*/

        void LlenarLoadProd(string a)
        {
            DgvVentasR.DataSource = sql.ConsultaTab("SELECT vs_ProductosVendidos2.NF AS NFactura, vs_ProductosVendidos2.NombreCli AS Nombre, vs_ProductosVendidos2.ApellidoCli AS Apellido, vs_ProductosVendidos2.NombreProducto as Producto, vs_ProductosVendidos2.Marca as Marca, vs_ProductosVendidos2.Cantidad as CantidadVendidad, vs_ProductosVendidos2.PrecioVenta, vs_ProductosVendidos2.IdCompra as Idp, vs_ProductosVendidos2.FechaCaducidad as Caducidad,vs_ProductosVendidos2.FechaVenta as FechaVenta, vs_ProductosVendidos2.IdVentaProd as idvp FROM vs_ProductosVendidos2 WHERE vs_ProductosVendidos2.IdEstadoProducto = 1 AND vs_ProductosVendidos2.NF LIKE'%"+a+"%'");
        }

        void IniciarLoad()
        {
            LblUsuario.Text = id;
           // cmbEstadoProducts();
           
        }

        private void FrmDevolverProductocs_Load(object sender, EventArgs e)
        {
            DgvVentasR.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvVentasR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgvProductoDev.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProductoDev.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            IniciarLoad();
            LlenarLoadProd("");
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
            
        }
        void CapturarDtCarrito()
        {

            int filas = DgvProductoDev.Rows.Count;


            // Verificar si ya esta agegado
            Boolean esta = false;
            if (filas != 0)
            {
                for (int i = 0; i < filas; i++)
                {
                    if (Convert.ToInt32(DgvVentasR.CurrentRow.Cells[0].Value) == Convert.ToInt32(DgvProductoDev.Rows[i].Cells[0].Value) &&
                        Convert.ToString(DgvVentasR.CurrentRow.Cells[1].Value) == Convert.ToString(DgvProductoDev.Rows[i].Cells[1].Value) &&
                        Convert.ToString(DgvVentasR.CurrentRow.Cells[2].Value) == Convert.ToString(DgvProductoDev.Rows[i].Cells[2].Value) &&
                        Convert.ToString(DgvVentasR.CurrentRow.Cells[3].Value) == Convert.ToString(DgvProductoDev.Rows[i].Cells[3].Value) &&
                        Convert.ToString(DgvVentasR.CurrentRow.Cells[4].Value) == Convert.ToString(DgvProductoDev.Rows[i].Cells[4].Value) &&
                        Convert.ToDouble(DgvVentasR.CurrentRow.Cells[5].Value) == Convert.ToDouble(DgvProductoDev.Rows[i].Cells[5].Value)&&
                         Convert.ToDouble(DgvVentasR.CurrentRow.Cells[6].Value) == Convert.ToDouble(DgvProductoDev.Rows[i].Cells[6].Value))
                    {
                        esta = true;

                        break;

                    }
                }

            }

            if (esta)
            {
                MessageBox.Show("El Producto ya se agregó");
            }
            else
            {
                //int filas = 0 + contador;
                //contador++;

                int a = DgvProductoDev.RowCount;



                DgvProductoDev.Rows.Add();
                DgvProductoDev.Rows[filas].Cells[0].Value = DgvVentasR.CurrentRow.Cells[0].Value;
                DgvProductoDev.Rows[filas].Cells[1].Value = DgvVentasR.CurrentRow.Cells[1].Value;
                DgvProductoDev.Rows[filas].Cells[2].Value = DgvVentasR.CurrentRow.Cells[2].Value;
                DgvProductoDev.Rows[filas].Cells[3].Value = DgvVentasR.CurrentRow.Cells[3].Value;
                DgvProductoDev.Rows[filas].Cells[4].Value = DgvVentasR.CurrentRow.Cells[4].Value;
                DgvProductoDev.Rows[filas].Cells[5].Value = DgvVentasR.CurrentRow.Cells[5].Value;
                DgvProductoDev.Rows[filas].Cells[6].Value = DgvVentasR.CurrentRow.Cells[6].Value;
                DgvProductoDev.Rows[filas].Cells[8].Value = DgvVentasR.CurrentRow.Cells[7].Value;
                DgvProductoDev.Rows[filas].Cells[9].Value = DgvVentasR.CurrentRow.Cells[8].Value;
                DgvProductoDev.Rows[filas].Cells[10].Value = DgvVentasR.CurrentRow.Cells[9].Value;
                DgvProductoDev.Rows[filas].Cells[11].Value = DgvVentasR.CurrentRow.Cells[10].Value;
                if (estadov==1)
                {
                    DgvProductoDev.Rows[filas].Cells[7].Value = Convert.ToString("Desperfectos").Trim();
                }
                
                else if (estadov==2)
                {
                    DgvProductoDev.Rows[filas].Cells[7].Value = Convert.ToString("Equivocacion").Trim();
                }
                
            }
        }

        //METODO PARA PEDIR EL ESTADO DE DEVOLUCION
        void EstadoDev()
        {
            String Control;
            if (txtBuscar.Text != "" || txtBuscar.Text=="")
            {
                Control = Microsoft.VisualBasic.Interaction.InputBox("Desperfectos <1> o Equivocación <2>", "Avíso", "1", 100, 0);
                Control = Control.ToUpper();
                Control = Control.Trim();
                switch (Control)
                {
                    case "1":
                        estadov = 1;
                       // MessageBox.Show("1".Trim());
                        CapturarDtCarrito();
                        break;

                    case "2":
                        estadov = 2;
                       // MessageBox.Show("2");
                        CapturarDtCarrito();
                        break;
                    default:
                        MessageBox.Show("Describir un motivo de la devolución del producto", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
               
            }
        }
        public int recibir(int result)
        {
            return result;
            MessageBox.Show("" + result);
        }

        private void DgvVentasR_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EstadoDev();
            
            
        }
        void AgregarDevolucion()
        {
            string idU = id;
            string res = "";

            int a = DgvProductoDev.RowCount;
            for (int i = 0; i < a; i++)
            {
                int NF = Convert.ToInt32(DgvProductoDev.Rows[i].Cells[0].Value);
                int idp = Convert.ToInt32(DgvProductoDev.Rows[i].Cells[8].Value);
                string paraidEstado = Convert.ToString(DgvProductoDev.Rows[i].Cells[7].Value).Trim();
                int ids = Convert.ToInt32(id);
                int idvp = Convert.ToInt32(DgvProductoDev.Rows[i].Cells[11].Value);

                res = ventas.DevolucionProdV(NF, idp, paraidEstado,ids,idvp);
                
                //MessageBox.Show("res -" + res);
               
            }

            LlenarLoadProd("");
            delete();
            if(res == "G")
            {
                MessageBox.Show("Devolución éxitosa. :)");
            }
            else
            {
                MessageBox.Show("Ho, Lo sentimos ha ocurrido un error. :(","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            


        }
        private void btnCancelarF_Click(object sender, EventArgs e)
        {
            AgregarDevolucion();
        }

       void delete()
        {
            DgvProductoDev.Rows.Clear();
            txtBuscar.Text= "";
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            LlenarLoadProd("");
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            LlenarLoadProd(txtBuscar.Text);
        }

        private void AgreUpdateEventHanler(object sender, FrmEditarDevolucion.UpdateEventArgs args)
        {
            LlenarLoadProd("");
        }

        private void ChxEditarD_CheckedChanged(object sender, EventArgs e)
        {
            if(ChxEditarD.Checked == true)
            {
                FrmEditarDevolucion frm = new FrmEditarDevolucion(this);
                frm.UpdateEventHanler += AgreUpdateEventHanler;
                frm.ShowDialog();
            }
            else
            {
                FrmEditarDevolucion frm = new FrmEditarDevolucion(this);
                frm.UpdateEventHanler += AgreUpdateEventHanler;
                frm.Close();
                ChxEditarD.Checked = false;
            }
        }

        private void UpdateTime_Tick(object sender, EventArgs e)
        {
           
            LlenarLoadProd("");
        }
    }
}
