using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Model
{
    [Table("Turmas")]
    class Turma : BaseModel
    {
        public Turma()
        {
            Professor = new Professor();
            Alunos = new List<AlunoTurma>();
        }
        public string Nome { get; set; }
        public Professor Professor { get; set; }
        public List<AlunoTurma> Alunos { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
