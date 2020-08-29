using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Model
{
    class AlunoTurma : BaseModel
    {
        public Aluno Aluno { get; set; }
    }
}
