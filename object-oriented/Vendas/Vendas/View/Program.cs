using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.View
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int op = 0;
            string nome = "";
            string cpf = "";
            Cliente c = new Cliente();
            DAL.ClienteDAO d = new DAL.ClienteDAO();
 
            do
            {
                Console.Clear();
                Console.WriteLine(" 1 – Cadastrar de Cliente");
                Console.WriteLine(" 2 – Listar de Clientes ");
                Console.WriteLine(" 3 – Cadastrar de Vendedor ");
                Console.WriteLine(" 4 – Listar de Vendedores ");
                Console.WriteLine(" 5 – Cadastrar de Produto ");
                Console.WriteLine(" 6 – Listar de Produtos ");
                Console.WriteLine(" 7 – Registrar Venda ");
                Console.WriteLine(" 8 – Listar Vendas ");
                Console.WriteLine(" 9 – Listar Vendas por Cliente ");
                Console.WriteLine(" 0 – Sair ");
                Console.WriteLine("Escolha uma opção: ");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        c = new Cliente();
                        Console.Clear();
                        Console.WriteLine("--Cadastrar Cliente--");
                        Console.WriteLine("Insira o nome do cliente: ");
                        //c.setNome(Console.ReadLine());
                        c.Nome = Console.ReadLine();
                        //Console.WriteLine(c.getNome());
                        Console.WriteLine(c.Nome);
                        Console.WriteLine("Insira o CPF do cliente: ");
                        c.Cpf = Console.ReadLine();

                        //clientes.Add(c);
                        d.CadastrarCliente(c);
                        //Chamar o metodo
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("--Listar Cliente--");
                        Console.WriteLine("Os clientes cadastrados são: ");
                        //foreach (Cliente cliente in clientes)
                        //{
                        //    Console.WriteLine("Nome: " + cliente.Nome+ ";Cpf: " + cliente.Cpf);
                        //}
                        for (int i = 0; i < clientes.Count; i++)
                        {
                            Console.WriteLine("Nome: " + clientes[i].Nome);
                            Console.WriteLine("Cpf: " + clientes[i].Cpf);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("--Cadastrar Vendedor--");
                        Console.WriteLine("Insira seu nome: ");
                        Console.WriteLine("Insira seu CPF: ");

                        break;
                    case 4:
                        Console.WriteLine("Os vendedores cadastrados são: ");

                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;




                        
                }
                Console.ReadKey();
            } while (op != 0) ;


                
            
        }
    }
}
