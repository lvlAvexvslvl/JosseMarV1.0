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
    public partial class Form1 : Form
    {

        public Form1(string a)
        {
            InitializeComponent();
            id = a;
           
        }
        CLogicaLlenarCmb fill = new CLogicaLlenarCmb();
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaAgregarCompra buy = new CLogicaAgregarCompra();
        int contador = 0, contadorAdd = 0;
        string id;
        double totalCompra=0, totalCompra2;
        int idcategoria, UnidadM, IdProv;
        string categoria, unidadMedida, proveedor, IdEstante;
        double PrecioU, totalart;
        double TotalC;
        string[] nombresProd;
        string[] marcaProd;
        private void TxtCajas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);

        }

        private void TxtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }

        private void TxtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        //METODO PARA VALIDAR LAS ENTRADAS DE DATOS SEGUN LA UNIDAD DE MEDIDA
        

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CmbUnidadMedida.SelectedValue.ToString() == "1")
            {
                Validaciones.SoloNumeros(e);
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "2")
            {
                Validaciones.SoloNumerosPuntosyComas(e);
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "3")
            {
                Validaciones.SoloNumeros(e);
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "4")
            {
                Validaciones.SoloNumeros(e);
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "5")
            {
                Validaciones.SoloNumeros(e);
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "6")
            {
                Validaciones.SoloNumeros(e);
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "7")
            {
                Validaciones.SoloNumeros(e);
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "8")
            {
                Validaciones.SoloNumeros(e);
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "9")
            {
                Validaciones.SoloNumerosPuntosyComas(e);
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "10")
            {
                Validaciones.SoloNumeros(e);
            }

        }

        private void TxtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
        }
        //private Form activarfrm = null;
        //private void ActivarFrm(Form frmVarios)
        //{
        //    if (activarfrm != null)
        //        activarfrm.Close();
        //    activarfrm = frmVarios;
        //    frmVarios.TopLevel = false;
        //    frmVarios.FormBorderStyle = FormBorderStyle.None;
        //    frmVarios.Dock = DockStyle.Fill;
        //    PnlMostarFrames.Controls.Add(frmVarios);
        //    PnlMostarFrames.Tag = frmVarios;
        //    frmVarios.BringToFront();
        //    frmVarios.Show();
        //}
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

        //METODO PARA LLAMAR LA VISTA DE PRODUCTOS EN EXISTENCIA
        void ProductosE(string a)
        {
           
            DgvSave.DataSource = sql.ConsultaTab("SELECT vs_ProductosExistentes.Descripcion, vs_ProductosExistentes.DescripcionTipoUM, vs_ProductosExistentes.IdCompra AS ID, vs_ProductosExistentes.NombreProducto AS Nombre, vs_ProductosExistentes.Marca AS Marca,vs_ProductosExistentes.DescripcionC AS Categoria FROM vs_ProductosExistentes where vs_ProductosExistentes.NombreProducto LIKE'%" + a+"%' AND vs_ProductosExistentes.Marca LIKE '%"+a+"%'");
           
        }

        void DgvNomProducts()
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_ProductosExistentes.NombreProducto AS Nombre FROM vs_ProductosExistentes");
        }
        void DgvNomProducts2()
        {
            DgvMarca.DataSource = sql.ConsultaTab("SELECT vs_ProductosExistentes.Marca AS Marca FROM vs_ProductosExistentes");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            TxtTotalCompra.Text = "0";
            LblIdUsuario.Text = id;
            DgvCarrito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgvSave.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvSave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductosE("");
            this.DgvSave.Columns["Descripcion"].Visible = false;
            this.DgvSave.Columns["DescripcionTipoUM"].Visible = false;

            cmbCategorias();
            cmbProveedores();
            cmbUnidadMedida();
            DgvNomProducts();
            DgvNomProducts2();
            int Nomp = DgvProductos.Rows.Count;
            int marca22 = DgvMarca.Rows.Count;
            MessageBox.Show(" " + Nomp);
            MessageBox.Show(" " + marca22);
            nombresProd = new string[Nomp];
            marcaProd = new string[Nomp];
            for (int i = 0; i < Nomp; i++)
            {
                nombresProd[i] = Convert.ToString(DgvProductos.Rows[i].Cells[0].Value).Trim();
                marcaProd[i] = Convert.ToString(DgvMarca.Rows[i].Cells[0].Value).Trim(); ;
            }

            //MessageBox.Show(CmbUnidadMedida.SelectedValue.ToString()); /*retorna uno*/
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void TxtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosPuntosyComas(e);
        }

        //METODO PARA HABILITAR CUANDO UN PRODUCTO ES NUEVO
        void HabilitarProNew()
        {
            Delete();

            BtnBuscar.Enabled = false;
            TxtBuscar.Enabled = false;
            DgvSave.Enabled = false;
            TxtCategoria.Visible = false;

            CmbCategoria.Visible = true;
            CmbCategoria.Enabled = true;

            CLogicaObtenerFecha fc = new CLogicaObtenerFecha();
            string fecha = fc.ObtenerFechaSinHora();
            DtpFecha.MinDate = Convert.ToDateTime(fecha);

            DtpFecha.MinDate = Convert.ToDateTime(fecha);

            DtpCaducidad.MinDate = Convert.ToDateTime(fecha);
            TxtNombreProducto.Enabled = true;
            TxtDescripcion.Enabled = true;
            CmbCategoria.Enabled = true;
            CmbUnidadMedida.Enabled = true;
            TxtPrecioUnitario.Enabled = true;
            CmbEmpresa.Enabled = true;
            TxtTotalArt.Enabled = true;
            DtpFecha.Enabled = true;
            DtpCaducidad.Enabled = true;
            TxtNFactura.Enabled = true;
            TxtMarca.Enabled = true;
            TxtPrecioVenta.Enabled = true;
            TxtUnidadMedida.Visible = false;
        }
        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int data = DgvCarrito.RowCount;
            if (data > 0) { 
            DialogResult result = MessageBox.Show("¿Se eliminará lo que tienes en el carrito, estás seguro de hacerlo?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                    DgvCarrito.Rows.Clear();
                    HabilitarProNew();
                    contador = 0;
                }
            else if (result == DialogResult.Cancel)
            {
                    
            }
            else if (result == DialogResult.Cancel)
            {
            }
            }
            HabilitarProNew();
            
        }

        private void TxtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosPuntosyComas(e);
        }

       

        private void TxtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }

        private void DgvCarrito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ChxNuevo.Checked==true)
            {

                int contador2 = DgvCarrito.Rows.Count;
                if (contador2 == 0)
                    contadorAdd = 0;

                HabilitarProNew();

                TxtNombreProducto.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[0].Value).Trim();
                TxtDescripcion.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[1].Value).Trim();
                CmbCategoria.SelectedItem = Convert.ToString(DgvCarrito.CurrentRow.Cells[2].Value).Trim();
                CmbUnidadMedida.SelectedItem = Convert.ToString(DgvCarrito.CurrentRow.Cells[3].Value).Trim();
                TxtPrecioUnitario.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[4].Value).Trim();
                CmbEmpresa.SelectedItem = Convert.ToString(DgvCarrito.CurrentRow.Cells[5].Value).Trim();
                TxtTotalArt.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[6].Value).Trim();
                DtpFecha.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[7].Value).Trim();
                TxtNFactura.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[8].Value).Trim();
                TxtMarca.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[9].Value).Trim();
                TxtPrecioVenta.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[16].Value).Trim();
                DtpCaducidad.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[10].Value).Trim();

                double totalcompra = Convert.ToDouble(TxtTotalCompra.Text);
                double TotalArt = Convert.ToDouble(TxtTotalArt.Text);
                double precioU = Convert.ToDouble(TxtPrecioUnitario.Text);
                double TotalConp = (totalcompra - (TotalArt * precioU));
                TxtTotalCompra.Text = Convert.ToString(TotalConp);

                contador--;

                foreach (DataGridViewRow row in DgvCarrito.SelectedRows)
                {
                    DgvCarrito.Rows.RemoveAt(row.Index);
                }
            }
            else if (ChxExistente.Checked==true)
            {
                int contador2 = DgvCarrito.Rows.Count;
                if (contador2 == 0)
                    contadorAdd = 0;

                HabilitarProdExis();
                TxtNombreProducto.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[0].Value).Trim();
                TxtDescripcion.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[1].Value).Trim();
                TxtCategoria.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[2].Value).Trim();
                CmbUnidadMedida.SelectedItem = Convert.ToString(DgvCarrito.CurrentRow.Cells[3].Value).Trim();
                TxtPrecioUnitario.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[4].Value).Trim();
                CmbEmpresa.SelectedItem = Convert.ToString(DgvCarrito.CurrentRow.Cells[5].Value).Trim();
                TxtTotalArt.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[6].Value).Trim();
                DtpFecha.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[7].Value).Trim();
                TxtNFactura.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[8].Value).Trim();
                TxtMarca.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[9].Value).Trim();
                TxtPrecioVenta.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[16].Value).Trim();
                DtpCaducidad.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[10].Value).Trim();
                

                double totalcompra = Convert.ToDouble(TxtTotalCompra.Text);
                double TotalArt = Convert.ToDouble(TxtTotalArt.Text);
                double precioU = Convert.ToDouble(TxtPrecioUnitario.Text);
                double TotalConp = (totalcompra - (TotalArt * precioU));
                TxtTotalCompra.Text = Convert.ToString(TotalConp);

                contador--;
                foreach (DataGridViewRow row in DgvCarrito.SelectedRows)
                {
                    DgvCarrito.Rows.RemoveAt(row.Index);
                }

            }

            
            
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            ProductosE(TxtBuscar.Text);
        }

        //METODO PARA HABILITAR PRODUCTOS EXISTENTES
         void HabilitarProdExis()
        {
            Delete();

            TxtNombreProducto.Enabled = false;
            TxtDescripcion.Enabled = false;

            CmbCategoria.Visible = false;
            CmbCategoria.Enabled = false;

            TxtCategoria.Visible = true;

            //TxtCategoria.Top = 528;
            //TxtCategoria.Left = 71;

            TxtBuscar.Visible = true;
            BtnBuscar.Visible = true;
            DgvSave.Visible = true;

            CmbUnidadMedida.Enabled = true;
            TxtPrecioUnitario.Enabled = true;
            CmbEmpresa.Enabled = true;
            TxtTotalArt.Enabled = true;

            CLogicaObtenerFecha fc = new CLogicaObtenerFecha();
            string fecha = fc.ObtenerFechaSinHora();
            DtpFecha.MinDate = Convert.ToDateTime(fecha);

            DtpCaducidad.MinDate = Convert.ToDateTime(fecha);

            DtpCaducidad.Enabled = true;
            TxtNFactura.Enabled = true;
            TxtMarca.Enabled = true;
            TxtPrecioVenta.Enabled = true;

            DgvSave.Enabled = true;
            TxtBuscar.Enabled = true;
            BtnBuscar.Enabled = true;
            TxtUnidadMedida.Visible = true;
            TxtMarca.Enabled = false;
        }

        private void ChxExistente_CheckedChanged(object sender, EventArgs e)
        {
            int data = DgvCarrito.RowCount;
            if (data > 0)
            {
                DialogResult result = MessageBox.Show("¿Se eliminará lo que tienes en el carrito, estás seguro de hacerlo?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    DgvCarrito.Rows.Clear();
                    HabilitarProdExis();
                    contador = 0;
                    
                }
                else if (result == DialogResult.Cancel)
                {

                }
                else if (result == DialogResult.Cancel)
                {
                }
            }
            
            HabilitarProdExis();
        }

        private void DgvSave_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//Eliminamos la condicion momentaneamente
        {
            //if(TxtNombreProducto.Text =="" && TxtDescripcion.Text =="" && TxtCategoria.Text == "")
            //{
            TxtDescripcion.Text = Convert.ToString(DgvSave.CurrentRow.Cells[0].Value).Trim();
            TxtUnidadMedida.Text = Convert.ToString(DgvSave.CurrentRow.Cells[1].Value).Trim();

            TxtNombreProducto.Text = Convert.ToString(DgvSave.CurrentRow.Cells[3].Value).Trim();
            TxtMarca.Text = Convert.ToString(DgvSave.CurrentRow.Cells[4].Value).Trim();
            TxtCategoria.Text = Convert.ToString(DgvSave.CurrentRow.Cells[5].Value).Trim();
            //TxtDescripcion.Text = Convert.ToString(DgvSave.CurrentRow.Cells[1].Value).Trim();
                
            //}
            
        }

        private void PanelPrincipalCompra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        //METODO PARA LIMPIAR TODOS LOS CAMPOS
        void Delete()
        {
            TxtNombreProducto.Text = "";
            TxtDescripcion.Text = "";
            CmbCategoria.Text= "";
            CmbUnidadMedida.Text = "";
            TxtPrecioUnitario.Text = "";
            CmbEmpresa.Text = "";
            TxtTotalArt.Text = ""; 
            DtpFecha.Text = "";
            TxtNFactura.Text= "";
            TxtMarca.Text = "";
            TxtPrecioVenta.Text = "";
            TxtCategoria.Text = "";
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

            if (validation < 0)
                validation = 0;
            return validation;
        }
