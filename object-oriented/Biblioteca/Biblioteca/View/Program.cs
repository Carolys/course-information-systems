using Biblioteca.DAO;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {

        // Nomes: Matheus Lourenço Stella, Carolina Mayume Yasue, Camila Rody




        static void Main(string[] args)
        {
            int op = 10;
            ;
            do
            {
                Console.Clear();
                Console.WriteLine(" --- MENU ---");
                Console.WriteLine(" 1 – Cadastrar Livro");
                Console.WriteLine(" 2 – Emprestar Livro");
                Console.WriteLine(" 3 – Devolver Livro");
                Console.WriteLine(" 4 – Histórico de movimentação do livro");
                Console.WriteLine(" 5 – Consultar Livro");
                Console.WriteLine(" 0 – Sair");
                Console.Write("Resposta: ");
                op = Convert.ToInt32(Console.ReadLine());

                try
                {
                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Livro l = new Livro();
                            Console.Write("Informe o nome do livro: ");
                            l.Nome = Console.ReadLine();
                            Console.Write("Informe quantidade de paginas do livro: ");
                            l.QuantidadePaginas = Console.ReadLine();
                            l.DataCadastro = DateTime.Now;
                            l.Situacao = true;
                            if (LivroDAO.CadastrarLivro(l))
                            {

                                Console.WriteLine("Livro cadastrado com sucesso! ");
                            }
                            else
                            {
                                Console.WriteLine("Livro já cadastrado!");
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Livro o = new Livro();
                            Movimentacao q = new Movimentacao();
                            Console.Write("Informe o nome do livro: ");
                            o.Nome = Console.ReadLine();
                            if (LivroDAO.VerificarLivro(o))
                            {
                                foreach (Livro i in LivroDAO.RetornarLivros())
                                {
                                    if (i.Nome.Equals(o.Nome))
                                    {

                                        if (i.Situacao == true)
                                        {
                                            Console.Write("Informe o nome o cliente: ");
                                            i.NomeCliente = Console.ReadLine();
                                            i.DataEmprestimo = DateTime.Now;
                                            i.Situacao = false;
                                            q.NomeMovi = i.Nome;
                                            q.SituacaoMovi = i.Situacao;
                                            q.NomeCli = i.NomeCliente;
                                            q.Data = i.DataEmprestimo;
                                            MovimentacaoDAO.CadastrarMovi(q);
                                            Console.WriteLine("Livro emprestado com sucesso!");
                                        }
                                        else
                                        {
                                            Console.Write("Livro já emprestado! ");
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.Write("Livro não encontrado ");
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Movimentacao j = new Movimentacao();
                            Livro k = new Livro();
                            Console.Write("Informe o nome do livro: ");
                            k.Nome = Console.ReadLine();
                            if (LivroDAO.VerificarLivro(k))
                            {
                                foreach (Livro i in LivroDAO.RetornarLivros())
                                {
                                    if (i.Situacao == false && i.Nome.Equals(k.Nome))
                                    {
                                        Console.WriteLine("Deseja realmente devolver? (sim/nao)");
                                        string resp = Console.ReadLine();
                                        if (resp.ToUpper().Equals("SIM"))
                                        {

                                            i.DataDevolução = DateTime.Now;
                                            i.Situacao = true;
                                            j.NomeMovi = i.Nome;
                                            j.NomeCli = i.NomeCliente;
                                            j.SituacaoMovi = i.Situacao;
                                            j.Data = i.DataEmprestimo;
                                            MovimentacaoDAO.CadastrarMovi(j);

                                            Console.WriteLine("Livro devolvido com sucesso!");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Livro não encontrado!");
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Livro p = new Livro();
                            Console.Write("Informe o nome do livro: ");
                            p.Nome = Console.ReadLine();
                            if (LivroDAO.VerificarLivro(p))
                            {
                                foreach (Livro i in LivroDAO.RetornarLivros())
                                {
                                    if (i.Nome.Equals(p.Nome))
                                    {

                                        Console.WriteLine("Nome do livro: " + i.Nome);
                                        Console.WriteLine("Quantidade de páginas: " + i.QuantidadePaginas);
                                        Console.WriteLine("Data de Cadastro: " + i.DataCadastro);
                                        Console.WriteLine(" --- Movimentações --- ");
                                        foreach (Movimentacao ja in MovimentacaoDAO.RetornarMovi())
                                        {
                                            if (ja.NomeMovi.Equals(p.Nome))
                                            {
                                                string evs = "";
                                                if (ja.SituacaoMovi == true)
                                                {
                                                    evs = "Disponível";
                                                }
                                                else
                                                {
                                                    evs = "Emprestado";
                                                }


                                                Console.WriteLine("Tipo: " + evs + " CLiente: " + ja.NomeCli + " Data: " + ja.Data);
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        case 5:

                            Console.Clear();
                            Livro c = new Livro();
                            Console.Write("Informe o nome do livro: ");
                            c.Nome = Console.ReadLine();
                            if (LivroDAO.VerificarLivro(c))
                            {
                                foreach (Livro i in LivroDAO.RetornarLivros())
                                {
                                    if (i.Nome.Equals(c.Nome))
                                    {
                                        string ev = "";
                                        if (i.Situacao == true)
                                        {
                                            ev = "Disponivel";
                                        }
                                        else
                                        {
                                            ev = "Emprestado";
                                        }
                                        Console.WriteLine("Nome do livro: " + i.Nome);
                                        Console.WriteLine("Quantidade de páginas: " + i.QuantidadePaginas);
                                        Console.WriteLine("Situação do livro: " + ev);


                                    }
                                }
                            }
                            break;
                        case 0:
                            Console.WriteLine("Saindo");
                            break;
                        default:
                            Console.WriteLine("Opção Inválida");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Digite apenas números!");
                }
                Console.WriteLine("\nAperte uma tecla para continuar");
                Console.ReadKey();
            } while (op != 0);
        }
    }
}
