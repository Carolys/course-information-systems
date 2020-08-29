using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioA.DAL;
using VendasOsorioA.Model;
using VendasOsorioA.Utils;

namespace VendasOsorioA.View
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c;
            Vendedor v;
            Produto p;
            Venda venda;
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine(" -- VENDAS -- ");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Cadastrar Vendedores");
                Console.WriteLine("4 - Listar Vendedores");
                Console.WriteLine("5 - Cadastrar Produtos");
                Console.WriteLine("6 - Listar Produtos");
                Console.WriteLine("7 - Realizar Venda");
                Console.WriteLine("8 - Listar Vendas");
                Console.WriteLine("9 - Listar Venda por Cliente");
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
                        Validar.Cpf(c.Cpf);
                        if (Validar.Cpf(c.Cpf))
                        {
                            if (ClienteDAO.CadastrarCliente(c))
                            {
                                Console.WriteLine("Cliente cadastrado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Cliente já existente!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("CPF inválido!");
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" -- LISTAR CLIENTE -- \n");
                        foreach (Cliente clienteCadastrado in ClienteDAO.RetornarClientes())
                        {
                            Console.WriteLine("Nome: " + clienteCadastrado.Nome);
                            Console.WriteLine("CPF: " + clienteCadastrado.Cpf);
                        }
                        break;
                    case 3:
                        v = new Vendedor();
                        Console.Clear();
                        Console.WriteLine("  -- CADASTRAR VENDEDOR -- \n");
                        Console.WriteLine("Digite o nome do vendedor:");
                        v.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do vendedor:");
                        v.Cpf = Console.ReadLine();
                        if (VendedorDAO.CadastrarVendedor(v))
                        {
                            Console.WriteLine("Vendedor cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Vendedor já existente!");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("  -- LISTAR VENDEDORES -- \n");
                        foreach (Vendedor vendedorCadastrado in VendedorDAO.RetornarVendedores())
                        {
                            Console.WriteLine("Nome: " + vendedorCadastrado.Nome);
                            Console.WriteLine("CPF: " + vendedorCadastrado.Cpf + "\n");
                        }
                        break;
                    case 5:
                        p = new Produto();
                        Console.Clear();
                        Console.WriteLine("  -- CADASTRAR PRODUTO -- \n");
                        Console.WriteLine("Digite o nome do produto:");
                        p.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o preço do produto:");
                        p.Preco = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a quantidade do produto:");
                        p.Quantidade = Convert.ToInt32(Console.ReadLine());
                        if (ProdutoDAO.CadastrarProduto(p))
                        {
                            Console.WriteLine("Produto cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Produto já existente!");
                        }
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("  -- LISTAR PRODUTOS -- \n");
                        foreach (Produto produtoCadastrado in ProdutoDAO.RetornarProdutos())
                        {
                            Console.WriteLine("Nome: " + produtoCadastrado.Nome);
                            Console.WriteLine("Preço: " + produtoCadastrado.Preco.ToString("C2"));
                            Console.WriteLine("Quantidade: " + produtoCadastrado.Quantidade + "\n");
                        }
                        break;
                    case 7:
                        venda = new Venda();
                        Console.Clear();
                        Console.WriteLine("  -- REALIZAR VENDA -- \n");

                        Console.WriteLine("Digite o CPF do vendedor:");
                        venda.Vendedor.Cpf = Console.ReadLine();
                        venda.Vendedor = VendedorDAO.BuscarVendedorPorCpf(venda.Vendedor);
                        if (venda.Vendedor != null)
                        {

                            Console.WriteLine("Digite o CPF do cliente:");
                            venda.Cliente.Cpf = Console.ReadLine();
                            venda.Cliente = ClienteDAO.BuscarClientePorCpf(venda.Cliente);
                            if (venda.Cliente != null)
                            {

                                Console.WriteLine("Digite o nome produto:");
                                venda.Produto.Nome = Console.ReadLine();
                                venda.Produto = ProdutoDAO.BuscarProdutoPorNome(venda.Produto);
                                if(venda.Produto != null)
                                {

                                    Console.WriteLine("Digite a quantidade:");
                                    venda.Quantidade = Convert.ToInt32(Console.ReadLine());
                                    venda.Data = DateTime.Now;
                                    VendaDAO.CadastrarVenda(venda);
                                    Console.WriteLine("Venda realizada com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("Produto não cadastrado!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Cliente não cadastrado!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vendedor não cadastrado!");
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