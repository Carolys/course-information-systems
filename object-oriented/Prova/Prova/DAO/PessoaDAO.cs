using Prova.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.DAO
{
    class PessoaDAO
    {
        private static Context ctx = SingletonContext.GetInstanceContext();
        public static bool CadastrarPessoa(Pessoa pessoa)
        {
            if (BuscarPessoaPorMatricula(pessoa) != null)
            {
                return false;
            }
            ctx.Pessoas.Add(pessoa);
            ctx.SaveChanges();
            return true;
        }


        public static Professor BuscarProfPorMatricula(Pessoa pessoa)
        {
            return ctx.Pessoas.OfType<Professor>().FirstOrDefault(x => x.Matricula.Equals(pessoa.Matricula));
        }

        public static Pessoa BuscarPessoaPorMatricula(Pessoa pessoa)
        {
            return ctx.Pessoas.FirstOrDefault(x => x.Matricula.Equals(pessoa.Matricula));
        }
        public static Aluno BuscarAluPorNome(Pessoa pessoa)
        {
            return ctx.Pessoas.OfType<Aluno>().FirstOrDefault(x => x.Nome.Equals(pessoa.Nome));
        }
        public static Aluno BuscarAluPorMat(Pessoa pessoa)
        {
            return ctx.Pessoas.OfType<Aluno>().FirstOrDefault(x => x.Matricula.Equals(pessoa.Matricula));
        }
        public static Pessoa BuscarPessoaPorNome(Pessoa pessoa)
        {
            return ctx.Pessoas.FirstOrDefault(x => x.Nome.Equals(pessoa.Nome));
        }
        public static List<Aluno> ListarAlunos()
        {
            return ctx.Pessoas.OfType<Aluno>().ToList();
        }
        public static List<Professor> ListarProf()
        {
            return ctx.Pessoas.OfType<Professor>().ToList();
        }



    }
}
