using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioA.Model;

namespace VendasOsorioA.View
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c;
            int op;
            
            do
            {
                Console.Clear();
                Console.WriteLine(" -- VENDAS -- ");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nEscolha uma opção:");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        c = new Cliente();
                        Console.Clear();
                        Console.WriteLine(" -- CADASTRAR CLIENTE -- \n");
                        Console.WriteLine("Digite o nome do cliente:");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente:");
                        c.Cpf = Console.ReadLine();
              
                        //Chamar o método

                        Console.WriteLine("Cliente cadastrado com sucesso!");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" -- LISTAR CLIENTE -- \n");
                        for (int i = 0; i < clientes.Count; i++)
                        {
                            Console.WriteLine("Nome: " + clientes[i].Nome);
                            Console.WriteLine("CPF: " + clientes[i].Cpf);
                        }

                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Aperte para continuar...");
                Console.ReadKey();
            } while (op != 0);

        }
    }
}
