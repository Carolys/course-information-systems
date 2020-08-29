using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.View;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 10;
            do
            {
                Console.Clear();
                Console.WriteLine(" -- COLÉGIO -- \n");
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Cadastrar professor");
                Console.WriteLine("3 - Cadastrar turma");
                Console.WriteLine("4 - Listar turma");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Escolha uma opção");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        CadastrarAluno.Executar();
                        break;
                    case 2:
                        CadastrarProfessor.Executar();
                        break;
                    case 3:
                        CadastrarTurma.Executar();
                        break;
                    case 4:
                        ListarTurma.Executar();
                        break;
                    case 0:
                        Console.WriteLine("Saindo... ");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida... ");
                        break;
                }
                Console.WriteLine("\nAperte qualquer tecla para prosseguir... ");
                Console.ReadKey();
            } while (op != 0);

        }
    }
}
