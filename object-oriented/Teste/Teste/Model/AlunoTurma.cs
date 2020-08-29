using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Model
{
    [Table("AlunosTurma")]
    class AlunoTurma : BaseModel
    {
        public AlunoTurma()
        {
            Aluno = new Aluno();
        }
        public Aluno Aluno { get; set; }
    }
}
