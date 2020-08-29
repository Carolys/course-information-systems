using Prova.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.DAO
{
    class AlunoTurmaDAO
    {
        private static Context ctx = SingletonContext.GetInstanceContext();
        public static bool CadastrarAluno(AlunoTurma at)
        {
            ctx.Alunos.Add(at);
            ctx.SaveChanges();
            return true;
        }


   }
}
