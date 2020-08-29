using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.Utils
{
    class INSS
    {
        public static double CalcularINSS(double salarioBruto)
        {
            double salario = 0;
            double desconto = 0;
            if (salarioBruto <= 1659.38)
            {
                desconto = 0.08;
                desconto = salarioBruto * desconto;
                salario = salarioBruto - desconto;
                //return (salarioBruto - ((8.0 / 100.0) * salarioBruto));

            }
            else if (1659.39 <= salarioBruto && salarioBruto <= 2765.66)
            {
                desconto = 0.09;
                desconto = salarioBruto * desconto;
                salario = salarioBruto - desconto;
                //return (salarioBruto - ((9.0 / 100.0) * salarioBruto));

            }
            else if (2765.67 <= salarioBruto && salarioBruto <= 5531.31)
            {
                desconto = 0.11;
                desconto = salarioBruto * desconto;
                salario = salarioBruto - desconto;
                //return (salarioBruto - ((11.0 / 100.0) * salarioBruto));

            }
            else if (5531.31 < salarioBruto)
            {
                desconto = 608.44;
                salario = salarioBruto - desconto;

                //return (salarioBruto - 608.44);
            }
            return salarioBruto - salario;
        }
    }
}