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
    public partial class FormCompraCredito : Form
    {
        public FormCompraCredito()
        {
            InitializeComponent();
        }

        int contador = 0;
        int contador2 = 0;
        int estado = 0;
        string estadoTexto = "";
        double pendiente = 0;
        double suma = 0;
        int i = 0;
        int cuotaPendienteSuma = 0;
        int cuotaCancelada = 0;
        int Estado = 0;

        void añadirCuotas()
        {
            i = i + 1;
            LblContador.Text = Convert.ToString(i);

            if (Convert.ToInt32(LblContador.Text) > Convert.ToInt32(TxtNCuotas.Text))
            {
                MessageBox.Show("No puede exceder el numero de cuotas establecidas");
                i = i - 1;
                LblContador.Text = Convert.ToString(i);
            }


            double MT = Convert.ToDouble(TxtMontoTotal.Text);
            double NC = Convert.ToDouble(TxtNCuotas.Text);

            double cuotafija = MT / NC;
            TxtMontoCuota.Text = Convert.ToString(cuotafija);
        }


        void CuotasPendientes()
        {
            if (ChxPendiente.Checked == true)
            {
                cuotaPendienteSuma = cuotaPendienteSuma + 1;
                TxtCuotasPendientes.Text = Convert.ToString(cuotaPendienteSuma);
            }
            else if (ChxCancelada.Checked == true)
            {
                cuotaCancelada = cuotaCancelada + 1;
                // MessageBox.Show("Cuotas Canceladas " + cuotaCancelada);
            }

        }

        private void BtnAgregarCuotas_Click(object sender, EventArgs e)
        {
            añadirCuotas();
        }

        private void BtnAgregarCuota_Click(object sender, EventArgs e)
        {
            if (ChxPendiente.Checked == false && ChxCancelada.Checked == false)
            {
                MessageBox.Show("Marque el estado de la cuota");
            }
            else
            {
                CapturarDtCarrito();
            }

        }

        void CalcularPendiente()
        {
            pendiente = Convert.ToDouble(TxtMontoTotal.Text) - suma;

            TxtMontoPendiente.Text = Convert.ToString(pendiente);

        }

        void GuardarCuotas()
        {

            //llamar para validr la entrada de texto
            string mensaje;
            contador = DgvSave.Rows.Count;
            CLogicaCompraCreditoo AddCuota = new CLogicaCompraCreditoo();

            for (int i = 0; i < contador; i++)
            {
                //Obtenemos los ID de los combobox para pasarlos como parametros

                if (Convert.ToString(DgvSave.Rows[i].Cells[3].Value) == "Pendiente")
                {
                    Estado = 1;
                }
                else
                {
                    Estado = 2;
                }

                int NCuota = Convert.ToInt32(DgvSave.Rows[i].Cells[0].Value);
                double MTC = Convert.ToDouble(DgvSave.Rows[i].Cells[1].Value);
                string Fecha = Convert.ToString(DgvSave.Rows[i].Cells[2].Value).Trim();

                mensaje = AddCuota.LogicaAddCuotitas(NCuota, MTC, Fecha, Estado);

            }



        }

        void Limpiar2()
        {
            contador2--;
            foreach (DataGridViewRow row in DgvSave.SelectedRows)
            {
                DgvSave.Rows.RemoveAt(row.Index);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCuotas();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Limpiar2();
        }


        void CapturarDtCarrito()
        {

            int filas = DgvSave.Rows.Count;


            // Verificar si ya esta agegado
            Boolean esta = false;
            if (filas != 0)
            {
                for (int i = 0; i < filas; i++)
                {
                    if ((Convert.ToInt32(LblContador.Text) == Convert.ToInt32(DgvSave.Rows[i].Cells[0].Value)))
                    {
                        esta = true;

                        break;

                    }
                }

            }

            if (esta)
            {
                MessageBox.Show("La cuota ya está Añadida");
            }
            else
            {
                //int filas = 0 + contador;
                //contador++;

                DgvSave.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DgvSave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                contador = 0 + contador2;
                contador2++;
                DgvSave.Rows.Add();

                if (ChxPendiente.Checked == true)
                {
                    estado = 1;
                    estadoTexto = "Pendiente";
                }
                else if (ChxCancelada.Checked == true)
                {
                    estado = 2;
                    estadoTexto = "Cancelada";

                    suma = Convert.ToDouble(TxtMontoCuota.Text) + suma;
                }

                if (Convert.ToInt32(LblContador.Text) <= Convert.ToInt32(TxtNCuotas.Text))
                {

                    DgvSave.Rows[contador].Cells[0].Value = Convert.ToInt32(LblContador.Text);
                    DgvSave.Rows[contador].Cells[1].Value = Convert.ToDouble(TxtMontoCuota.Text);
                    DgvSave.Rows[contador].Cells[2].Value = Convert.ToString(DtpFechaPago.Value.ToString("yyy/MM/dd"));
                    DgvSave.Rows[contador].Cells[3].Value = Convert.ToString(estadoTexto);

                    CalcularPendiente();
                    CuotasPendientes();

                }
                else
                {
                    MessageBox.Show("El numero de cuotas esta completa");
                }
            }



        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            int contador3 = DgvSave.Rows.Count;
            for (int i = 0; i < contador3; i++)
            {
                Limpiar2();
            }

            LblContador.Text = "";
            i = 0;
            TxtNCuotas.Text = "";
            TxtMontoCuota.Text = "";
            TxtCuotasPendientes.Text = "";
            TxtMontoPendiente.Text = "";
            cuotaPendienteSuma = 0;
            suma = 0;
        }
    }
}
