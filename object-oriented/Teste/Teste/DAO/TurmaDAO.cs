using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Model;

namespace Teste.DAO
{
    class TurmaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static bool CadastrarTurma(Turma turma)
        {
            if (BuscarTurma(turma) != null)
            {
                return false;
            }
            ctx.Turmas.Add(turma);
            ctx.SaveChanges();
            return true;
        }
        public static Turma BuscarTurma(Turma turma)
        {
            return ctx.Turmas.Include("Professor").Include("Aluno.Aluno").FirstOrDefault(x => x.Nome.Equals(turma.Nome));
        }

    }
}
