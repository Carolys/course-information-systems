using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Model
{
    class Context : DbContext
    {
        public Context() : base("BancoTeste") { }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<AlunoTurma> AlunosTurma { get; set; }
        public DbSet<Turma> Turmas { get; set; }

    }
}
