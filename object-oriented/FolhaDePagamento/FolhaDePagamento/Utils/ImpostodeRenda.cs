using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.Utils
{
    class ImpostodeRenda
    {
        public static double CalcularImpostodeRenda(double salarioBruto)
        {
            double salario = 0;
            if (salarioBruto <= 1903.98)
            {
                salario = (salarioBruto);

            }
            else if (1903.99 <= salarioBruto && salarioBruto <= 2826.65)
            {

                salario = (salarioBruto - 142.80);

            }
            else if (2826.66 <= salarioBruto && salarioBruto <= 3751.05)
            {

                salario = (salarioBruto - 354.80);

            }
            else if (3751.06 <= salarioBruto && salarioBruto <= 4664.68)
            {

                salario = (salarioBruto - 636.13);
            }
            else if (4664.68 < salarioBruto)
            {

                salario = (salarioBruto - 869.36);
            }
            return salarioBruto - salario;


        }
    }
}