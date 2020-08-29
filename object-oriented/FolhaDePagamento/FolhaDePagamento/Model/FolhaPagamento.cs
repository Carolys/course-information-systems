using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolhaDePagamento.Utils;

namespace FolhaDePagamento.Model
{
    class FolhaPagamento
    {
        public string nome { get; set; }
        public double inss { get; set; }
        public double fgts { get; set; }
        public double salarioBruto { get; set; }
        public double salarioLiquido { get; set; }
        public double impostoDeRenda { get; set; }
        public string cpf { get; set; }
        public int mes { get; set; }
        public int ano { get; set; }
        public int horastrabralhadas { get; set; }
        public double valorhora { get; set; }

        public void calcular()
        {
            salarioBruto = SalarioBruto.VerificarSalarioBruto(horastrabralhadas, valorhora);
            fgts = FGTS.CalcularFGTS(salarioBruto);
            inss = INSS.CalcularINSS(salarioBruto);
            impostoDeRenda = ImpostodeRenda.CalcularImpostodeRenda(salarioBruto);
            salarioLiquido = SalarioLiquido.CalcularSalarioLiquido(salarioBruto, impostoDeRenda, inss);

            // Escreva "Salário Bruto: R$ ", SalarioBruto
            // Escreva "Valor do desconto: R$ ", INSS
            // Escreva "Salário Líquido: R$ ", SalarioLiquido
        }

        public override string ToString()
        {
            return " \n " + "Funcinário: " + this.nome + " \n cpf: " + this.cpf + " \n " + "Data: " + this.mes + "/" + this.ano + " \n " + "Data:" + this.horastrabralhadas + " \n " + " horas (R$ " + this.valorhora + "/h) " + " \n " + "salario bruto: " + this.salarioBruto + " \n " + " salario liquido: " + this.salarioLiquido + " \n " + " fgts: " + this.fgts + " \n " + " inss: " + this.inss + " \n " + " imposto de renda: " + this.impostoDeRenda;
        }


    }


}
