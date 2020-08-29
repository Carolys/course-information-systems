using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.Model
{
    /// <summary>
    /// Representa o EF e o banco de dados dentro do projeto
    /// </summary>
    class Context : DbContext
    {
        //Nomear o banco de dados
        public Context() : base("BancoCarros") { }

        //Mapear as classes que vão virar tabelas no BD
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Montadora> Montadoras { get; set; }
    }
}
