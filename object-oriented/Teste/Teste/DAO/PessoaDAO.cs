using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Model;

namespace Teste.DAO
{
    class PessoaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static bool CadastrarAluno(Aluno aluno)
        {
            if (BuscarAluno(aluno) != null)
            {
                return false;
            }
            ctx.Pessoas.Add(aluno);
            ctx.SaveChanges();
            return true;
        }
        public static Aluno BuscarAluno(Aluno aluno)
        {
            return ctx.Pessoas.OfType<Aluno>().FirstOrDefault(x => x.Matricula.Equals(aluno.Matricula));
        }

        public static bool CadastrarProfessor(Professor professor)
        {
            if (BuscarProfessor(professor) != null)
            {
                return false;
            }
            ctx.Pessoas.Add(professor);
            ctx.SaveChanges();
            return true;
        }
        public static Professor BuscarProfessor(Professor professor)
        {
            return ctx.Pessoas.OfType<Professor>().FirstOrDefault(x => x.Matricula.Equals(professor.Matricula));
        }
    }
}
