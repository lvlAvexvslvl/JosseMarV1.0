using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    class CConexion
    {
        static Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("PAG");
        static string server = (String)key.GetValue("IpModem");
        //public SqlConnection conexion = new SqlConnection("Data Source = localhost; Initial Catalog = BddJossemar1.3; Integrated Security = True");
        //Console.WriteLine(server);
        //public SqlConnection conexion = new SqlConnection("Data Source =" + server + "; Initial Catalog = BddJossemar1.3; Integrated Security = True");
        //public SqlConnection conexion = new SqlConnection("Data Source =.; Initial Catalog = prueba; Integrated Security = True");
        public SqlConnection conexion = new SqlConnection("Data Source =" + server + "; Initial Catalog = BddJossemar123; User ID = User1; Password = root;");
        
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
           
           //MessageBox.Show("Conexion abierta");
            return conexion;


        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
