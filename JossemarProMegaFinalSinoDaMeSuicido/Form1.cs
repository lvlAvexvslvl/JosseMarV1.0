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
        CLogicaObtenerFecha fcz = new CLogicaObtenerFecha();


        public double interes;
        public double MontoInt;
        public double Subtotal;
        public double TotalConIva;
        public string fecha;
        public int factura;

        int contador = 0, contadorAdd = 0;
        string id, IdProducto;
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
                Validaciones.SoloNumerosPuntosyComas(e);
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "4")
            {
                Validaciones.SoloNumerosPuntosyComas(e);
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "5")
            {
                Validaciones.SoloNumeros(e);
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "6")
            {
                Validaciones.SoloNumerosPuntosyComas(e);
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "7")
            {
                Validaciones.SoloNumerosPuntosyComas(e);
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

        
        void ProductosE(string a)
        {

            DgvSave.DataSource = sql.ConsultaTab("SELECT vs_ProductosExistentes.Descripcion, vs_ProductosExistentes.DescripcionTipoUM,vs_ProductosExistentes.NombreProducto AS Nombre, vs_ProductosExistentes.Marca AS Marca,vs_ProductosExistentes.DescripcionC AS Categoria FROM vs_ProductosExistentes WHERE vs_ProductosExistentes.NombreProducto LIKE '%"+a+"%' OR vs_ProductosExistentes.Marca LIKE '%"+a+"%' GROUP BY  vs_ProductosExistentes.Descripcion, vs_ProductosExistentes.DescripcionTipoUM, vs_ProductosExistentes.NombreProducto, vs_ProductosExistentes.Marca,vs_ProductosExistentes.DescripcionC");

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

            DgvEditProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvEditProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ProductosE("");
            EditsProd("");
            int con = DgvSave.RowCount;
            //MessageBox.Show("con= "+con);
            //ProductosE2();

            this.DgvSave.Columns["Descripcion"].Visible = false;
            this.DgvSave.Columns["DescripcionTipoUM"].Visible = false;

            cmbCategorias();
            cmbProveedores();
            cmbUnidadMedida();
            DgvNomProducts();
            DgvNomProducts2();
            int Nomp = DgvProductos.Rows.Count;
            int marca22 = DgvMarca.Rows.Count;
            //MessageBox.Show(" " + Nomp);
           // MessageBox.Show(" " + marca22);
            nombresProd = new string[Nomp];
            marcaProd = new string[Nomp];
            for (int i = 0; i < Nomp; i++)
            {
                nombresProd[i] = Convert.ToString(DgvProductos.Rows[i].Cells[0].Value).Trim();
                marcaProd[i] = Convert.ToString(DgvMarca.Rows[i].Cells[0].Value).Trim(); ;
            }

            //MessageBox.Show(CmbUnidadMedida.SelectedValue.ToString()); /*retorna uno*/

            DtpFecha.Enabled = false;
            DtpCaducidad.Enabled = false;
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

        void ActivarFormarDate()
        {

            DtpCaducidad.MaxDate = DateTime.Today.AddDays(999999);
            DtpCaducidad.MinDate = DateTime.Now.AddDays(1);

            DtpFecha.MaxDate = DateTime.Today;
            DtpFecha.MinDate = DateTime.Today.AddDays(-5);
        }

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
            DtpFecha.Enabled = true;
            DtpCaducidad.Enabled = true;
            TxtNFactura.Enabled = true;
            TxtMarca.Enabled = true;
            TxtPrecioVenta.Enabled = true;
            TxtUnidadMedida.Visible = false;
            ActivarFormarDate();
        }
        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (CmbCategoria.SelectedValue.ToString()=="6")
            {
                DtpFecha.Enabled = false;
                DtpCaducidad.Enabled = false;
            }
            else
            {
                DtpFecha.Enabled = true;
                DtpCaducidad.Enabled = true;
            }

            int data = DgvCarrito.RowCount;
            if (data > 0) { 
            DialogResult result = MessageBox.Show("¿Se eliminará lo que tienes en el carrito, estás seguro de hacerlo?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                    DgvCarrito.Rows.Clear();
                    HabilitarProNew();
                    TxtNFactura.Text = "";
                    if (CmbCategoria.SelectedValue.ToString() == "6")
                    {
                        DtpFecha.Enabled = false;
                        DtpCaducidad.Enabled = false;
                    }
                    else
                    {
                        DtpFecha.Enabled = true;
                        DtpCaducidad.Enabled = true;
                    }
                    contador = 0;
                    TxtTotalCompra.Text = "0";
                }
            else if (result == DialogResult.Cancel)
            {
                    if (CmbCategoria.SelectedValue.ToString() == "6")
                    {
                        DtpFecha.Enabled = false;
                        DtpCaducidad.Enabled = false;

                        
                    }
                    else
                    {
                        DtpFecha.Enabled = true;
                        DtpCaducidad.Enabled = true;
                    }
                }
            
            }
            HabilitarProNew();
            if (CmbCategoria.SelectedValue.ToString() == "6")
            {
                DtpFecha.Enabled = false;
                DtpCaducidad.Enabled = false;
               
            }
            else
            {
                DtpFecha.Enabled = true;
                DtpCaducidad.Enabled = true;
            }
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
               // DtpFecha.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[7].Value).Trim();
                TxtNFactura.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[8].Value).Trim();
                TxtMarca.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[9].Value).Trim();
                TxtPrecioVenta.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[16].Value).Trim();
                //DtpCaducidad.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[10].Value).Trim();

                CmbCategoria.SelectedValue = DgvCarrito.Rows[e.RowIndex].Cells[14].Value.ToString();
                CmbEmpresa.SelectedValue = DgvCarrito.Rows[e.RowIndex].Cells[11].Value.ToString();
                CmbUnidadMedida.SelectedValue = DgvCarrito.Rows[e.RowIndex].Cells[12].Value.ToString();

                DtpFecha.Value = Convert.ToDateTime(DgvCarrito.Rows[e.RowIndex].Cells[7].Value);
                
                if (CmbCategoria.SelectedValue.ToString() == "6")
                {
                    DtpCaducidad.Enabled = false;
                    DtpFecha.Enabled = true;
                }
                else
                {
                    DtpCaducidad.Enabled = true;
                    try
                    {
                        DtpCaducidad.Value = Convert.ToDateTime(DgvCarrito.Rows[e.RowIndex].Cells[10].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                      // MessageBox.Show("Ha ocurrido un error con la fecha a editar, intentarlo nuevamente.", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    

                }
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
               // DtpFecha.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[7].Value).Trim();
                TxtNFactura.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[8].Value).Trim();
                TxtMarca.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[9].Value).Trim();
                TxtPrecioVenta.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[16].Value).Trim();
               TxtUnidadMedida.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[3].Value).Trim();
                //DtpCaducidad.Text = Convert.ToString(DgvCarrito.CurrentRow.Cells[10].Value).Trim();
                try
                {
                    DtpFecha.Value = Convert.ToDateTime(DgvCarrito.Rows[e.RowIndex].Cells[7].Value);
                }
                catch (Exception)
                {

                   
                }
                try
                {
                    DtpCaducidad.Value = Convert.ToDateTime(DgvCarrito.Rows[e.RowIndex].Cells[10].Value.ToString());
                }
                catch (Exception ex)
                {
                    // MessageBox.Show("Ha ocurrido un error con la fecha a editar, intentarlo nuevamente.", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

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

            CmbUnidadMedida.Visible = false;
            CmbUnidadMedida.Enabled = false;

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
            //DtpFecha.MinDate = Convert.ToDateTime(fecha);

            //DtpCaducidad.MinDate = Convert.ToDateTime(fecha);

            DtpCaducidad.Enabled = true;
            DtpFecha.Enabled = true;

            TxtNFactura.Enabled = true;
            TxtMarca.Enabled = true;
            TxtPrecioVenta.Enabled = true;

            DgvSave.Enabled = true;
            TxtBuscar.Enabled = true;
            BtnBuscar.Enabled = true;
            TxtUnidadMedida.Visible = true;
            TxtMarca.Enabled = false;

            ActivarFormarDate();
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
                    TxtTotalCompra.Text = "0";
                    TxtNFactura.Text = "";

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

            TxtNombreProducto.Text = Convert.ToString(DgvSave.CurrentRow.Cells[2].Value).Trim();
            TxtMarca.Text = Convert.ToString(DgvSave.CurrentRow.Cells[3].Value).Trim();
            TxtCategoria.Text = Convert.ToString(DgvSave.CurrentRow.Cells[4].Value).Trim();

            if (TxtCategoria.Text == "Repuesto")
            {
                DtpCaducidad.Enabled = false;
                DtpFecha.Enabled = false;
            }
            else
            {
                DtpCaducidad.Enabled = true;
                DtpFecha.Enabled = true;
            }
            
        }

        private void PanelPrincipalCompra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtTotalArt_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Delete();
            TxtNFactura.Text = "";
        }

        private void ChxEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChxEditar.Checked == true)
            {
                ChxNuevo.Checked = false;
                ChxExistente.Checked = false;

                ChxNuevo.Enabled = false;
                ChxExistente.Enabled = false;
                HabilitarProNew();

                DtpCaducidad.MaxDate = DateTime.Today.AddDays(999999);
                DtpCaducidad.MinDate = DateTime.Now.AddDays(-999);

                DtpFecha.MaxDate = DateTime.Today.AddDays(999999);
                DtpFecha.MinDate = DateTime.Now.AddDays(-999);

                if (CmbCategoria.SelectedValue.ToString() == "6")
                {
                    DtpFecha.Enabled = false;
                    DtpCaducidad.Enabled = false;
                }
                else
                {
                    DtpFecha.Enabled = true;
                    DtpCaducidad.Enabled = true;
                }

            }
            else
            {
                ActivarFormarDate();
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

                ChxNuevo.Enabled = true;
                ChxExistente.Enabled = true;
            }
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
            //TxtNFactura.Text= "";
            TxtMarca.Text = "";
            TxtPrecioVenta.Text = "";
            TxtCategoria.Text = "";
            TxtUnidadMedida.Text = "";
        }

        void CapturarDatEditar()
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
                    double taux = Convert.ToDouble(TxtTotalCompra.Text);
                    double totalCompra = (taux + (totalart * PrecioU));
                    TxtTotalCompra.Text = Convert.ToString(totalCompra);
                    double TotalC = (Stock * PrecioU);
                    int idprod = Convert.ToInt32(IdProducto);
                    int idU = Convert.ToInt16(id);

                    buy.EditCompra(idprod, nom, IdProv, fechaI, des, UnidadM, NF, TotalC, idcategoria, idU, Stock, PrecioU, FCadu,
                        marca, PrecioV);

                    MessageBox.Show("Producto editado con éxito :)", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(ChxEditar.Checked == true)
            CapturarDatEditar();

            EditsProd("");
            Delete();

            
        }

        private void CmbUnidadMedida_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbUnidadMedida.SelectedValue.ToString() == "1")
            {
                TxtTotalArt.Text = "";
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "2")
            {
                TxtTotalArt.Text = "";
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "3")
            {
                TxtTotalArt.Text = "";
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "4")
            {
                TxtTotalArt.Text = "";
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "5")
            {
                TxtTotalArt.Text = "";
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "6")
            {
                TxtTotalArt.Text = "";
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "7")
            {
                TxtTotalArt.Text = "";
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "8")
            {
                TxtTotalArt.Text = "";
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "9")
            {
                TxtTotalArt.Text = "";
            }
            else if (CmbUnidadMedida.SelectedValue.ToString() == "10")
            {
                TxtTotalArt.Text = "";
            }
        }

        private void CmbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbCategoria.SelectedValue.ToString() == "6")
            {
                DtpCaducidad.Enabled = false;
                DtpFecha.Enabled = false;
                CmbUnidadMedida.Enabled = false;
                CmbUnidadMedida.SelectedValue = 1;
            }
            else
            {
                DtpCaducidad.Enabled = true;
                DtpFecha.Enabled = true;
                CmbUnidadMedida.Enabled = true;
            }

        }

        private void TxtBuscarCompras_TextChanged(object sender, EventArgs e)
        {
            EditsProd(TxtBuscarCompras.Text);
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2RadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        private void TxtInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
    if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnEditar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChxEditarnfact_CheckedChanged(object sender, EventArgs e)
        {
            int a = DgvCarrito.RowCount;
            if (a > 0)
            {
                if (ChxEditarnfact.Checked == true)
                {

                    DialogResult result = MessageBox.Show("¿Deseas editar el numero de factura?", "Avíso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        TxtNFactura.Enabled = true;
                       // DgvCarrito.Rows.Clear();
                        Delete();
                        TxtNFactura.Text = "";

                    }
                    else if (result == DialogResult.Cancel)
                    {

                    }
                }
                else
                {
                    TxtNFactura.Enabled = false;
                }
            }
            
            
        }

        private void DgvEditProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                DtpFecha.Value = Convert.ToDateTime(DgvEditProducts.Rows[e.RowIndex].Cells[7].Value);

                if (CmbCategoria.SelectedValue.ToString() == "6")
                {
                    DtpCaducidad.Enabled = false;
                    DtpFecha.Enabled = true;
                }
                else
                {
                    DtpCaducidad.Enabled = true;
                    DtpCaducidad.Value = Convert.ToDateTime(DgvEditProducts.Rows[e.RowIndex].Cells[10].Value);
                    
                }
            }
           
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

        private void RbnCredito_CheckedChanged(object sender, EventArgs e)
        {
            LblInteres.Visible = true;
            TxtInteres.Visible = true;
            LblInteres22.Visible = true;
            LblSubtotal.Visible = true;
            LblTotalPagar.Visible = true;
            TxtMontoInteres.Visible = true;
            TxtSubTotal.Visible = true;
            TxtTotalConIVA.Visible = true;
            LblFechaFinalPago.Visible = true;
            DtpFechaFinalPago.Visible = true;
        }

        private void RbnContado_CheckedChanged(object sender, EventArgs e)
        {
            LblInteres.Visible = false;
            TxtInteres.Visible = false;
            LblInteres22.Visible = false;
            LblSubtotal.Visible = false;
            LblTotalPagar.Visible = false;
            TxtMontoInteres.Visible = false;
            TxtSubTotal.Visible = false;
            TxtTotalConIVA.Visible = false;
            LblFechaFinalPago.Visible = false;
            DtpFechaFinalPago.Visible = false;
        }

        //***************************************************************************************************************************************************************************
        void CapturarCompra()
        {
            if (MetodoValidar() == 7)
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

        void CapturarParteCreditoCompra()
        {
            if (RbnCredito.Checked == true)
            {
                string mensaje;
                CLogicaCompraCreditoo AddCreditoCompra = new CLogicaCompraCreditoo();
                mensaje = AddCreditoCompra.LogicaAddCompraCredito(interes, MontoInt, fecha, TotalConIva, TotalConIva);
                fecha = TxtNFactura.Text;

            }

        }
        public void EnviarDatos()
        {
            FormCompraCredito PasarDatos = new FormCompraCredito();

            PasarDatos.TxtNFactura.Text = TxtNFactura.Text;
            PasarDatos.TxtMontoTotal.Text = TxtTotalConIVA.Text;
            PasarDatos.Show();

        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if(ChxNuevo.Checked==true || ChxExistente.Checked == true) {
                contadorAdd = 0;
                DgvCarrito.Rows.Clear();
                TxtTotalCompra.Text = "0";
                contador = 0;
                Delete();
                TxtNFactura.Text = "";
                TxtNFactura.Enabled = true;
            }
        }

        void Save()
        {
          //  CapturarCompra();
            int contador = DgvCarrito.Rows.Count;
            //MessageBox.Show("numeros de productos = " + Convert.ToString(contador));
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
            if (RbnCredito.Checked == true)
            {
                CapturarParteCreditoCompra();
                EnviarDatos();
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
                    Movimiento();
                    Save();
                    Delete();
                    ProductosE("");
                   
                    EditsProd("");
                    TxtNFactura.Text = "";
                    if (ChxNuevo.Checked == true || ChxExistente.Checked == true)
                    {
                        contadorAdd = 0;
                        DgvCarrito.Rows.Clear();
                        TxtTotalCompra.Text = "0";
                        contador = 0;
                        Delete();
                        TxtNFactura.Text = "";
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
        private void Movimiento()
        {
            CLogicaMovimientos lg = new CLogicaMovimientos();
            string note = sql.ConsultaSimple("SELECT MAX(Compra.IdCompra)FROM Compra");
            lg.MovimientoCompras(note,TxtTotalCompra.Text.Trim());
            lg.SaldoD(TxtTotalCompra.Text.Trim(), 1);
        }
        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            double precioU = 0, precioV=0;
            if(TxtPrecioUnitario.Text!= "" && TxtPrecioVenta.Text != "")
            {
                precioU = Convert.ToDouble(TxtPrecioUnitario.Text);
                precioV = Convert.ToDouble(TxtPrecioVenta.Text);
            }
            if (precioU > precioV)
            {
                DialogResult result = MessageBox.Show("El precio de compra es menor al de venta, desea añairlo de todos modos?", "Avíso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    contadorAdd++;
                    CapturarCompra();
                    int a = DgvCarrito.RowCount;
                    if (a > 0)
                    {
                        TxtNFactura.Enabled = false;
                    }

                    int aux = DgvCarrito.ColumnCount;
                    if (aux == 0)
                        contador = 0;
                    Delete();
                }
                else if (result == DialogResult.Cancel)
                {

                }
            }
            else 
            {
                contadorAdd++;
                CapturarCompra();
                int a = DgvCarrito.RowCount;
                if (a > 0)
                {
                    TxtNFactura.Enabled = false;
                }

                int aux = DgvCarrito.ColumnCount;
                if (aux == 0)
                    contador = 0;
                Delete();
            }

            if (RbnCredito.Checked == true)
            {
                interes = Convert.ToDouble(TxtInteres.Text) / 100;
                MontoInt = Convert.ToDouble(TxtTotalCompra.Text) * interes;
                Subtotal = MontoInt + Convert.ToDouble(TxtTotalCompra.Text);
                TotalConIva = Subtotal;
                fecha = DtpFechaFinalPago.Value.ToString("yyy/MM/dd");

                TxtMontoInteres.Text = Convert.ToString(MontoInt);
                TxtSubTotal.Text = Convert.ToString(Subtotal);
                TxtTotalConIVA.Text = Convert.ToString(TotalConIva);
            }



        }

        void EditsProd(string a)
        {
            DgvEditProducts.DataSource = sql.ConsultaTab("SELECT vs_EditarCompra.NombreProducto AS Producto, vs_EditarCompra.Descripcion as Descripcion, vs_EditarCompra.DescripcionC AS Categoría, vs_EditarCompra.DescripcionTipoUM as UMedida, vs_EditarCompra.PrecioUnitario AS PrecioU, vs_EditarCompra.NombreEmpresa AS Proveedor, vs_EditarCompra.Stock  AS Cantidad, vs_EditarCompra.FechaIngreso AS Ingreso,vs_EditarCompra.NumeroFactura AS NFactura, vs_EditarCompra.Marca as Marca, vs_EditarCompra.FechaCaducidad as Caducidad, vs_EditarCompra.IdProveedor as IdProv, vs_EditarCompra.IdUnidadMedida as IDUM,vs_EditarCompra.TotalCompra as TC, vs_EditarCompra.IdCategoria as IDC, vs_EditarCompra.IdUsuario as IDU, vs_EditarCompra.PrecioVenta as PVenta,vs_EditarCompra.IdCompra as ID FROM vs_EditarCompra WHERE vs_EditarCompra.NombreProducto LIKE'%"+a+"%' OR vs_EditarCompra.Marca LIKE'%"+a+"%' OR vs_EditarCompra.DescripcionC LIKE '%"+a+"%'");
        }

    }
}
