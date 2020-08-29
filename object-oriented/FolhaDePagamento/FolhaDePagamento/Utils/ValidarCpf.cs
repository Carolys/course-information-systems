using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.Utils
{
    class ValidarCpf
    {

        public static bool Cpf(string cpf)
        {

            if (cpf.Length != 11)
            {
                return false;
            }

            switch (cpf)
            {
                case "11111111111":
                    return false;
                case "22222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
                case "00000000000":
                    return false;
            }

            int peso = 10;
            int soma = 0;
            int resto;
            int digito1, digito2;


            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }

            resto = soma % 11;
            if (resto < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - resto;
            }


            soma = 0;
            peso = 11;


            for (int i = 0; i < 10; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }

            resto = soma % 11;
            if (resto < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - resto;
            }


            if (Convert.ToInt32(cpf[9].ToString()) == digito1
                && Convert.ToInt32(cpf[10].ToString()) == digito2)
            {
                return true;
            }
            return false;
        }
    }
}
