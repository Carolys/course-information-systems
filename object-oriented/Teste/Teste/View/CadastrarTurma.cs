using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.DAO;
using Teste.Model;

namespace Teste.View
{
    class CadastrarTurma
    {
        public static void Executar()
        {
            string op = "s";
            AlunoTurma at;
            Turma t = new Turma();

            Console.Clear();
            Console.WriteLine(" -- CADASTRAR TURMA -- \n");

            Console.WriteLine("Digite o nome: ");
            t.Nome = Console.ReadLine();
            Console.WriteLine("Digite a matricula do professor: ");
            t.Professor.Matricula = Console.ReadLine();
            t.Professor = PessoaDAO.BuscarProfessor(t.Professor);
            if (t.Professor != null)
            {
                do
                {
                    Console.Clear();
                    at = new AlunoTurma();

                    Console.WriteLine("Digite a matricula do aluno: ");
                    at.Aluno.Matricula = Console.ReadLine();
                    at.Aluno = PessoaDAO.BuscarAluno(at.Aluno);
                    if (at.Aluno != null)
                    {
                        t.Alunos.Add(at);
                    }
                    else
                    {
                        Console.Write("Aluno não cadastrado! ");
                    }
                    Console.Write("Deseja adicionar mais alunos? ");
                    op = Console.ReadLine();
                } while (op == "s");

                t.DataCadastro = DateTime.Now;
                if (TurmaDAO.CadastrarTurma(t))
                {
                    Console.Write("Turma cadastrada com sucesso! ");
                }
                else
                {
                    Console.Write("Erro ao cadastrar a turma! ");
                }
            }
            else
            {
                Console.Write("Professor não cadastrado! ");
            }


            Console.ReadKey();
        }
    }
}
