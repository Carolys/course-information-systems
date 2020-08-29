using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.Utils
{
    class SalarioLiquido
    {
        public static double CalcularSalarioLiquido(double salarioBruto, double impostodeRenda, double inss)
        {
            return (salarioBruto - impostodeRenda - inss);

        }

    }
}
