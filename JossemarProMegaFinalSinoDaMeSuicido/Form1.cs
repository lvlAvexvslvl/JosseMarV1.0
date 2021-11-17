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
        int contador = 0;
        string id;
        double totalCompra=0, totalCompra2;
        int idcategoria, UnidadM, IdProv;
        string categoria, unidadMedida, proveedor, IdEstante;
        double PrecioU, totalart;

        private void TxtCajas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);

        }

        private void TxtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void TxtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosPuntosyComas(e);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            LblIdUsuario.Text = id;
            DgvCarrito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgvSave.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvSave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cmbCategorias();
            cmbProveedores();
            cmbUnidadMedida();
           // MessageBox.Show(CmbCategoria.SelectedItem.ToString());
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void TxtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosPuntosyComas(e);
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
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
        }

        private void TxtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosPuntosyComas(e);
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

        //METODO PARA PASAR LOS DATOS A LOS CAMPOS DEL DATAGRID CARRITO
        //void CapturarCompra()
        //{
        //    if (MetodoValidar() == 6)
        //    {
        //        int filas = 0 + contador;
        //        contador++;

        //        DgvCarrito.Rows.Add();

        //        DgvCarrito.Rows[filas].Cells[0].Value = TxtNombreProducto.Text;
        //        DgvCarrito.Rows[filas].Cells[1].Value = TxtDescripcion.Text;

        //        int idcategoria = Convert.ToInt32(CmbCategoria.SelectedValue.ToString());
        //        string categoria = sql.ConsultaSimple("SELECT categoria.DescripcionC FROM Categoria WHERE IdCategoria = '"+idcategoria+"'");
        //        DgvCarrito.Rows[filas].Cells[2].Value = categoria;

        //        int UnidadM = Convert.ToInt16(CmbUnidadMedida.SelectedValue.ToString());
        //        string unidadMedida = sql.ConsultaSimple("SELECT UnidadMedida.DescripcionTipoUM FROM UnidadMedida WHERE UnidadMedida.IdUnidadM = '"+UnidadM+"'");
        //        DgvCarrito.Rows[filas].Cells[3].Value = unidadMedida.Trim();

        //        DgvCarrito.Rows[filas].Cells[4].Value = TxtPrecioUnitario.Text;
        //        double PrecioU = Convert.ToDouble(TxtPrecioUnitario.Text);

        //        int IdProv = Convert.ToInt16(CmbEmpresa.SelectedValue.ToString());
        //        string proveedor = sql.ConsultaSimple("SELECT Proveedor.NombreEmpresa FROM Proveedor WHERE IdProveedor = '"+IdProv+"'");
        //        DgvCarrito.Rows[filas].Cells[5].Value = proveedor;

        //        DgvCarrito.Rows[filas].Cells[6].Value = TxtTotalArt.Text;
        //        int totalart = Convert.ToInt32(TxtTotalArt.Text);

        //        DgvCarrito.Rows[filas].Cells[7].Value = DtpFecha.Value.ToString("yyy/MM/dd"); 
        //        DgvCarrito.Rows[filas].Cells[8].Value = TxtNFactura.Text;
        //        DgvCarrito.Rows[filas].Cells[9].Value = TxtMarca.Text;
        //        DgvCarrito.Rows[filas].Cells[10].Value = DtpCaducidad.Value.ToString("yyy/MM/dd");
        //        // totalCompra = (totalCompra + (Convert.ToDouble(TxtPrecioUnitario)* Convert.ToDouble(TxtTotalArt)));
        //        totalCompra = ((totalCompra) + ((totalart * PrecioU)));
        //        TxtTotalCompra.Text = Convert.ToString(totalCompra);

        //    }
        //    else
        //    {
        //        MessageBox.Show("Uno o mas campos están vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}
        //*******************************************************************************************************************************
        void CapturarCompra()
        {
            if (MetodoValidar() == 6)
            {
                int filas = 0 + contador;


                DgvCarrito.Rows.Add();

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
                totalart = Convert.ToInt32(TxtTotalArt.Text);

                DgvCarrito.Rows[filas].Cells[7].Value = DtpFecha.Value.ToString("yyy/MM/dd");
                DgvCarrito.Rows[filas].Cells[8].Value = TxtNFactura.Text;
                DgvCarrito.Rows[filas].Cells[9].Value = TxtMarca.Text;
                DgvCarrito.Rows[filas].Cells[10].Value = DtpCaducidad.Value.ToString("yyy/MM/dd");
               // totalCompra = (totalCompra + (Convert.ToDouble(TxtPrecioUnitario) * Convert.ToDouble(TxtTotalArt)));
                totalCompra = ((totalCompra) + ((totalart * PrecioU)));
                TxtTotalCompra.Text = Convert.ToString(totalCompra);

                
                //**********************************
                DgvSave.Rows.Add();

                DgvSave.Rows[filas].Cells[0].Value = TxtNombreProducto.Text;
                DgvSave.Rows[filas].Cells[1].Value = IdProv;
                DgvSave.Rows[filas].Cells[2].Value = DtpFecha.Value.ToString("yyy/MM/dd");
                DgvSave.Rows[filas].Cells[3].Value = TxtDescripcion.Text;
                DgvSave.Rows[filas].Cells[4].Value = UnidadM;
                DgvSave.Rows[filas].Cells[5].Value = TxtNFactura.Text;
                DgvSave.Rows[filas].Cells[6].Value = TxtTotalCompra.Text;
                DgvSave.Rows[filas].Cells[7].Value = idcategoria;
                DgvSave.Rows[filas].Cells[8].Value = id;
                DgvSave.Rows[filas].Cells[9].Value = TxtTotalArt.Text;
                DgvSave.Rows[filas].Cells[10].Value = TxtPrecioUnitario.Text;
                DgvSave.Rows[filas].Cells[11].Value = DtpCaducidad.Value.ToString("yyy/MM/dd");
                DgvSave.Rows[filas].Cells[12].Value = TxtMarca.Text;
                DgvSave.Rows[filas].Cells[13].Value = TxtPrecioVenta.Text;

                contador++;
                MessageBox.Show("Filas:" + filas);
                MessageBox.Show("Contador:" + contador);
            }
            else
            {
                MessageBox.Show("Uno o mas campos están vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //void CapturarCompra()
        //{
        //    if (MetodoValidar() == 6)
        //    {
        //        int filas = 0 + contador;



        //    }
        //}



        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if(ChxNuevo.Checked==true || ChxExistente.Checked == true) { 
                DgvCarrito.DataSource = "";
                TxtTotalCompra.Text = "";
                Delete();
            }
        }

        void Save()
        {
          //  CapturarCompra();
            int contador = DgvSave.Rows.Count;
            MessageBox.Show("numeros de productos = " + Convert.ToString(contador));
            string res = "";
            for (int i = 0; i < contador; i++)
            {
                string nom = Convert.ToString(DgvSave.Rows[i].Cells[0].Value).Trim();
                int idProv = Convert.ToInt32(DgvSave.Rows[i].Cells[1].Value);
                string fechaI = Convert.ToString(DgvSave.Rows[i].Cells[2].Value).Trim();
                string descrip = Convert.ToString(DgvSave.Rows[i].Cells[3].Value).Trim();
                int IdUnm = Convert.ToInt32(DgvSave.Rows[i].Cells[4].Value);
                int Nf = Convert.ToInt32(DgvSave.Rows[i].Cells[5].Value);
                double TC = Convert.ToDouble(DgvSave.Rows[i].Cells[6].Value);
                int IdC = Convert.ToInt32(DgvSave.Rows[i].Cells[7].Value);
                int IdU = Convert.ToInt32(DgvSave.Rows[i].Cells[8].Value);
                double TA = Convert.ToDouble(DgvSave.Rows[i].Cells[9].Value);
                double PU = Convert.ToDouble(DgvSave.Rows[i].Cells[10].Value);
                string FechaC = Convert.ToString(DgvSave.Rows[i].Cells[11].Value);
                string mark = Convert.ToString(DgvSave.Rows[i].Cells[12].Value).Trim();
                double PV = Convert.ToDouble(DgvSave.Rows[i].Cells[13].Value);

                res = buy.AddCompra(nom, idProv, fechaI, descrip, IdUnm, Nf, TC, IdC, IdU, TA, PU, FechaC, mark, PV);
                MessageBox.Show("i"+i);
                //buy.AddCompra(Convert.ToString(DgvSave.Rows[i].Cells[0].Value).Trim(), Convert.ToInt32(DgvSave.Rows[i].Cells[1].Value), Convert.ToString(DgvSave.Rows[i].Cells[2].Value).Trim(), Convert.ToString(DgvSave.Rows[i].Cells[3].Value).Trim(), Convert.ToInt32(DgvSave.Rows[i].Cells[4].Value), Convert.ToInt32(DgvSave.Rows[i].Cells[5].Value), Convert.ToDouble(DgvSave.Rows[i].Cells[6].Value), Convert.ToInt32(DgvSave.Rows[i].Cells[7].Value), Convert.ToInt32(DgvSave.Rows[i].Cells[8].Value), Convert.ToDouble(DgvSave.Rows[i].Cells[9].Value), Convert.ToDouble(DgvSave.Rows[i].Cells[10].Value), Convert.ToString(DgvSave.Rows[i].Cells[11].Value).Trim(), Convert.ToString(DgvSave.Rows[i].Cells[12].Value).Trim(),Convert.ToDouble(DgvSave.Rows[i].Cells[13].Value));
                //string Idbuy = sql.ConsultaSimple("SELECT MAX(dbo.Compra.IdCompra) FROM Compra");
                //MessageBox.Show("a" + Idbuy);
                //MessageBox.Show("Estante" + IdEstante);
                //MessageBox.Show("total" + totalart);
                //buy.AddProducto(Idbuy, IdEstante, totalart);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            CapturarCompra();
            Delete();
        }

    }
}
