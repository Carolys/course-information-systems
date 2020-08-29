using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Model
{
    [Table("Pessoas")]
    class Pessoa : BaseModel
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Matricula { get; set; }
    }
}
