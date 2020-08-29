using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.Utils
{
    class SalarioBruto
    {
        public static double VerificarSalarioBruto(int horasTrabalhadas, double ValorHora)
        {
            return (horasTrabalhadas * ValorHora);

        }
    }
}
