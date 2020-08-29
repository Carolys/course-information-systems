using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.Utils
{
    class FGTS
    {
        public static double CalcularFGTS(double salarioBruto)
        {
            return salarioBruto - (salarioBruto - ((8.0 / 100.0) * salarioBruto));

        }
    }
}