//***************************************************************************************************************************************************************************
        void CapturarCompra()
        {
            if (MetodoValidar() == 6)
            {
                if (ChxNuevo.Checked==true) {

                    string nomVolatil =  TxtNombreProducto.Text;
                   // nomVolatil.ToUpper();

                    string marcaVolatil = TxtMarca.Text;
                  //  marcaVolatil.ToUpper();

                    bool exis = false;
                    int contdata = DgvProductos.Rows.Count;
                    for (int i = 0; i < contdata; i++)
                    {
                        if (nombresProd[i].Trim().ToUpper() == nomVolatil.Trim().ToUpper() && marcaProd[i].Trim().ToUpper()==marcaVolatil.ToUpper())
                        {
                            MessageBox.Show("El producto que desea agregar ya existe :(.", "Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            exis = true;
                            break;
                        }
                       
                    }

                    if (exis==false) { 
                    int filas = 0 + contador;


                     DgvCarrito.Rows.Add();
                    //DgvSave.Rows.Add();

                     DgvCarrito.Rows[filas].Cells[0].Value = TxtNombreProducto.Text;
                         DgvCarrito.Rows[filas].Cells[1].Value = TxtDescripcion.Text;

                        idcategoria = Convert.ToInt32(CmbCategoria.SelectedValue.ToString());
                         IdEstante = sql.ConsultaSimple("SELECT Estanteria.IdEstante FROM Estanteria WHERE Estanteria.IdCategoria = '" + idcategoria + "'");
                        categoria = sql.ConsultaSimple("SELECT categoria.DescripcionC FROM Categoria WHERE IdCategoria = '" + idcategoria + "'");
                        DgvCarrito.Rows[filas].Cells[2].Value = categoria;

                        UnidadM = Convert.ToInt16(CmbUnidadMedida.SelectedValue.ToString());
                     unidadMedida = sql.ConsultaSimple("SELECT UnidadMedida.DescripcionTipoUM FROM UnidadMedida WHERE UnidadMedida.IdUnidadM = '" + UnidadM + "'");
                      DgvCarrito.Rows[filas].Cells[3].Value = unidadMedida.Trim();

                         DgvCarrito.Rows[filas].Cells[4].Value = TxtPrecioUnitario.Text;
                     PrecioU = Convert.ToDouble(TxtPrecioUnitario.Text);

                     IdProv = Convert.ToInt16(CmbEmpresa.SelectedValue.ToString());
                    proveedor = sql.ConsultaSimple("SELECT Proveedor.NombreEmpresa FROM Proveedor WHERE IdProveedor = '" + IdProv + "'");
                     DgvCarrito.Rows[filas].Cells[5].Value = proveedor;

                     DgvCarrito.Rows[filas].Cells[6].Value = TxtTotalArt.Text;
                    totalart = Convert.ToDouble(TxtTotalArt.Text);

                    DgvCarrito.Rows[filas].Cells[7].Value = DtpFecha.Value.ToString("yyy/MM/dd");
                     DgvCarrito.Rows[filas].Cells[8].Value = TxtNFactura.Text;
                    DgvCarrito.Rows[filas].Cells[9].Value = TxtMarca.Text;
                    DgvCarrito.Rows[filas].Cells[10].Value = DtpCaducidad.Value.ToString("yyy/MM/dd");
                    // totalCompra = (totalCompra + (Convert.ToDouble(TxtPrecioUnitario) * Convert.ToDouble(TxtTotalArt)));
                    //totalCompra = ((totalCompra) + ((totalart * PrecioU)));
                    //1) totalCompra = ((totalCompra) + ((totalart * PrecioU)));

                    double taux = Convert.ToDouble(TxtTotalCompra.Text);

                    totalCompra = (taux + (totalart * PrecioU));
                    TxtTotalCompra.Text = Convert.ToString(totalCompra);

                    TotalC = (totalart*PrecioU);

                //INFO ADICIONAL QUE IRÁ OCULTA EN EL DATAGRIDVIEW
                 DgvCarrito.Rows[filas].Cells[11].Value = IdProv;
                 DgvCarrito.Rows[filas].Cells[12].Value = UnidadM;
                 DgvCarrito.Rows[filas].Cells[13].Value = TotalC;
                    DgvCarrito.Rows[filas].Cells[14].Value = idcategoria;
                    DgvCarrito.Rows[filas].Cells[15].Value = id;
                    DgvCarrito.Rows[filas].Cells[16].Value = TxtPrecioVenta.Text;
                //**********************************

                //DgvSave.Rows[filas].Cells[0].Value = TxtNombreProducto.Text;
                //DgvSave.Rows[filas].Cells[1].Value = IdProv;
                //DgvSave.Rows[filas].Cells[2].Value = DtpFecha.Value.ToString("yyy/MM/dd");
                //DgvSave.Rows[filas].Cells[3].Value = TxtDescripcion.Text;
                //DgvSave.Rows[filas].Cells[4].Value = UnidadM;
                //DgvSave.Rows[filas].Cells[5].Value = TxtNFactura.Text;
                //DgvSave.Rows[filas].Cells[6].Value = TxtTotalCompra.Text;
                //DgvSave.Rows[filas].Cells[7].Value = idcategoria;
                //DgvSave.Rows[filas].Cells[8].Value = id;
                //DgvSave.Rows[filas].Cells[9].Value = TxtTotalArt.Text;
                //DgvSave.Rows[filas].Cells[10].Value = TxtPrecioUnitario.Text;
                //DgvSave.Rows[filas].Cells[11].Value = DtpCaducidad.Value.ToString("yyy/MM/dd");
                //DgvSave.Rows[filas].Cells[12].Value = TxtMarca.Text;
                //DgvSave.Rows[filas].Cells[13].Value = TxtPrecioVenta.Text;
                contador++;
                    }
                }

                else if (ChxExistente.Checked==true)
                {
                    int filas = 0 + contador;

                    DgvCarrito.Rows.Add();
                    //DgvSave.Rows.Add();

                    DgvCarrito.Rows[filas].Cells[0].Value = TxtNombreProducto.Text;
                    DgvCarrito.Rows[filas].Cells[1].Value = TxtDescripcion.Text;

                    idcategoria = Convert.ToInt32(sql.ConsultaSimple("SELECT IdCategoria FROM Categoria WHERE Categoria.DescripcionC = '"+TxtCategoria.Text.Trim()+"'"));
                    //IdEstante = sql.ConsultaSimple("SELECT Estanteria.IdEstante FROM Estanteria WHERE Estanteria.IdCategoria = '" + idcategoria + "'");
                    //categoria = sql.ConsultaSimple("SELECT categoria.DescripcionC FROM Categoria WHERE IdCategoria = '" + idcategoria + "'");
                    DgvCarrito.Rows[filas].Cells[2].Value = TxtCategoria.Text;

                    UnidadM = Convert.ToInt32(sql.ConsultaSimple("SELECT UnidadMedida.IdUnidadM FROM UnidadMedida WHERE UnidadMedida.DescripcionTipoUM ='" + TxtUnidadMedida.Text.Trim() + "'"));
                    DgvCarrito.Rows[filas].Cells[3].Value = TxtUnidadMedida.Text;

                    DgvCarrito.Rows[filas].Cells[4].Value = TxtPrecioUnitario.Text;
                    PrecioU = Convert.ToDouble(TxtPrecioUnitario.Text);

                    IdProv = Convert.ToInt16(CmbEmpresa.SelectedValue.ToString());
                    proveedor = sql.ConsultaSimple("SELECT Proveedor.NombreEmpresa FROM Proveedor WHERE IdProveedor = '" + IdProv + "'");
                    DgvCarrito.Rows[filas].Cells[5].Value = proveedor;

                    DgvCarrito.Rows[filas].Cells[6].Value = TxtTotalArt.Text;
                    totalart = Convert.ToDouble(TxtTotalArt.Text);

                    DgvCarrito.Rows[filas].Cells[7].Value = DtpFecha.Value.ToString("yyy/MM/dd");
                    DgvCarrito.Rows[filas].Cells[8].Value = TxtNFactura.Text;
                    DgvCarrito.Rows[filas].Cells[9].Value = TxtMarca.Text;
                    DgvCarrito.Rows[filas].Cells[10].Value = DtpCaducidad.Value.ToString("yyy/MM/dd");

                    
                    //1) totalCompra = ((totalCompra) + ((totalart * PrecioU)));
                    double taux = Convert.ToDouble(TxtTotalCompra.Text);

                    totalCompra = (taux + (totalart * PrecioU));
                    TxtTotalCompra.Text = Convert.ToString(totalCompra);
                    TotalC = (totalart * PrecioU);
                    //INFO ADICIONAL QUE IRÁ OCULTA EN EL DATAGRIDVIEW
                    DgvCarrito.Rows[filas].Cells[11].Value = IdProv;
                    DgvCarrito.Rows[filas].Cells[12].Value = UnidadM;
                    DgvCarrito.Rows[filas].Cells[13].Value = TotalC;
                    DgvCarrito.Rows[filas].Cells[14].Value = idcategoria;
                    DgvCarrito.Rows[filas].Cells[15].Value = id;
                    DgvCarrito.Rows[filas].Cells[16].Value = TxtPrecioVenta.Text;
                    //**********************************

                    contador++;
                }
            }
            else
            {
                MessageBox.Show("Uno o mas campos están vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if(ChxNuevo.Checked==true || ChxExistente.Checked == true) {
                contadorAdd = 0;
                DgvCarrito.Rows.Clear();
                TxtTotalCompra.Text = "0";
                contador = 0;
                Delete();
            }
        }

        void Save()
        {
          //  CapturarCompra();
            int contador = DgvCarrito.Rows.Count;
            MessageBox.Show("numeros de productos = " + Convert.ToString(contador));
            string res = "";
            for (int i = 0; i < contador; i++)
            {
                string nom = Convert.ToString(DgvCarrito.Rows[i].Cells[0].Value).Trim();
                int idProv = Convert.ToInt32(DgvCarrito.Rows[i].Cells[11].Value);
                string fechaI = Convert.ToString(DgvCarrito.Rows[i].Cells[7].Value).Trim();
                string descrip = Convert.ToString(DgvCarrito.Rows[i].Cells[1].Value).Trim();
                int IdUnm = Convert.ToInt32(DgvCarrito.Rows[i].Cells[12].Value);
                int Nf = Convert.ToInt32(DgvCarrito.Rows[i].Cells[8].Value);
                double TC = Convert.ToDouble(DgvCarrito.Rows[i].Cells[13].Value);
                int IdC = Convert.ToInt32(DgvCarrito.Rows[i].Cells[14].Value);
                int IdU = Convert.ToInt32(DgvCarrito.Rows[i].Cells[15].Value);
                double TA = Convert.ToDouble(DgvCarrito.Rows[i].Cells[6].Value);
                double PU = Convert.ToDouble(DgvCarrito.Rows[i].Cells[4].Value);
                string FechaC = Convert.ToString(DgvCarrito.Rows[i].Cells[10].Value);
                string mark = Convert.ToString(DgvCarrito.Rows[i].Cells[9].Value).Trim();
                double PV = Convert.ToDouble(DgvCarrito.Rows[i].Cells[16].Value);

                res = buy.AddCompra(nom, idProv, fechaI, descrip, IdUnm, Nf, TC, IdC, IdU, TA, PU, FechaC, mark, PV);
               
            }
            if (res.Trim() == Convert.ToString(0))
            {
                MessageBox.Show("Lo sentimos. La compra no se pudo realizar. :(");
                
            }
            else
            {
                if (res.Trim() != Convert.ToString(0))
                {
                    MessageBox.Show("La compra se agregó con éxito. :)");
                    
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int conteorows = DgvCarrito.Rows.Count;
            if (conteorows>0)
            {
                DialogResult result = MessageBox.Show("¿Es todo lo qué desea añadir al carrito?", "Avíso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               
                if (result == DialogResult.OK)
                {
                    Save();
                    Delete();
                    //DgvCarrito.DataSource = "";
                    //TxtTotalCompra.Text = "";
                    //contadorAdd = 0;
                    //contador = 0;
                    if (ChxNuevo.Checked == true || ChxExistente.Checked == true)
                    {
                        contadorAdd = 0;
                        DgvCarrito.Rows.Clear();
                        TxtTotalCompra.Text = "0";
                        contador = 0;
                        Delete();
                    }

                }
                else if (result == DialogResult.Cancel)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Antes de guardar añada productos al carrito. :)", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {

            contadorAdd++;
            CapturarCompra();

            int aux = DgvCarrito.ColumnCount;
            if (aux == 0)
                contador = 0;
            Delete();
        }

    }
}
