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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        CLogicaLlenarCmb llenar = new CLogicaLlenarCmb();
        CLogicaAdmin add = new CLogicaAdmin();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GbxPrivilegios.Enabled = true;
            Label1.Enabled = true;
            Label2.Enabled = true;
            TxtNomUsuario.Enabled = true;
            CmbPrivilegios.Enabled = true;

            //*******************************
            GbxPrivilegios.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            TxtNomUsuario.Visible = true;
            CmbPrivilegios.Visible = true;
        }

        void IniciarLoad(string a)
        {
            DgvUsuarios.DataSource = llenar.LlenarDgvUsuarios(a);
            
        }

        void LlenarCmbPrivilegios()
        {
            CmbPrivilegios.DataSource = llenar.cmbPrivilegios();
            CmbPrivilegios.DisplayMember = "DescripcionTU";
            CmbPrivilegios.ValueMember = "IdTipoUsuario";
        }
       
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            DgvUsuarios.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            IniciarLoad("");
            LlenarCmbPrivilegios();
            this.DgvUsuarios.Columns["IDTU"].Visible = false;
            this.DgvUsuarios.Columns["IDE"].Visible = false;
            this.DgvUsuarios.Columns["ID"].Visible = false;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            IniciarLoad(TxtBuscar.Text);
        }


        void CapturarDatosEditar()
        {
            string res = "";
            if (TxtNomUsuario.Text !="")
            {
                if(TxtNomUsuario.Text.Trim() == "sa")
                {
                    MessageBox.Show("No se puede cambiar de privilegio a este usuario <sa>", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { 
                string nomU = TxtNomUsuario.Text.Trim();
                int Id = Convert.ToInt32(CmbPrivilegios.SelectedValue.ToString());

                 res =  add.AddPrivilegios(nomU, Id);
                }
            }
            if(res == "G")
            {
                MessageBox.Show("La edición de privilegios se hizo correctamente");
            }
            else
            {
                MessageBox.Show("Hubo un error al asignar privilegios","Avíso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            CapturarDatosEditar();
            IniciarLoad("");
        }
        private void AgreUpdateEventHanler(object sender, FrmAgregarUsuarios.UpdateEventArgs args)
        {
            IniciarLoad("");
            ChxAddUser.Checked = false;
        }
        private void ChxAddUser_CheckedChanged(object sender, EventArgs e)
        {
            if (ChxAddUser.Checked == true)
            {
                FrmAgregarUsuarios frm = new FrmAgregarUsuarios(this);
                frm.UpdateEventHanler += AgreUpdateEventHanler;
                frm.ShowDialog();
            }
            else
            {
                FrmAgregarUsuarios frm = new FrmAgregarUsuarios(this);
                frm.UpdateEventHanler += AgreUpdateEventHanler;
                frm.Close();
                ChxAddUser.Checked = false;
            }
        }

        private void UpdateTime_Tick(object sender, EventArgs e)
        {
            IniciarLoad("");
        }
    }
}
