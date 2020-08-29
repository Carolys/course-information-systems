using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Model
{
    class Aluno : Pessoa
    {
        public string Telefone { get; set; }
    }
}
