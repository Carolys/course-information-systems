using Prova.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.DAO
{
    class TurmaDAO
    {
        private static Context ctx = SingletonContext.GetInstanceContext();
        public static bool CadastrarTurma(Turma turma)
        {
            if (BuscarTurmaPorNome(turma) != null)
            {
                return false;
            }
            ctx.Turmas.Add(turma);
            ctx.SaveChanges();
            return true;
        }
        public static Turma BuscarTurmaPorNome(Turma turma)
        {
            return ctx.Turmas.FirstOrDefault(x => x.Nome.Equals(turma.Nome));
        }
        public static Turma BuscarTurmaPorProf(Turma turma)
        {
            return ctx.Turmas.FirstOrDefault(x => x.Professor.Equals(turma.Professor));
        }

    }
}
