using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Model
{
    class Context : DbContext
    {
        public Context() : base("BancoProva")
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<AlunoTurma> Alunos { get; set; }

    }
}
