using Prova.DAO;
using Prova.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 10;
            do
            {
                Console.Clear();
                Console.WriteLine("– Menu –");
                Console.WriteLine("1 – Cadastrar Aluno");
                Console.WriteLine("2 – Cadastrar Professor");
                Console.WriteLine("3 – Cadastrar Turma");
                Console.WriteLine("4 – Listar Turma");
                Console.WriteLine("0 – Sair");
                Console.Write("Resposta: ");
                op = Convert.ToInt32(Console.ReadLine());
                string data = "";
                Aluno a = new Aluno();
                Professor p = new Professor();
                Turma t = new Turma();
                AlunoTurma at = new AlunoTurma();
                List<AlunoTurma> ats = new List<AlunoTurma>();
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("– Cadastrar Aluno –");

                        Console.Write("– Nome do Aluno: ");
                        a.Nome = Console.ReadLine();
                        Console.Write("– Data de Nascimento (dd/MM/yyyy): ");

                        data = Console.ReadLine();
                        DateTime.ParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        a.DataNasc = DateTime.Parse(data);
                        Console.Write("– Matricula: ");
                        a.Matricula = Convert.ToInt32(Console.ReadLine());
                        Console.Write("– Telefone: ");
                        a.Telefone = Console.ReadLine();

                        if (PessoaDAO.CadastrarPessoa(a))
                        {

                            Console.WriteLine("Aluno cadastrado com sucesso");
                        }
                        else
                        {
                            Console.Write("Aluno já cadastrado ");
                        }

                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("– Cadastrar Professor –");

                        Console.Write("– Nome do Professor: ");
                        p.Nome = Console.ReadLine();
                        Console.Write("– Data de Nascimento: ");

                        data = Console.ReadLine();
                        DateTime.ParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        p.DataNasc = DateTime.Parse(data);
                        Console.Write("– Matricula: ");
                        p.Matricula = Convert.ToInt32(Console.ReadLine());
                        Console.Write("– Disciplina: ");
                        p.Disciplina = Console.ReadLine();

                        if (PessoaDAO.CadastrarPessoa(p))
                        {

                            Console.WriteLine("Professor cadastrado com sucesso");
                        }
                        else
                        {
                            Console.Write("Professor já cadastrado ");
                        }

                        Console.ReadKey();
                        break;

                    case 3:
                        
                        Console.Clear();
                        Console.WriteLine("– Cadastrar Turma –");

                        string op1 = "s";
                        if (PessoaDAO.ListarAlunos() != null)
                        {
                            Console.Write("– Nome da Turma: ");
                            t.Nome = Console.ReadLine();
                            if (TurmaDAO.BuscarTurmaPorNome(t) == null)
                            {
                                Console.Write("– Matricula do Professor: ");
                                p.Matricula = Convert.ToInt32(Console.ReadLine());
                                if (PessoaDAO.BuscarPessoaPorMatricula(p) != null)
                                {
                                    p = PessoaDAO.BuscarProfPorMatricula(p);
                                    t.Professor = p;
                                    do
                                    {
                                        Console.Write("– Nome do Aluno: ");
                                        a.Nome = Console.ReadLine();
                                        if (PessoaDAO.BuscarPessoaPorNome(a) != null)
                                        {
                                            a = PessoaDAO.BuscarAluPorNome(a);
                                            at.Aluno = a;

                                            ats.Add(at);

                                        }
                                        else
                                        {
                                            Console.Write("Aluno nao cadastrado ");
                                        }
                                        Console.Write("Deseja adicionar mais um aluno? ");
                                        op1 = Console.ReadLine();
                                    } while (op1 == "s");
                                    t.Alunos = ats;
                                    t.DataCadastro = DateTime.Now;

                                    if (TurmaDAO.CadastrarTurma(t))
                                    {
                                        t = TurmaDAO.BuscarTurmaPorNome(t);

                                        Console.Write("Turma cadastrada com sucesso ");
                                    }
                                    else
                                    {
                                        Console.Write("Turma já cadastrada ");
                                    }

                                }
                                else
                                {
                                    Console.Write("Turma já cadastrada ");
                                }
                            }
                        }else
                        {
                            Console.Write("Nao ha alunos cadastrados! ");
                        }

                        Console.ReadKey();
                        break;


                    case 4:
                        Console.Clear();
                        Console.WriteLine("– Listar Turma –");

                        Console.Write("Turma: ");
                        t.Nome = Console.ReadLine();
                        t = TurmaDAO.BuscarTurmaPorNome(t);

                        ats = t.Alunos;
                        p = t.Professor;
                        Console.WriteLine("Professor: " + p.Nome);
                        Console.WriteLine("Disciplina: " + p.Disciplina);
                        Console.WriteLine("Data do Cadastro: " + t.DataCadastro);

                        Console.WriteLine("--Alunos-- ");
                        foreach (AlunoTurma aluno in ats)
                        {
                            Console.WriteLine("Nome: " + aluno.Aluno.Nome + "| Matricula: " + aluno.Aluno.Matricula);

                        }

                        Console.ReadKey();
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }
                Console.ReadKey();
            } while (op != 0);
        }
    }
}
