using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Model
{
    class Pessoa : BaseModel
    {

        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public int Matricula { get; set; }
    }
}
