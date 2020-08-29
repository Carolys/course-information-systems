using FolhaDePagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.DAO
{
    class FuncionarioDAO
    {

        private static List<Funcionario> funcionarios = new List<Funcionario>();

        public static bool CadastrarFuncionario(Funcionario funcionario)
        {
            if (BuscarFuncionarioPorCpf(funcionario) != null)
            {
                return false;
            }
            funcionarios.Add(funcionario);
            return true;
        }

        public static Funcionario BuscarFuncionarioPorCpf(Funcionario funcionario)
        {
            foreach (Funcionario i in funcionarios)
            {
                if (i.cpf.Equals(funcionario.cpf))
                {
                    return i;
                }
            }
            return null;
        }

        public static List<Funcionario> RetornarFuncionarios()
        {
            return funcionarios;
        }

        public static bool VerificarFuncionarioPorCpf(string cpf)
        {
            foreach (Funcionario i in funcionarios)
            {
                if (i.cpf.Equals(cpf))
                {
                    return true;
                }
            }
            return false;
        }
    }

}
