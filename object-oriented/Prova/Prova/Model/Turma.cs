using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Model
{
    class Turma : BaseModel
    {
        public string Nome { get; set; }
        public Professor Professor { get; set; }
        public List<AlunoTurma> Alunos { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
