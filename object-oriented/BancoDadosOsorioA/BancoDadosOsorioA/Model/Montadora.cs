using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.Model
{
    [Table("Montadoras")]
    class Montadora
    {
        [Key]
        public int MontadoraId { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public List<Carro> Carros { get; set; }
    }
}
