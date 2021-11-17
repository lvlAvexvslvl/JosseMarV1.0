using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using Datos;
namespace Logica
{
   public class CLogicaConsultas
    {
        CDatosConsulta c = new CDatosConsulta();
        ArrayList arr = new ArrayList();
        DataTable dt = new DataTable();
        CLogicaObtenerIP IP = new CLogicaObtenerIP();

        public string ConsultaSimple(string sql)
        {
            string resultado = c.CSimple(sql);
            return resultado;
        }
        public ArrayList Consulta(string sql)
        {
            string result;
            dt = c.Consulta(sql);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                result = Convert.ToString(dt.Rows[0][i]);
                arr.Add(result);
            }
            return arr;
        }
        public DataTable ConsultaTab(string sql)
        {
            DataTable tab = new DataTable();
            tab = c.Consulta(sql);
            return tab;
        }
        public void Insertar(string sql)
        {
            c.Insertar(sql);
        }
        public string obtenerID()
        {
            string IPM = IP.ObtenerIp();
            string ip = ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + IPM.Trim() + "'");

            return ip;
        }
    }
}
