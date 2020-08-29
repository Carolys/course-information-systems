using FolhaDePagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.DAO
{
    class FolhaDePagamentoDAO
    {

        private static List<FolhaPagamento> folhadepagamentos = new List<FolhaPagamento>();


        public static bool Cadastrar(FolhaDePagamento.Model.FolhaPagamento fp, FolhaDePagamento.Model.Funcionario f)
        {
            if (null != foiDeclarado(f.cpf, fp.mes, fp.ano))
            {
                return false;
            }
            fp.nome = f.nome;
            fp.cpf = f.cpf;
            folhadepagamentos.Add(fp);
            return true;
        }

        public static FolhaPagamento foiDeclarado(string cpf, int mes, int ano)
        {

            foreach (FolhaPagamento fp in folhadepagamentos)
            {
                if (fp.mes == mes && fp.ano == ano && fp.cpf.Equals(cpf))
                {
                    return fp;
                }
            }
            return null;
        }

        public static List<FolhaDePagamento.Model.FolhaPagamento> todos()
        {
            return folhadepagamentos;
        }

    }
}
