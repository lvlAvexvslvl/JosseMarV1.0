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
using Datos;
namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
            Diseño();
        }
        int contador = 0;
        bool Eliminar = false;
        int IDEmpleado = 0;
        string cedula, telefono;
        CLogicaAgregarEmpleados add = new CLogicaAgregarEmpleados();
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaContadorCedula contCedula = new CLogicaContadorCedula();
        CDatosValidarCedula validation = new CDatosValidarCedula();
        private void Diseño()
        {
            PnlAgregarEmpleado.Visible = false;
            BtnEditar.Enabled = false;
        }

        private void ocultarSubMenu()
        {
            if (PnlAgregarEmpleado.Visible == true)
                PnlAgregarEmpleado.Visible = false;
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
            MostrarMenu(PnlAgregarEmpleado);
            BtnEditar.Enabled = true;
        }

        private void BtnSalirAddEmpleado_Click(object sender, EventArgs e)
        {
            if (PnlAgregarEmpleado.Visible == true)
                PnlAgregarEmpleado.Visible = false;
            if (BtnEditar.Enabled == true)
                BtnEditar.Enabled = false;
        }

        private void TxtNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtApellidoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        //METODO PARA VALIDAR QUE LOS CAMPOS NO ESTEN VACIOS
        int MetodoValidarAll()
        {
            int validation = 0;
            if (TxtNombreEmpleado.Text != "")
                validation++;

            else
                validation--;

            if (TxtApellidoEmpleado.Text != "")
                validation++;

            else
                validation--;

            if (TxtCedulaCliente.Text != "")
                validation++;
            else
                validation--;

            if (TxtTelefono.Text != "")
                validation++;
            else
                validation--;

            if (TxtDireccion.Text != "")
                validation++;
            else
                validation--;

            return validation;
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            DgvEmpleado.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgvBucarEmpleado.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvBucarEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmbTipoE();
            MostrarProvAlls("");
            buscarE("");
            DgvEmpleado.Columns["ID"].Visible = false;
        }

        void Delete()
        {
            TxtNombreEmpleado.Text = "";
            TxtApellidoEmpleado.Text = "";
            TxtCedulaCliente.Text = "";
            TxtTelefono.Text = "";
            TxtDireccion.Text = "";
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        //METODO PARA LLENAR COMBOBOX
        void cmbTipoE()
        {
            CbxTipoE.DataSource = add.cmbEmpleados();
            CbxTipoE.DisplayMember = "DescripcionTE";
            CbxTipoE.ValueMember = "IdTipoEmpleado";

        }

        private void BtnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (MetodoValidarAll() == 5)
            {
                int a = CbTipoTelefono.SelectedIndex;
                a = a + 1;

                int b = Convert.ToInt32(CbxTipoE.SelectedValue);

                int contT = Convert.ToInt16(contCedula.ContadorTelefonos(TxtTelefono.Text));
                if (contT == 1)
                {
                    MessageBox.Show("La Teléfono que intenta actualizar ya pertenece a otro Proveedor. :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                    if (a > 0)
                    {
                        string z = Convert.ToString(validation.ValidarCedula(TxtCedulaCliente.Text));
                        if (z == "OK")
                        {
                            
                            add.AddEmpleados(b, TxtCedulaCliente.Text, TxtNombreEmpleado.Text, TxtApellidoEmpleado.Text, TxtTelefono.Text, a, TxtDireccion.Text);
                            Delete();
                        }
                        else
                        {
                            MessageBox.Show("Su cédula no es válida. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    
                else
                    MessageBox.Show("Seleccione un campo del ComboBox <Tipo Telefono>. :)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
            }
            else
            {
                MessageBox.Show("Uno o mas campos están vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarProvAlls("");
            buscarE("");
        }

        //METODO PARA MOSTRAR EMPLEADOS
        void MostrarProvAlls(string e)
        {
            DgvEmpleado.DataSource = sql.ConsultaTab("SELECT vs_Empleados.IdEmpleado as ID, vs_Empleados.Nombre as Nombre, vs_Empleados.Apellido as Apellido, vs_Empleados.CedulaE as Cedula, vs_Empleados.DescripcionTel as Teléfono, vs_Empleados.DescripcionDir FROM vs_Empleados  WHERE vs_Empleados.IdEstadoEmpleado = '1' AND vs_Empleados.Nombre LIKE'%" + e + "%'");
        }
        void buscarE(String e)
        {
            DgvBucarEmpleado.DataSource = sql.ConsultaTab("SELECT vs_Empleados.Nombre as Nombre,vs_Empleados.CedulaE as Cedula, vs_Empleados.DescripcionTE FROM vs_Empleados WHERE vs_Empleados.IdEstadoEmpleado = '1' AND vs_Empleados.Nombre LIKE'%" + e + "%'");
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarE(TxtBuscar.Text);
            MostrarProvAlls(TxtBuscar.Text);
        }

        private void DgvEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDEmpleado = Convert.ToInt16(DgvEmpleado.CurrentRow.Cells[0].Value);
            TxtNombreEmpleado.Text = Convert.ToString(DgvEmpleado.CurrentRow.Cells[1].Value).Trim();
            TxtApellidoEmpleado.Text = Convert.ToString(DgvEmpleado.CurrentRow.Cells[2].Value).Trim();
            TxtCedulaCliente.Text = Convert.ToString(DgvEmpleado.CurrentRow.Cells[3].Value).Trim();
            cedula = Convert.ToString(DgvEmpleado.CurrentRow.Cells[3].Value).Trim();
            TxtTelefono.Text = Convert.ToString(DgvEmpleado.CurrentRow.Cells[4].Value).Trim();
            telefono = Convert.ToString(DgvEmpleado.CurrentRow.Cells[4].Value).Trim();
            TxtDireccion.Text = Convert.ToString(DgvEmpleado.CurrentRow.Cells[5].Value).Trim();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (MetodoValidarAll() > 0)
            {
                int a = CbTipoTelefono.SelectedIndex;
                a = a + 1;

                int b = Convert.ToInt32(CbxTipoE.SelectedValue);

                if (a > 0)
                {
                    // int contC = Convert.ToInt16(contCedula.ContadorCedula(TxtCedulaCliente.Text));
                    //MessageBox.Show("a" + contC);


                    add.EditarE(IDEmpleado, b, TxtCedulaCliente.Text, TxtNombreEmpleado.Text, TxtApellidoEmpleado.Text, TxtTelefono.Text, a, TxtDireccion.Text);
                    int contC = Convert.ToInt16(contCedula.ContadorCedulaEmpleado(TxtCedulaCliente.Text));
                    int contT = Convert.ToInt16(contCedula.ContadorTelefonos(TxtTelefono.Text));
                    if (contC > 1)
                    {
                        MessageBox.Show("La cédula que intenta actualizar ya pertenece a otro Empleado. :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Se actualizó este campo con la información que tenía anteriormente. :)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //----------------------------------------
                        add.EditarE(IDEmpleado, b, cedula, TxtNombreEmpleado.Text, TxtApellidoEmpleado.Text, TxtTelefono.Text, a, TxtDireccion.Text);
                    }
                    contT = Convert.ToInt16(contCedula.ContadorTelefonos(TxtTelefono.Text));
                       if (contT > 1) {
                            MessageBox.Show("El Teléfono que intenta actualizar ya pertenece a otro Empleado. :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Se actualizó este campo con la información que tenía anteriormente. :)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            add.EditarE(IDEmpleado, b, cedula, TxtNombreEmpleado.Text, TxtApellidoEmpleado.Text, telefono.Trim(), a, TxtDireccion.Text);

                        MostrarProvAlls("");
                        buscarE("");
                        Delete();
                         }

                        MostrarProvAlls("");
                        buscarE("");

                   


                }

                else
                    MessageBox.Show("Seleccione un campo del ComboBox. :)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MostrarProvAlls("");
                buscarE("");
            }
            else
            {
                MessageBox.Show("Uno o mas campos están vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtCedulaCliente_Enter(object sender, EventArgs e)
        {
            if (TxtCedulaCliente.Text == "0000000000000A")
            {
                TxtCedulaCliente.Text = "";
            }
        }

        private void TxtCedulaCliente_Leave(object sender, EventArgs e)
        {
            if (TxtCedulaCliente.Text == "")
            {
                TxtCedulaCliente.Text = "0000000000000A";
            }
        }

        private void DgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
           /* FrmMenssage m = new FrmMenssage("¿Desea eliminar este empleado?");
            m.Show();*/
            CLogicaMessageRes res = new CLogicaMessageRes();
           // m.Respuesta();
            //if(res.resFinal() >= 0 && res.resFinal() == 0) { 
            foreach (DataGridViewRow row in DgvEmpleado.SelectedRows)
            {
                CLogicaConsultas consult = new CLogicaConsultas();
                consult.ConsultaSimple("Update dbo.Empleados set IdEstadoEmpleado = 2 WHERE Empleados.IdEmpleado ='" + Convert.ToInt32(DgvEmpleado.CurrentRow.Cells[0].Value) + "'");
                    MessageBox.Show("Empleado eliminado con éxito. :)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //}
            //else
            //{
               // MessageBox.Show("Empleado a salvo. :)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            MostrarProvAlls("");
            buscarE("");
        }
    }
}
