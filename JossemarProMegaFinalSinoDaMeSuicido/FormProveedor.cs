using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logica;
namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();
            Diseño();
        }
        //INSTANCIA DE LA CLASE LOGICA PROVEEDORES
        CLogicaAgregarProveedor add = new CLogicaAgregarProveedor();
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaContadorCedula contCedula = new CLogicaContadorCedula();
        string telefono;
        int IDproveedor = 0;
        private void Diseño()
        {
            PnlAgregarProveedor.Visible = false;
            BtnEditar.Enabled = false;
        }

        private void ocultarSubMenu()
        {
            if (PnlAgregarProveedor.Visible == true)
                PnlAgregarProveedor.Visible = false;
            if (BtnEditar.Enabled == true)
                BtnEditar.Enabled = false;
        }

        private void MostrarMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                ocultarSubMenu();
                SubMenu.Visible = true;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MostrarMenu(PnlAgregarProveedor);
            BtnEditar.Enabled = true;
        }

        private void BtnSalirAddProveedor_Click(object sender, EventArgs e)
        {
            if (PnlAgregarProveedor.Visible == true)
                PnlAgregarProveedor.Visible = false;
            if (BtnEditar.Enabled == true)
                BtnEditar.Enabled = false;
        }


        private void TxtTelefonoEmpresa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNombreEmpresa.Text = "";
            TxtTelefonoEmpresa.Text = "";
            txtDireccionEmpresa.Text = "";
        }

        //METODO PARA VALIDAR QUE LOS CAMPOS NO ESTEN VACIOS
        int MetodoValidarAll()
        {
            int validation = 0;
            if (TxtNombreEmpresa.Text != "")
                validation++;

            else
                validation--;

            if (TxtTelefonoEmpresa.Text != "")
                validation++;

            else
                validation--;

            if (txtDireccionEmpresa.Text != "")
                validation++;
            else
                validation--;

            return validation;
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (MetodoValidarAll() > 0)
            {
                int a = CbTipoTelefono.SelectedIndex;
                a = a + 1;
                // MessageBox.Show("a" + a);
                int contT = Convert.ToInt16(contCedula.ContadorTelefonos(TxtTelefonoEmpresa.Text));
                if (contT == 1)
                {
                    MessageBox.Show("La Teléfono que intenta actualizar ya pertenece a otro Proveedor. :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("Se actualizó este campo con la información que tenía anteriormente. :)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //add.AddProveedor(TxtNombreEmpresa.Text.Trim(), txtDireccionEmpresa.Text.Trim(), TxtTelefonoEmpresa.Text.Trim(), a);
                    MostrarProvAlls("");
                    BuscarProv("");

                }
                else
                {
                    add.AddProveedor(TxtNombreEmpresa.Text.Trim(), txtDireccionEmpresa.Text.Trim(), TxtTelefonoEmpresa.Text.Trim(), a);
                    MostrarProvAlls("");
                    BuscarProv("");
                }
            }
            else
            {
                MessageBox.Show("Uno o mas campos están vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            DgvProveedores.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgvBucarProveedor.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvBucarProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MostrarProvAlls("");
            BuscarProv("");

        }

        void MostrarProvAlls(string a)
        {
            DgvProveedores.DataSource = sql.ConsultaTab("SELECT vs_Proveedores.IdProveedor AS ID, vs_Proveedores.NombreEmpresa as Empresa, vs_Proveedores.DescripcionDir as Dirección, vs_Proveedores.DescripcionTel as Telefono FROM vs_Proveedores WHERE vs_Proveedores.IdEstado = 1 AND vs_Proveedores.NombreEmpresa LIKE'%" + a + "%'");
        }

        void BuscarProv(string a)
        {
            DgvBucarProveedor.DataSource = sql.ConsultaTab("SELECT vs_Proveedores.NombreEmpresa as Empresa, vs_Proveedores.DescripcionTel as Telefono FROM vs_Proveedores WHERE vs_Proveedores.IdEstado = 1 AND vs_Proveedores.NombreEmpresa LIKE'%" + a+"%'");
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarProv(TxtBuscar.Text);
            MostrarProvAlls(TxtBuscar.Text);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(DgvProveedores.CurrentRow.Cells[1].Value).Trim());
            foreach (DataGridViewRow row in DgvProveedores.SelectedRows)
            {
                CLogicaConsultas consult = new CLogicaConsultas();
                consult.ConsultaSimple("Update dbo.Proveedor set IdEstado = 2 WHERE Proveedor.NombreEmpresa='" + Convert.ToString(DgvProveedores.CurrentRow.Cells[1].Value).Trim() + "'");
            }

            MostrarProvAlls("");
            BuscarProv("");
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (MetodoValidarAll() > 0)
            {
                int a = CbTipoTelefono.SelectedIndex;
                a = a + 1;

               int contT = Convert.ToInt16(contCedula.ContadorTelefonos(TxtTelefonoEmpresa.Text));
                if (contT > 1)
                {
                    MessageBox.Show("La Teléfono que intenta actualizar ya pertenece a otro Proveedor. :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Se actualizó este campo con la información que tenía anteriormente. :)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (a > 0)
                    {
                        add.Editar(IDproveedor, TxtNombreEmpresa.Text, txtDireccionEmpresa.Text, telefono, a);
                        MessageBox.Show("El Proveedor se actualizó correctamente. :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                        
                    else
                        MessageBox.Show("Seleccione un campo del ComboBox. :)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    contT = Convert.ToInt16(contCedula.ContadorTelefonos(TxtTelefonoEmpresa.Text));
                    if (contT == 1)
                    {
                        MessageBox.Show("La Teléfono que intenta actualizar ya pertenece a otro Proveedor. :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Se actualizó este campo con la información que tenía anteriormente. :)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (a > 0)
                        {
                            add.Editar(IDproveedor, TxtNombreEmpresa.Text, txtDireccionEmpresa.Text, telefono, a);
                            MessageBox.Show("El Proveedor se actualizó correctamente. :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                         
                        else
                            MessageBox.Show("Seleccione un campo del ComboBox. :)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        if (a > 0)
                        {
                            add.Editar(IDproveedor, TxtNombreEmpresa.Text, txtDireccionEmpresa.Text, TxtTelefonoEmpresa.Text, a);
                            MessageBox.Show("El Proveedor se actualizó correctamente. :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                            MessageBox.Show("Seleccione un campo del ComboBox. :)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Uno o mas campos están vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarProvAlls("");
            BuscarProv("");
        }

        private void DgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDproveedor = Convert.ToInt16(DgvProveedores.CurrentRow.Cells[0].Value);
            TxtNombreEmpresa.Text = Convert.ToString(DgvProveedores.CurrentRow.Cells[1].Value).Trim();
            TxtTelefonoEmpresa.Text = Convert.ToString(DgvProveedores.CurrentRow.Cells[3].Value).Trim();
            telefono = Convert.ToString(DgvProveedores.CurrentRow.Cells[3].Value).Trim();
            txtDireccionEmpresa.Text = Convert.ToString(DgvProveedores.CurrentRow.Cells[2].Value).Trim();
        }
    }
}
