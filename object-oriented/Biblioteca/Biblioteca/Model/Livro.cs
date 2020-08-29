using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    class Livro
    {
        public string Nome { get; set; }
        public string QuantidadePaginas { get; set; }
        public bool Situacao { get; set; }
        public DateTime DataCadastro { get; set; }

        public DateTime DataEmprestimo { get; set; }

        public DateTime DataDevolução { get; set; }
        public string NomeCliente { get; set; }

        

    }
}
