using FolhaDePagamento.DAO;
using FolhaDePagamento.Model;
using FolhaDePagamento.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento
{
    class Program
    {


        /*
         * 
         * Nomes: Camila Rody , Carolina Yasue, Matheus Lourenço
         * 
         */




        static void Main(string[] args)
        {

            int escolha = 10;
            do
            {
                Console.Clear();
                Console.WriteLine("1 Cadastrar Funcionário --");
                Console.WriteLine("2 Cadastrar Folha de Pagamento --");
                Console.WriteLine("3 Consultar Folha de Pagamento --");
                Console.WriteLine("4 Listar Folhas de Pagamento --");
                Console.WriteLine("0 Sair --");


                escolha = Convert.ToInt32(Console.ReadLine());
                switch (escolha)
                {

                    case 1:
                        Funcionario c = new Funcionario();
                        Console.Clear();
                        Console.WriteLine("-- Cadastrar Funcionário --");
                        Console.Write("Nome do funcionário : ");
                        c.nome = Console.ReadLine();
                        Console.Write("Cpf do funcionário : ");
                        c.cpf = Console.ReadLine();
                        if (true || ValidarCpf.Cpf(c.cpf))
                        {
                            if (FuncionarioDAO.CadastrarFuncionario(c))
                            {
                                Console.WriteLine("\nFuncionário cadastrado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("\nFuncionário já existente!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nCPF inválido!");
                        }

                        //Console.WriteLine(c.nome+"   "+c.cpf);



                        break;
                    case 2:
                        FolhaPagamento fp = new FolhaPagamento();
                        Funcionario f = new Funcionario();
                        Console.Clear();
                        Console.WriteLine("-- Cadastrar Folha de Pagamento --");
                        Console.Write("Cpf do funcionário : ");
                        string cpfusuario = Console.ReadLine();
                        f.cpf = cpfusuario;
                        f = FuncionarioDAO.BuscarFuncionarioPorCpf(f);
                        if (f == null)
                        {
                            Console.Write("\nCpf não cadastrado!");
                        }

                        Console.Write("Mês do funcionário : ");
                        fp.mes = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ano do funcionário : ");
                        fp.ano = Convert.ToInt32(Console.ReadLine());

                        if (null == FolhaDePagamentoDAO.foiDeclarado(f.cpf, fp.mes, fp.ano))
                        {
                            Console.Write("Horas Trabalhadas do funcionário : ");
                            fp.horastrabralhadas = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Valor da Hora : ");
                            fp.valorhora = Convert.ToDouble(Console.ReadLine());

                            if (FolhaDePagamentoDAO.Cadastrar(fp, f))
                            {
                                Console.Write("Folha de Pagamento cadastrada com sucesso!");
                            }
                            else
                            {
                                Console.Write("Ocorreu um erro ao cadastrar a folha de Pagamento.");
                            }

                        }
                        else
                        {
                            Console.Write("Folha de Pagamento já existente nesse CPF");
                        }

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("-- Consultar Folha de Pagamento --");
                        Console.Write("Cpf do funcionário : ");
                        string cpfprocurar = Console.ReadLine();
                        Console.Write("Mês do funcionário : ");
                        int mes = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ano do funcionário : ");
                        int ano = Convert.ToInt32(Console.ReadLine());

                        FolhaDePagamento.Model.FolhaPagamento folhaEncontrada = FolhaDePagamentoDAO.foiDeclarado(cpfprocurar, mes, ano);
                        if (folhaEncontrada != null)
                        {
                            folhaEncontrada.calcular();
                            Console.WriteLine("Folha de pagamento encontrada!");
                            Console.WriteLine("  " + folhaEncontrada.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Folha de pagamento não encontrada.");
                        }

                        break;
                    case 4:
                        Console.WriteLine("-- Listar Folhas de Pagamento --");
                        double totalSalarioLiquido = 0;
                        foreach (FolhaDePagamento.Model.FolhaPagamento pagamento in FolhaDePagamentoDAO.todos())
                        {
                            pagamento.calcular();
                            // soma de salario liquido
                            totalSalarioLiquido += pagamento.salarioLiquido;
                            Console.WriteLine("  " + pagamento.ToString());
                        }
                        Console.WriteLine(" - Salario Liquido Total: R$ " + totalSalarioLiquido);
                        break;
                    case 0:
                        Console.WriteLine("-- Saindo --");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!");
                        break;
                }



                Console.ReadKey();
            } while (escolha != 0);




        }
    }
}
