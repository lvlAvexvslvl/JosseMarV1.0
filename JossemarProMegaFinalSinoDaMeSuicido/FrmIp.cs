using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class FrmIp : Form
    {
        public FrmIp()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey rk2 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("PAG");
            string lavacalola = txtDato.Text.Trim();
            rk2.SetValue("IpModem", lavacalola, Microsoft.Win32.RegistryValueKind.String);
            Inicio l = new Inicio();
            l.ShowDialog();
            this.Close();
        }

        private void FrmIp_Load(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey rk1 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("PAG");
            if (rk1 != null)
            {
                Inicio l = new Inicio();
                l.ShowDialog();
                this.Close();
            }
        }
    }
}
