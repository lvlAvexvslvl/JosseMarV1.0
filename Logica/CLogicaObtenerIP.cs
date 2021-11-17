using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
namespace Logica
{
   public class CLogicaObtenerIP
    {
        public string ObtenerIp()
        {
            string Mac = "";
            foreach (NetworkInterface NIC in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (NIC.OperationalStatus == OperationalStatus.Up)
                {
                    Mac += NIC.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return Mac;
        }
    }
}
