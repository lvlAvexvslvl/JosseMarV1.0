using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CLogicaMessageRes
    {
        int respuesta  = -1;
        public int res(int res)
        {
            respuesta = res;
            return res;
        }

        public int resFinal()
        {
            return respuesta;
        }
    }
}
