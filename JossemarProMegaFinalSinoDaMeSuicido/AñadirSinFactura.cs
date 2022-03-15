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
    public partial class AñadirSinFactura : Form
    {
        CLogicaConsultas sql = new CLogicaConsultas();


        int contador = 0;
        int contador2 = 0;
        int id = 0;
        int sumando = 0;
        double stockFinal;


        public AñadirSinFactura()
        {
            InitializeComponent();

        }


        //------------------ VERIFICA LOS DATOS COMPLETOS ------------------

        Boolean validarTextbox()
        {
            //Codigo para validar la entrada de texto

            if (TxtNombreProducto.Text != "" && TxtDescripcion.Text != "" && TxtExistencias.Text != "" && TxtMarca.Text != "" && TxtPrecioVenta.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

            /*else if (RbtExistente.Checked==true)
            {
                RbtNuevo.Checked = false;
                return true;
            }
            else if (RbtNuevo.Checked == true)
            {
                RbtExistente.Checked = false;
                return true;
            }
            else
            {
                MessageBox.Show("Porfavor seleccione Nuevo o Existente antes de guardar");
            }
            */

        }
        //------------------ AGREGA INFO A  LOS COMBOBOX ------------------
        void cmbCategoria()
        {
            CLogicaLlenarCmb x = new CLogicaLlenarCmb();
            CmbCategoria.DataSource = x.cmbCategoria2();
            //Es para ver el dato en el combobox
            CmbCategoria.DisplayMember = "Categoria";
            //Para buscar por parametro
            CmbCategoria.ValueMember = "ID";
        }

        void cmbUnidadMedida()
        {
            CLogicaLlenarCmb x = new CLogicaLlenarCmb();
            CmbUnidadMedida.DataSource = x.cmbUnidadM2();
            //Es para ver el dato en el combobox
            CmbUnidadMedida.DisplayMember = "Medida";
            //Para buscar por parametro
            CmbUnidadMedida.ValueMember = "ID";
        }

        void cmbEstantes()
        {
            CLogicaLlenarCmb x = new CLogicaLlenarCmb();
            CmbEstante.DataSource = x.cmbEstantes2();
            //Es para ver el dato en el combobox
            CmbEstante.DisplayMember = "Estante";
            //Para buscar por parametro
            CmbEstante.ValueMember = "ID";
        }

        //------------------ LLENA LOS DATAGREEDVIEW ------------------
        void CapturarProductoSinFactura(string a)
        {
            DgvInventario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CLogicaConsultas consult = new CLogicaConsultas();
            DgvInventario.DataSource = consult.ConsultaTab("SELECT * FROM vs_ProductoSinFactura where Marca LIKE'%" + a + "%'");

            DgvInventario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ///DgvInventario.Columns[2].Width = 130;
            DgvInventario.Columns[10].Visible = false;
            DgvInventario.Columns[11].Visible = false;
            DgvInventario.Columns[12].Visible = false;

        }

        //------------------ LIMPIA LOS TEXBOX ------------------
        void Limpiar()
        {
            TxtDescripcion.Text = "";
            TxtExistencias.Text = "";
            TxtMarca.Text = "";
            TxtNombreProducto.Text = "";
            TxtPrecioVenta.Text = "";
        }

        void Limpiar2()
        {
            contador2--;
            foreach (DataGridViewRow row in DgvCarrito.SelectedRows)
            {
                DgvCarrito.Rows.RemoveAt(row.Index);
            }
        }

        private void DgvInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            TxtNombreProducto.Text = DgvInventario.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtDescripcion.Text = DgvInventario.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtPrecioVenta.Text = DgvInventario.Rows[e.RowIndex].Cells[6].Value.ToString();
            CmbCategoria.SelectedValue = DgvInventario.Rows[e.RowIndex].Cells[10].Value.ToString();
            CmbEstante.SelectedValue = DgvInventario.Rows[e.RowIndex].Cells[12].Value.ToString();
            CmbUnidadMedida.SelectedValue = DgvInventario.Rows[e.RowIndex].Cells[11].Value.ToString();

            TxtExistencias.Text = DgvInventario.Rows[e.RowIndex].Cells[7].Value.ToString();
            TxtMarca.Text = DgvInventario.Rows[e.RowIndex].Cells[4].Value.ToString();


            id = Convert.ToInt32(DgvInventario.Rows[e.RowIndex].Cells[0].Value.ToString());


            if (CmbCategoria.SelectedValue.ToString() == "6")
            {
                DtpFechaCaducidad.Enabled = false;

            }
            else
            {
                DtpFechaCaducidad.Enabled = true;
                DtpFechaCaducidad.Value = Convert.ToDateTime(DgvInventario.Rows[e.RowIndex].Cells[9].Value);
            }

        }

        //------------------ AGREGA LOS DATOS ------------------
        void AddProductoSinFactura()
        {
            //llamar para validr la entrada de texto
            string mensaje;
            contador = DgvCarrito.Rows.Count;
            CLogicaAddSinFactura AddProducto = new CLogicaAddSinFactura();

            for (int i = 0; i < contador; i++)
            {
                //Obtenemos los ID de los combobox para pasarlos como parametros

                string Nombre = Convert.ToString(DgvCarrito.Rows[i].Cells[0].Value).Trim();
                string Descripcion = Convert.ToString(DgvCarrito.Rows[i].Cells[1].Value).Trim();
                double precio = Convert.ToDouble(DgvCarrito.Rows[i].Cells[2].Value);
                int IdCategoria = Convert.ToInt32(DgvCarrito.Rows[i].Cells[9].Value);
                int IdEstante = Convert.ToInt32(DgvCarrito.Rows[i].Cells[10].Value);
                int IdUnidadMedida = Convert.ToInt32(DgvCarrito.Rows[i].Cells[11].Value);
                string FechaCaducidad = Convert.ToString(DgvCarrito.Rows[i].Cells[6].Value).Trim();
                double existencias = Convert.ToDouble(DgvCarrito.Rows[i].Cells[7].Value);
                string Marca = Convert.ToString(DgvCarrito.Rows[i].Cells[8].Value).Trim();


                mensaje = AddProducto.LogicaAddSinFactura(Nombre, Descripcion, precio, IdCategoria, IdEstante, IdUnidadMedida, FechaCaducidad, existencias, Marca);

            }

            ///MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //-------------------- AÑADIR EXISTENTE---------------------------
        void AñadirExistente()
        {
            if (RbtExistente.Checked == true)
            {
                string mensaje;
                contador = DgvCarrito.Rows.Count;
                CLogicaAddSinFactura AddProducto = new CLogicaAddSinFactura();

                for (int i = 0; i < contador; i++)
                {
                    //Obtenemos los ID de los combobox para pasarlos como parametros

                    string Nombre = Convert.ToString(DgvCarrito.Rows[i].Cells[0].Value).Trim();
                    string Descripcion = Convert.ToString(DgvCarrito.Rows[i].Cells[1].Value).Trim();
                    double precio = Convert.ToDouble(DgvCarrito.Rows[i].Cells[2].Value);
                    int IdCategoria = Convert.ToInt32(DgvCarrito.Rows[i].Cells[9].Value);
                    int IdEstante = Convert.ToInt32(DgvCarrito.Rows[i].Cells[10].Value);
                    int IdUnidadMedida = Convert.ToInt32(DgvCarrito.Rows[i].Cells[11].Value);
                    string FechaCaducidad = Convert.ToString(DgvCarrito.Rows[i].Cells[6].Value).Trim();
                    double existencias = Convert.ToDouble(DgvCarrito.Rows[i].Cells[7].Value);
                    string Marca = Convert.ToString(DgvCarrito.Rows[i].Cells[8].Value).Trim();

                    int referencia = Convert.ToInt32(DgvCarrito.Rows[i].Cells[12].Value);


                    for (int j = 0; j < DgvInventario.RowCount; j++)
                    {

                        if (referencia == (Convert.ToInt32(DgvInventario.Rows[j].Cells[0].Value)))
                        {

                            sumando = Convert.ToInt32(DgvInventario.Rows[j].Cells[7].Value.ToString());
                            stockFinal = existencias + sumando;
                            mensaje = AddProducto.LogicaEditarSinFactura(referencia, Nombre, Descripcion, precio, IdCategoria, IdEstante, IdUnidadMedida, FechaCaducidad, stockFinal, Marca);
                        }


                    }

                    // MessageBox.Show("inventario: " + sumando);
                    //MessageBox.Show("carrito: " + existencias);
                    //MessageBox.Show("Total: " + stockFinal);



                }
                Limpiar2();
            }


        }





        //------------------ AÑADIR LOS DATOS AL DATAGREED ------------------

        void AñadirDatos()
        {


            DgvCarrito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            contador = 0 + contador2;
            contador2++;

            DgvCarrito.Rows.Add();

            DgvCarrito.Rows[contador].Cells[12].Value = id;

            DgvCarrito.Rows[contador].Cells[0].Value = TxtNombreProducto.Text;
            DgvCarrito.Rows[contador].Cells[1].Value = TxtDescripcion.Text;
            DgvCarrito.Rows[contador].Cells[2].Value = Convert.ToDouble(TxtPrecioVenta.Text);


            int Categoria = Convert.ToInt32(CmbCategoria.SelectedValue.ToString());
            string categoriaa = sql.ConsultaSimple("SELECT DescripcionC as Categoria, IdCategoria as ID FROM Categoria where IdCategoria  = '" + Categoria + "'");
            DgvCarrito.Rows[contador].Cells[3].Value = categoriaa;
            DgvCarrito.Rows[contador].Cells[9].Value = Convert.ToInt32(CmbCategoria.SelectedValue.ToString());

            int estante = Convert.ToInt32(CmbEstante.SelectedValue.ToString());
            string estantee = sql.ConsultaSimple("SELECT  DescripcionEstante as Estante, IdEstante as ID FROM Estanteria where IdEstante  = '" + estante + "'");
            DgvCarrito.Rows[contador].Cells[4].Value = estantee;
            DgvCarrito.Rows[contador].Cells[10].Value = Convert.ToInt32(CmbEstante.SelectedValue.ToString());

            int UndMedida = Convert.ToInt32(CmbUnidadMedida.SelectedValue.ToString());
            string UnidadM = sql.ConsultaSimple("SELECT UnidadMedida.DescripcionTipoUM  as Medida, UnidadMedida.IdUnidadM as ID FROM UnidadMedida where IdUnidadM  = '" + UndMedida + "'");
            DgvCarrito.Rows[contador].Cells[5].Value = UnidadM;
            DgvCarrito.Rows[contador].Cells[11].Value = Convert.ToInt32(CmbUnidadMedida.SelectedValue.ToString());

            DgvCarrito.Rows[contador].Cells[6].Value = DtpFechaCaducidad.Value.ToString("yyy/MM/dd");
            DgvCarrito.Rows[contador].Cells[7].Value = Convert.ToDouble(TxtExistencias.Text);
            DgvCarrito.Rows[contador].Cells[8].Value = TxtMarca.Text;


        }
        //------------------ GUARDA LOS DATOS ------------------
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Boton Clic Agregar ProductoSinFactura
            if (RbtNuevo.Checked == true)
            {
                AddProductoSinFactura();
                CapturarProductoSinFactura("");
                Limpiar();
                Limpiar2();
            }
            if (RbtExistente.Checked == true)
            {
                AñadirExistente();
                CapturarProductoSinFactura("");
                Limpiar2();
                Limpiar();

            }



        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Limpiar2();

        }
        void ActivarFormarDate()
        {

            DtpFechaCaducidad.MaxDate = DateTime.Today.AddDays(999999);
            DtpFechaCaducidad.MinDate = DateTime.Now.AddDays(1);

        }

        private void AñadirSinFactura_Load(object sender, EventArgs e)
        {
            cmbCategoria();
            cmbUnidadMedida();
            cmbEstantes();
            CapturarProductoSinFactura("");
            ActivarFormarDate();
            DgvCarrito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DgvInventario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void DgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            if (validarTextbox())
            {
                AñadirDatos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Porfavor rellene los datos correctamente");
            }



        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Limpiar2();
        }




        public static void SoloNumerosPuntosyComas(KeyPressEventArgs Pe)
        {
            if (char.IsDigit(Pe.KeyChar) || char.IsNumber(Pe.KeyChar) || char.IsControl(Pe.KeyChar)
                || Pe.KeyChar == ',' || Pe.KeyChar == '.')
            {
                Pe.Handled = false;
            }
            else if (char.IsControl(Pe.KeyChar))
            {
                Pe.Handled = false;
            }
            else
            {
                Pe.Handled = true;
            }



        }

        private void TxtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosPuntosyComas(e);
        }

        private void TxtExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosPuntosyComas(e);

        }





        /// ------------------- EDITAR PRODUCTO-------------------------------

        void editarProducto()
        {
            string mensaje;
            CLogicaAddSinFactura AddProducto = new CLogicaAddSinFactura();

            string Nombre = TxtNombreProducto.Text;
            string Descripcion = TxtDescripcion.Text;
            double precio = Convert.ToDouble(TxtPrecioVenta.Text);
            int IdCategoria = Convert.ToInt32(CmbCategoria.SelectedValue.ToString());
            int IdEstante = Convert.ToInt32(CmbEstante.SelectedValue.ToString());
            int IdUnidadMedida = Convert.ToInt32(CmbUnidadMedida.SelectedValue.ToString());
            string FechaCaducidad = Convert.ToString(DtpFechaCaducidad.Value.ToString("yyy/MM/dd"));
            double existencias = Convert.ToDouble(TxtExistencias.Text);
            string Marca = TxtMarca.Text;

            mensaje = AddProducto.LogicaEditarSinFactura(id, Nombre, Descripcion, precio, IdCategoria, IdEstante, IdUnidadMedida, FechaCaducidad, existencias, Marca);


            CapturarProductoSinFactura("");

        }


        private void BtnDesahabilitar_Click(object sender, EventArgs e)
        {
            editarProducto();
            Limpiar();

        }

        private void RbtNuevo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbtExistente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CmbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbCategoria.SelectedValue.ToString() == "6")
            {
                DtpFechaCaducidad.Enabled = false;

            }
            else
            {
                DtpFechaCaducidad.Enabled = true;
            }
        }

        private void DgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
