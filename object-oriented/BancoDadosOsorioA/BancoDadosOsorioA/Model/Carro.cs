using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.Model
{
    //Anotação que define o nome da tabela no BD
    [Table("Carros")]
    class Carro 
    {
        public Carro()
        {
            Montadora = new Montadora();
        }
        //Anotação que define a chave primária na tabela
        [Key]
        public int IdPessoa { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public DateTime DataFabricacao { get; set; }
        public double Peso { get; set; }
        public Montadora Montadora { get; set; }
        //[Required]
        //[MaxLength(50)]
    }
}
