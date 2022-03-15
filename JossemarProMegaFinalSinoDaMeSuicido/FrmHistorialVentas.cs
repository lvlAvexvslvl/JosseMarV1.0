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
    public partial class FrmHistorialVentas : Form
    {
        public FrmHistorialVentas(string a)
        {
            InitializeComponent();
            id = a;
        }
        string id;

        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaLlenarCmb met = new CLogicaLlenarCmb();

        void InicializarLoad()
        {
            LblUsuario.Text = id;
            //DgvHistorialV.DataSource = met.LlenarDgvHistorialVentas("");
            
        }

        void BuscarNFact(string a)
        {
            DgvHistorialV.DataSource = met.LlenarDgvHistorialVentas(a);
        }

        void MostrarVentasAlls()
        {
            DgvHistorialV.DataSource = met.LlenarDgvHistorialVentasAlls();
        }

        //METODO PARA LIMITAR A LOS USUARIOS
        void G()
        {
            LblUsuario.Text = "";
            CLogicaConsultas c = new CLogicaConsultas();
            CLogicaObtenerIP ip = new CLogicaObtenerIP();
            CLogicarecibirId recibirId = new CLogicarecibirId();
            string localIP = ip.ObtenerIp();
            // MessageBox.Show("Ip = "+localIP);
            string idp2 = c.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");
            string idU = c.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina.IpMaquina = '" + localIP + "'");
            string NomU = c.ConsultaSimple("SELECT Usuarios.NombreUsuario FROM Usuarios WHERE Usuarios.IdUsuario ='" + idU + "'");
            string TipoU = c.ConsultaSimple("SELECT Usuarios.IdTipoUsuario FROM Usuarios WHERE Usuarios.IdUsuario ='" + idU + "'");
            if (TipoU == "4")
            {
                PanelRbtn.Enabled = false;
                RbtnEditarVenta.Enabled = false;
                RbtnCancelarV.Enabled = false;
                Rbtb3.Enabled = false;
                Rbn4.Enabled = false;
            }

            recibirId.recibirId((idp2));
        }
        private void FrmHistorialVentas_Load(object sender, EventArgs e)
        {
            G();
            DgvHistorialV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvHistorialV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InicializarLoad();
            //BuscarNFact("");
            MostrarVentasAlls();
            DgvHistorialV.Columns["IdCliente"].Visible = false;
            DgvHistorialV.Columns["IdFacturaVenta"].Visible = false;
            //DgvHistorialV.Columns["IdEstadoV"].Visible = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Add";
            DgvHistorialV.Columns.Add(btn);

        }

        private void RbtnCancelarV_CheckedChanged(object sender, EventArgs e)
        {
            if(RbtnCancelarV.Checked == true)
            {
                FrmCancelarFactura cf = new FrmCancelarFactura();
                cf.ShowDialog();
                RbtnCancelarV.Checked = false;
                MostrarVentasAlls();
            }
            else
            {
                
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(TxtBuscar.Text != "")
            {
                BuscarNFact(TxtBuscar.Text.Trim());
            }
            else if(TxtBuscar.Text == "")
            {
                
                DgvHistorialV.Columns["IdCliente"].Visible = false;
                DgvHistorialV.Columns["IdFacturaVenta"].Visible = false;
                DgvHistorialV.Columns["IdEstadoV"].Visible = false;
                MostrarVentasAlls();
            }
            if (TxtBuscar.Text.Trim() == string.Empty)
            {
                MostrarVentasAlls();
            }
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
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
            if (this.DgvHistorialV.Columns[e.ColumnIndex].Name == "Add")
            {
                //foreach (DataGridViewRow row in DgvInventario.SelectedRows)
                //{
                string nomProd = Convert.ToString(DgvHistorialV.CurrentRow.Cells[9].Value).Trim();
                FrmMostrarVentasEspecificas prod = new FrmMostrarVentasEspecificas(nomProd);
                prod.ShowDialog();
                MostrarVentasAlls();
                //}

            }
        }

        private void DgvHistorialV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (TxtBuscar.Text == "" || TxtBuscar.Text != "")
            {
                DataGridView dgv = sender as DataGridView;

                if (dgv.Columns[e.ColumnIndex].Name == "IdEstadoV")  //Si es la columna a evaluar
                {
                    if (e.Value.ToString().Contains("3") || e.Value.ToString().Contains("2"))   //Si el valor de la celda contiene la palabra hora
                    {
                        foreach (DataGridViewRow row in DgvHistorialV.Rows)
                        {
                            if (row.Cells["IdEstadoV"].Value.ToString() == "3" || row.Cells["IdEstadoV"].Value.ToString() == "2")
                                row.DefaultCellStyle.BackColor = Color.NavajoWhite;
                        }
                        //e.CellStyle.ForeColor = Color.Red;
                        //row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
               // MostrarVentasAlls();
            }
           
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            this.Refresh();
            MostrarVentasAlls();
            
        }
    }
}
