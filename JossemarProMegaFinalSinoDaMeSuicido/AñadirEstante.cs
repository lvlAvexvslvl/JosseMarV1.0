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
using Datos;
namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class AñadirEstante : Form
    {
        public AñadirEstante()
        {
            InitializeComponent();
        }
        CLogicaLlenarCmb fill = new CLogicaLlenarCmb();
        CLogicaAddEstanteyCategoria add = new CLogicaAddEstanteyCategoria();
        CLogicaConsultas sql = new CLogicaConsultas();
        //METODO PARA LLENAR COMBOBOX DE CATEGORIA
        void cmbCategorias()
        {
            CbxCategoria.DataSource = fill.cmbCategoria();
            CbxCategoria.DisplayMember = "DescripcionC";
            CbxCategoria.ValueMember = "IdCategoria";

        }

        //METODO PARA CAPTURAR DATOS
        void CapturarDatosE()
        {
            int IdCategoria = Convert.ToInt32(CbxCategoria.SelectedValue.ToString());
            string descripcionE = TxtDescripcionE.Text;
            add.AddEstante(IdCategoria, descripcionE);

        }
        void CapturarDatosC()
        {
            string descripcionC = TxtCategoria.Text;
            add.AddCategoria(descripcionC);

        }

        void LlenarGridEstante()
        {
            DgvEstante.DataSource = sql.ConsultaTab("SELECT Estanteria.IdEstante as ID, Estanteria.DescripcionEstante as Descripcion, Categoria.DescripcionC as Categoria FROM Estanteria, Categoria WHERE Estanteria.IdCategoria = Categoria.IdCategoria");

        }

        void LlenarGridCategoria()
        {
            DgvCategoria.DataSource = sql.ConsultaTab("SELECT Categoria.IdCategoria as ID, Categoria.DescripcionC as Categoria FROM Categoria");
        }

        //-----------------------------------------------------------------------------------------------

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatosE();
            LlenarGridCategoria();
            LlenarGridEstante();
            cmbCategorias();
        }

        private void AñadirEstante_Load(object sender, EventArgs e)
        {
            DgvCategoria.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgvEstante.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvEstante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmbCategorias();
            LlenarGridEstante();
            LlenarGridCategoria();
        }

        private void BtnGuardarC_Click(object sender, EventArgs e)
        {
            CapturarDatosC();
            LlenarGridCategoria();
            LlenarGridEstante();
            cmbCategorias();
        }
    }
}
