using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.DAO;
using Teste.Model;

namespace Teste.View
{
    class CadastrarProfessor
    {
        public static void Executar()
        {
            Professor p = new Professor();
            Console.Clear();
            Console.WriteLine(" -- CADASTRAR PROFESSOR -- \n");
            Console.WriteLine("Digite o nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento: ");
            p.DataNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite a matricula: ");
            p.Matricula = Console.ReadLine();
            Console.WriteLine("Digite a disciplina: ");
            p.Disciplina = Console.ReadLine();

            if (PessoaDAO.CadastrarProfessor(p))
            {
                Console.Write("Professor cadastrado com sucesso!");
            }
            else
            {
                Console.Write("Professor já cadastrado ");
            }


            Console.ReadKey();
        }
    }
}
