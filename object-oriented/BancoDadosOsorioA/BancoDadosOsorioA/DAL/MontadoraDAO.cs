using BancoDadosOsorioA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.DAL
{
    class MontadoraDAO
    {
        private static Context ctx = new Context();

        public static void CadastrarMontadora(Montadora m)
        {
            ctx.Montadoras.Add(m);
            ctx.SaveChanges();
        }

        public static Montadora BuscarMontadoraPorNome(Montadora m)
        {
            return ctx.Montadoras.FirstOrDefault(x => x.Nome.Equals(m.Nome));
        }
    }
}
