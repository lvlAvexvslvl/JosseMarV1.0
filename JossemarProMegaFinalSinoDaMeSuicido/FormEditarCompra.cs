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
    public partial class FormEditarCompra : Form
    {
        public FormEditarCompra(string a)
        {
            InitializeComponent();
            id = a;
        }

        CLogicaLlenarCmb fill = new CLogicaLlenarCmb();
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaAgregarCompra buy = new CLogicaAgregarCompra();
        CLogicaObtenerFecha fcz = new CLogicaObtenerFecha();
        string id;
        string IdProducto;
        int contagod = 0;


        void G()
        {
            LblIdUsuario.Text = "";
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
                BtnEditar.Enabled = false;
                BtnLimpiar.Enabled = false;
                ChxEditar.Enabled = false;
            }

            recibirId.recibirId((idp2));
        }

        private void FormEditarCompra_Load(object sender, EventArgs e)
        {
            G();
            DgvEditProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvEditProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            LblIdUsuario.Text = id;
            EditsProd("");

            cmbCategorias();
            cmbProveedores();
            cmbUnidadMedida();

            this.DgvEditProducts.Columns["IdProv"].Visible = false;
            this.DgvEditProducts.Columns["IDUM"].Visible = false;
            this.DgvEditProducts.Columns["IDC"].Visible = false;
            this.DgvEditProducts.Columns["IDU"].Visible = false;
            this.DgvEditProducts.Columns["ID"].Visible = false;
        }

        //METODOS PARA LLENAR COMBOBOX
        void cmbCategorias()
        {
            CmbCategoria.DataSource = fill.cmbCategoria();
            CmbCategoria.DisplayMember = "DescripcionC";
            CmbCategoria.ValueMember = "IdCategoria";

        }

        void cmbProveedores()
        {
            CmbEmpresa.DataSource = fill.cmbProveedores();
            CmbEmpresa.DisplayMember = "NombreEmpresa";
            CmbEmpresa.ValueMember = "IdProveedor";

        }

        void cmbUnidadMedida()
        {
            CmbUnidadMedida.DataSource = fill.cmbUnidadM();
            CmbUnidadMedida.DisplayMember = "DescripcionTipoUM";
            CmbUnidadMedida.ValueMember = "IdUnidadM";

        }


        void Delete()
        {
            TxtNombreProducto.Text = "";
            TxtDescripcion.Text = "";
            CmbCategoria.Text = "";
            CmbUnidadMedida.Text = "";
            TxtPrecioUnitario.Text = "";
            CmbEmpresa.Text = "";
            TxtTotalArt.Text = "";
            DtpFecha.Text = "";
            TxtNFactura.Text = "";
            TxtMarca.Text = "";
            TxtPrecioVenta.Text = "";
            TxtCategoria.Text = "";
            TxtUnidadMedida.Text = "";
        }

        private void DgvCarrito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if(ChxEditar.Checked == true)
            {
                IdProducto = Convert.ToString(DgvEditProducts.CurrentRow.Cells[17].Value).Trim();
                TxtNFactura.Text = Convert.ToString(DgvEditProducts.CurrentRow.Cells[8].Value).Trim();
                TxtNombreProducto.Text = Convert.ToString(DgvEditProducts.CurrentRow.Cells[0].Value).Trim();
                TxtDescripcion.Text = Convert.ToString(DgvEditProducts.CurrentRow.Cells[1].Value).Trim();
                TxtMarca.Text = Convert.ToString(DgvEditProducts.CurrentRow.Cells[9].Value).Trim();
                TxtTotalArt.Text = Convert.ToString(DgvEditProducts.CurrentRow.Cells[6].Value).Trim();
                TxtPrecioUnitario.Text = Convert.ToString(DgvEditProducts.CurrentRow.Cells[4].Value).Trim();
                TxtPrecioVenta.Text = Convert.ToString(DgvEditProducts.CurrentRow.Cells[16].Value).Trim();

                CmbCategoria.SelectedValue = DgvEditProducts.Rows[e.RowIndex].Cells[14].Value.ToString();
                CmbEmpresa.SelectedValue = DgvEditProducts.Rows[e.RowIndex].Cells[11].Value.ToString();
                CmbUnidadMedida.SelectedValue = DgvEditProducts.Rows[e.RowIndex].Cells[12].Value.ToString();
                try
                {
                    DtpFecha.Value = Convert.ToDateTime(DgvEditProducts.Rows[e.RowIndex].Cells[7].Value);
                }
                catch (Exception)
                {


                }


                if (CmbCategoria.SelectedValue.ToString() == "6")
                {
                    DtpCaducidad.Enabled = false;
                    //DtpFecha.Enabled = true;
                }
                else
                {
                    //DtpCaducidad.Enabled = true;
                    try
                    {
                        DtpCaducidad.Value = Convert.ToDateTime(DgvEditProducts.Rows[e.RowIndex].Cells[10].Value);
                    }
                    catch (Exception)
                    {


                    }


                }
            }
                
            contagod++;
        }
        //METODO PARA VALIDAR CAMPOS
        int MetodoValidar()
        {
            int validation = 0;
            if (TxtNombreProducto.Text != "")
                validation++;

            else
                validation--;

            if (TxtDescripcion.Text != "")
                validation++;

            else
                validation--;

            if (TxtPrecioUnitario.Text != "")
                validation++;

            else
                validation--;

            if (TxtTotalArt.Text != "")
                validation++;

            else
                validation--;

            if (TxtNFactura.Text != "")
                validation++;
            else
                validation--;

            if (TxtMarca.Text != "")
                validation++;
            else
                validation--;
            if (TxtPrecioVenta.Text != "")
                validation++;
            else
                validation--;

            if (validation < 0)
                validation = 0;
            return validation;
        }
        //METODO PARA CAPTURAR DATOS DE COMPRA
        void CapturarDatEditar()
        {
            if (contagod > 0)
            {
                if (ChxEditar.Checked == true)
                {
                    if (MetodoValidar() == 7)
                    {
                        if (DtpCaducidad.Value > DtpFecha.Value && DtpFecha.Value < DtpCaducidad.Value)
                        {
                            string nom = TxtNombreProducto.Text.Trim();
                            string des = TxtDescripcion.Text.Trim();
                            int idcategoria = Convert.ToInt32(CmbCategoria.SelectedValue.ToString());
                            int UnidadM = Convert.ToInt16(CmbUnidadMedida.SelectedValue.ToString());
                            double PrecioU = Convert.ToDouble(TxtPrecioUnitario.Text);
                            double PrecioV = Convert.ToDouble(TxtPrecioVenta.Text);
                            int IdProv = Convert.ToInt16(CmbEmpresa.SelectedValue.ToString());
                            double Stock = Convert.ToDouble(TxtTotalArt.Text);
                            string fechaI = DtpFecha.Value.ToString("yyy/MM/dd");
                            int NF = Convert.ToInt32(TxtNFactura.Text);
                            string marca = TxtMarca.Text.Trim();
                            string FCadu = DtpCaducidad.Value.ToString("yyy/MM/dd");
                            //double taux = Convert.ToDouble(TxtTotalCompra.Text);
                            //double totalCompra = (taux + (totalart * PrecioU));
                            //TxtTotalCompra.Text = Convert.ToString(totalCompra);
                            double TotalC = (Stock * PrecioU);
                            int idprod = Convert.ToInt32(IdProducto);
                            int idU = Convert.ToInt16(id);

                            buy.EditCompra(idprod, nom, IdProv, fechaI, des, UnidadM, NF, TotalC, idcategoria, idU, Stock, PrecioU, FCadu,
                                marca, PrecioV);

                            MessageBox.Show("Producto editado con éxito :)"+IdProducto, "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error. La fecha de caducidad debe ser mayor a la de ingreso :)", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error. Uno o más campos están vacíos :)", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           
            

        }

        void EditsProd(string a)
        {
            DgvEditProducts.DataSource = sql.ConsultaTab("SELECT vs_EditarCompra.NombreProducto AS Producto, vs_EditarCompra.Descripcion as Descripcion, vs_EditarCompra.DescripcionC AS Categoría, vs_EditarCompra.DescripcionTipoUM as UMedida, vs_EditarCompra.PrecioUnitario AS PrecioU, vs_EditarCompra.NombreEmpresa AS Proveedor, vs_EditarCompra.Stock  AS Cantidad, vs_EditarCompra.FechaIngreso AS Ingreso,vs_EditarCompra.NumeroFactura AS NFactura, vs_EditarCompra.Marca as Marca, vs_EditarCompra.FechaCaducidad as Caducidad, vs_EditarCompra.IdProveedor as IdProv, vs_EditarCompra.IdUnidadMedida as IDUM,vs_EditarCompra.TotalCompra as TC, vs_EditarCompra.IdCategoria as IDC, vs_EditarCompra.IdUsuario as IDU, vs_EditarCompra.PrecioVenta as PVenta,vs_EditarCompra.IdCompra as ID FROM vs_EditarCompra WHERE vs_EditarCompra.NombreProducto LIKE'%" + a + "%' OR vs_EditarCompra.Marca LIKE'%" + a + "%' OR vs_EditarCompra.DescripcionC LIKE '%" + a + "%'");
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
           
                CapturarDatEditar();

                EditsProd("");
                Delete();
            
               
            ChxEditar.Checked = false;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            EditsProd(TxtBuscar.Text);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Delete();
           // DgvEditProducts.Rows.Clear();
        }

        private void ChxEditar_Click(object sender, EventArgs e)
        {
           
        }

        //void ActivarFormarDate()
        //{

        //    DtpCaducidad.MaxDate = DateTime.Today.AddDays(999999);
        //    DtpCaducidad.MinDate = DateTime.Now.AddDays(1);

        //    DtpFecha.MinDate = DateTime.Today.AddDays(-3);
        //    DtpFecha.MaxDate = DateTime.Today;
        //}

        //Metodo para habilitar campos
        void HabilitarProNew()
        {
            Delete();
            ActivarFormarDate();
            BtnBuscar.Enabled = false;
            TxtBuscar.Enabled = false;
            //DgvSave.Enabled = false;
            TxtCategoria.Visible = false;

            CmbCategoria.Visible = true;
            CmbCategoria.Enabled = true;

            CLogicaObtenerFecha fc = new CLogicaObtenerFecha();
            string fecha = fc.ObtenerFechaSinHora();
            //DtpFecha.MinDate = Convert.ToDateTime(fecha);

            //DtpFecha.MinDate = Convert.ToDateTime(fecha);

            //DtpCaducidad.MinDate = Convert.ToDateTime(fecha);
            TxtNombreProducto.Enabled = true;
            TxtDescripcion.Enabled = true;
            CmbCategoria.Enabled = true;
            CmbUnidadMedida.Enabled = true;
            CmbUnidadMedida.Visible = true;
            TxtPrecioUnitario.Enabled = true;
            CmbEmpresa.Enabled = true;
            TxtTotalArt.Enabled = true;
            DtpFecha.Enabled = false;
            DtpCaducidad.Enabled = false;
            TxtNFactura.Enabled = true;
            TxtMarca.Enabled = true;
            TxtPrecioVenta.Enabled = true;
            TxtUnidadMedida.Visible = false;
           
        }
        void ActivarFormarDate()
        {

            DtpCaducidad.MaxDate = DateTime.Today.AddDays(999999);
            DtpCaducidad.MinDate = DateTime.Now.AddDays(1);

            DtpFecha.MinDate = DateTime.Today.AddDays(-3);
            DtpFecha.MaxDate = DateTime.Today;
        }

        private void ChxEditar_CheckedChanged(object sender, EventArgs e)
        {
            DtpFecha.Enabled = false;
            DtpCaducidad.Enabled = false;
            if (ChxEditar.Checked == true)
            {
                HabilitarProNew();

                
                TxtBuscar.Enabled = true;
                DtpFecha.Enabled = false;
                DtpCaducidad.Enabled = false;
                TxtNFactura.Enabled = false;
                TxtTotalArt.Enabled = false;
                TxtPrecioUnitario.Enabled = false;
                TxtPrecioVenta.Enabled = false;
                
                if (CmbCategoria.SelectedValue.ToString() == "6")
                {
                    DtpFecha.Enabled = false;
                    DtpCaducidad.Enabled = false;
                }
                else
                {
                    //DtpFecha.Enabled = true;
                    //DtpCaducidad.Enabled = true;
                }

            }
            else
            {
               // ActivarFormarDate();
                TxtNFactura.Enabled = false;
                TxtNombreProducto.Enabled = false;
                TxtDescripcion.Enabled = false;
                CmbEmpresa.Enabled = false;
                CmbCategoria.Enabled = false;
                CmbUnidadMedida.Enabled = false;
                TxtMarca.Enabled = false;
                TxtTotalArt.Enabled = false;
                TxtPrecioUnitario.Enabled = false;
                TxtPrecioVenta.Enabled = false;
                DtpFecha.Enabled = false;
                DtpCaducidad.Enabled = false;

                //ChxNuevo.Enabled = true;
                //ChxExistente.Enabled = true;
            }
        }

        
    }
}
