using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.DAO;
using Teste.Model;

namespace Teste
{
    class CadastrarAluno
    {
        public static void Executar()
        {
            Aluno a = new Aluno();
            Console.Clear();
            Console.WriteLine(" -- CADASTRAR ALUNO -- \n");
            Console.WriteLine("Digite o nome: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento: ");
            a.DataNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite a matricula: ");
            a.Matricula = Console.ReadLine();
            Console.WriteLine("Digite o telefone: ");
            a.Telefone = Console.ReadLine();

            if (PessoaDAO.CadastrarAluno(a))
            {
                Console.Write("Aluno cadastrado com sucesso!");
            }
            else
            {
                Console.Write("Aluno já cadastrado ");
            }


            Console.ReadKey();
        }

    }
}
