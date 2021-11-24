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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
            Diseño();
        }

        int contador = 0;
        bool Eliminar = false;
        int IDCliente = 0, IDClienteCC=0;
        string cedula, telefono;
        CLogicaAgregarClientes add = new CLogicaAgregarClientes();
        CLogicaAgregarClientesCredito add2 = new CLogicaAgregarClientesCredito();
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaContadorCedula contCedula = new CLogicaContadorCedula();
        private void Diseño()
        {
            PnlAgregarCliente.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (PnlAgregarCliente.Visible == true)
                PnlAgregarCliente.Visible = false;
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
            BtnEditar.Enabled = true;
            MostrarMenu(PnlAgregarCliente);
            
            //BtnEditar.Enabled = true;
            
        }

        private void BtnSalirAddCliente_Click(object sender, EventArgs e)
        {
            if (PnlAgregarCliente.Visible == true)
                PnlAgregarCliente.Visible = false;

            BtnEditar.Enabled = false;
        }

        private void TxtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
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
      if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar))
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

        private void TxtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbxCorriente.Checked == true)
            {
                TxtNombreCliente.Enabled = true;
                TxtApellidoCliente.Enabled = true;

                TxtCedulaCliente.Enabled= false;
                TxtCedulaCliente.ReadOnly = true;

                TxtTelefonoCliente.Enabled= false;
                TxtTelefonoCliente.ReadOnly = true;

                txtDireccionCliente.Enabled = false;
                txtDireccionCliente.ReadOnly= true;

                CbxTipoTel.Enabled = false;

               // DgvClientesCredito.Visible = false;
                /* CLogicaAgregarClientes add = new CLogicaAgregarClientes();
                string a = add.AddClientes(TxtNombreCliente.Text.Trim(), TxtApellidoCliente.Text.Trim());*/
            }
        }

        private void ChbxCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbxCredito.Checked == true)
            {
                TxtNombreCliente.Enabled = true;
                TxtNombreCliente.ReadOnly = false;

                TxtApellidoCliente.Enabled = true;
                TxtApellidoCliente.ReadOnly = false;

                TxtCedulaCliente.Enabled = true;
                TxtCedulaCliente.ReadOnly = false;

                TxtTelefonoCliente.Enabled = true;
                TxtTelefonoCliente.ReadOnly = false;

                txtDireccionCliente.Enabled = true;
                txtDireccionCliente.ReadOnly = false;

                CbxTipoTel.Enabled = true;
            }
        }

        //***********METODO VALIDACION****************************
        int MetodoValidar()
        {
            int validation = 0;
            if (TxtNombreCliente.Text != "")
                validation++;

            else
                validation--;

            if (TxtApellidoCliente.Text != "")
                validation++;

            else
                validation--;
            return validation;
        }

        int MetodoValidarAll()
        {
            int validation = 0;
            if (TxtNombreCliente.Text != "")
                validation++;

            else
                validation--;

            if (TxtApellidoCliente.Text != "")
                validation++;

            else
                validation--;

            if(TxtCedulaCliente.Text != "")
                validation++;
            else
                validation--;

            if (TxtTelefonoCliente.Text!="")
                validation++;
            else
                validation--;

            if(txtDireccionCliente.Text != "")
                validation++;
            else
                validation--;

            return validation;
        }

        int contador3 = 0;
       int contador2 = 0;
        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
          
            if (ChbxCorriente.Checked == true)
            {
                if (contador3 == 0)
                    contador = 0;

               
                if (MetodoValidar() > 0)
                {

                    contador3++;

                  //  MessageBox.Show("si" + contador);

                    
                    int filas = 0 + contador;
                    contador++;

                    add.AddClientes(TxtNombreCliente.Text.Trim(),TxtApellidoCliente.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Uno o mas campos están vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            int contador2 = 0;

            if (ChbxCredito.Checked == true)
            {
                if(contador2==0)
                contador = 0;

               
                if (MetodoValidarAll() > 0)
                {

                    //MessageBox.Show("si" + contador);
                    int contT = Convert.ToInt16(contCedula.ContadorTelefonos(TxtTelefonoCliente.Text));
                    if (contT == 1)
                    {
                        MessageBox.Show("El Teléfono que intenta actualizar ya pertenece a otro Proveedor. :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else { 
                        int filas = 0 + contador;
                    contador++;

                    int a = CbxTipoTel.SelectedIndex;
                    a = a + 1;
                   // MessageBox.Show("a" + a);
                    add2.AddClientes(TxtNombreCliente.Text.Trim(), TxtApellidoCliente.Text.Trim(),TxtTelefonoCliente.Text.Trim(),a,txtDireccionCliente.Text.Trim(),TxtCedulaCliente.Text.Trim());
                    }
                }
                else
                {
                    MessageBox.Show("Uno o mas campos están vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CapturarClientesg("");
            CapturarClientesCredito("");
            CapturarClientesSinCredito("");
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNombreCliente.Text = "";
            TxtApellidoCliente.Text = "";
            TxtCedulaCliente.Text = "";
            TxtTelefonoCliente.Text = "";
            txtDireccionCliente.Text = "";
        }

        //************METODO PARA LLENAR DATA CON CLIENTES CREDITO***********************

        void CapturarClientesCredito(string a)
        {
            CLogicaConsultas consult = new CLogicaConsultas();
            DgvClientesCredito.DataSource = consult.ConsultaTab("SELECT vs_ClientesCredito.IdClientesCredito as Cliente, vs_ClientesCredito.NombreCli as Nombre, vs_ClientesCredito.ApellidoCli as Apellido, vs_ClientesCredito.Cedula as Cedula, vs_ClientesCredito.DescripcionTel as Telefono, vs_ClientesCredito.DescripcionDir as Dirección FROM vs_ClientesCredito WHERE vs_ClientesCredito.IdEstadoCliente = '1' AND vs_ClientesCredito.IdEstadoCredito = '2' AND vs_ClientesCredito.NombreCli LIKE'%" + a + "%'");
        }

        void CapturarClientesg(string a)
        {
            CLogicaConsultas consult = new CLogicaConsultas();
            DgvBucarCliente.DataSource = consult.ConsultaTab("SELECT vs_ClienteGeneral.NombreCli as Nombre, vs_ClienteGeneral.ApellidoCli as Apellido FROM vs_ClienteGeneral WHERE vs_ClienteGeneral.IdEstadoCliente = '1' AND vs_ClienteGeneral.NombreCli LIKE'%" + a + "%'");
        }

        void CapturarClientesSinCredito(string a)
        {
            CLogicaConsultas consult = new CLogicaConsultas();
            DgvClientes.DataSource = consult.ConsultaTab("SELECT vs_ClienteGeneral.IdClientes as ID, vs_ClienteGeneral.NombreCli as Nombre, vs_ClienteGeneral.ApellidoCli as Apellido FROM vs_ClienteGeneral WHERE vs_ClienteGeneral.IdEstadoCliente = '1' AND vs_ClienteGeneral.IdEstadoCredito = '1' AND vs_ClienteGeneral.NombreCli LIKE'%" + a + "%'");
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            DgvClientesCredito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvClientesCredito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgvClientes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgvBucarCliente.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvBucarCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CapturarClientesg("");
            CapturarClientesCredito("");
            CapturarClientesSinCredito("");
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CapturarClientesg(TxtBuscar.Text);
            CapturarClientesCredito(TxtBuscar.Text);
            CapturarClientesSinCredito(TxtBuscar.Text);

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
          
                MessageBox.Show(Convert.ToString(DgvClientes.CurrentRow.Cells[0].Value).Trim());
                foreach (DataGridViewRow row in DgvClientes.SelectedRows)
                {
                    CLogicaConsultas consult = new CLogicaConsultas();
                    consult.ConsultaSimple("Update dbo.Clientes set IdEstadoCliente = 2 WHERE Clientes.NombreCli ='" + Convert.ToString(DgvClientes.CurrentRow.Cells[1].Value).Trim() + "'");
                }

               CapturarClientesSinCredito("");
            CapturarClientesCredito("");
            CapturarClientesg("");
            /* }*/
            //Eliminar = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           /* CapturarClientesCredito();
            CapturarClientesSinCredito();
            /* if (Eliminar == true)
             {*/
            MessageBox.Show(Convert.ToString(DgvClientesCredito.CurrentRow.Cells[0].Value).Trim());
            foreach (DataGridViewRow row in DgvClientesCredito.SelectedRows)
                {
                    CLogicaConsultas consult = new CLogicaConsultas();
                    consult.ConsultaSimple("Update dbo.Clientes set IdEstadoCliente = 2 WHERE Clientes.NombreCli ='" + Convert.ToString(DgvClientesCredito.CurrentRow.Cells[1].Value).Trim() + "'");
                }

                CapturarClientesCredito("");
            CapturarClientesSinCredito("");
            CapturarClientesg("");
            /* }
             Eliminar = false;*/
        }

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Eliminar = true;
        }

        private void DgvClientesCredito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // Eliminar = true;
        }

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            Eliminar = true;
            IDCliente = Convert.ToInt16(DgvClientes.CurrentRow.Cells[0].Value);
            TxtNombreCliente.Text = Convert.ToString(DgvClientes.CurrentRow.Cells[1].Value).Trim();
            TxtApellidoCliente.Text = Convert.ToString(DgvClientes.CurrentRow.Cells[2].Value).Trim();
        }

        private void BtnEditarCC_Click(object sender, EventArgs e)
        {
            MostrarMenu(PnlAgregarCliente);

            if (MetodoValidar() > 0)
            {
                int a = CbxTipoTel.SelectedIndex;
                a = a + 1;

                if (a > 0)
                {
                 // int contC = Convert.ToInt16(contCedula.ContadorCedula(TxtCedulaCliente.Text));
                    //MessageBox.Show("a" + contC);
                    
                        add2.EditarCCC(IDClienteCC, TxtNombreCliente.Text, TxtApellidoCliente.Text, TxtTelefonoCliente.Text, a, txtDireccionCliente.Text, TxtCedulaCliente.Text);
                        int contC = Convert.ToInt16(contCedula.ContadorCedula(TxtCedulaCliente.Text));
                    int contT = Convert.ToInt16(contCedula.ContadorTelefonos(TxtTelefonoCliente.Text));
                    if (contC > 1)
                    {
                        MessageBox.Show("La cédula que intenta actualizar ya pertenece a otro cliente. :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Se actualizó este campo con la información que tenía anteriormente. :)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //----------------------------------------

                       // MessageBox.Show(cedula);
                        add2.EditarCCC(IDClienteCC, TxtNombreCliente.Text, TxtApellidoCliente.Text, telefono, a, txtDireccionCliente.Text, cedula);
                        CapturarClientesCredito("");
                        CapturarClientesSinCredito("");
                        CapturarClientesg("");

                    }
                    contT = Convert.ToInt16(contCedula.ContadorTelefonos(TxtTelefonoCliente.Text));
                    if (contT > 1)
                    {
                        MessageBox.Show("La Teléfono que intenta actualizar ya pertenece a otro cliente. :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Se actualizó este campo con la información que tenía anteriormente. :)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        add2.EditarCCC(IDClienteCC, TxtNombreCliente.Text, TxtApellidoCliente.Text, telefono, a, txtDireccionCliente.Text, cedula);
                        CapturarClientesCredito("");
                        CapturarClientesSinCredito("");
                        CapturarClientesg("");

                    }

                    
                    CapturarClientesCredito("");
                    CapturarClientesSinCredito("");
                    CapturarClientesg("");

                }
                    
                else
                    MessageBox.Show("Seleccione un campo del ComboBox. :)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
                CapturarClientesCredito("");
                CapturarClientesSinCredito("");
                CapturarClientesg("");
            }
            else
            {
                MessageBox.Show("Uno o mas campos están vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO PARA VALIDAR QUE LOS CAMPOS NO ESTEN VACIOS
        

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            MostrarMenu(PnlAgregarCliente);
            if (MetodoValidar() > 0){
                add.EditarCC(IDCliente, TxtNombreCliente.Text, TxtApellidoCliente.Text);
                CapturarClientesCredito("");
                CapturarClientesSinCredito("");
                CapturarClientesg("");
            }
            else
            {
                MessageBox.Show("Uno o mas campos están vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //************************************************************************

        private void DgvClientesCredito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDClienteCC = Convert.ToInt16(DgvClientesCredito.CurrentRow.Cells[0].Value);
            TxtNombreCliente.Text = Convert.ToString(DgvClientesCredito.CurrentRow.Cells[1].Value).Trim();
            TxtApellidoCliente.Text = Convert.ToString(DgvClientesCredito.CurrentRow.Cells[2].Value).Trim();
            TxtCedulaCliente.Text = Convert.ToString(DgvClientesCredito.CurrentRow.Cells[3].Value).Trim();
            cedula = Convert.ToString(DgvClientesCredito.CurrentRow.Cells[3].Value).Trim();
            TxtTelefonoCliente.Text = Convert.ToString(DgvClientesCredito.CurrentRow.Cells[4].Value).Trim();
            telefono = Convert.ToString(DgvClientesCredito.CurrentRow.Cells[4].Value).Trim();
            txtDireccionCliente.Text = Convert.ToString(DgvClientesCredito.CurrentRow.Cells[5].Value).Trim();
        }
    }
}
