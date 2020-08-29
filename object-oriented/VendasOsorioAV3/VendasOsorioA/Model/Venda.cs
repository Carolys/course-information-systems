using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioA.Model
{
    class Venda
    {
        //public Venda(string nome)
        //{

        //}
        public Venda()
        {
            Data = DateTime.Now;
            Quantidade = 1;
            Produto = new Produto();
            Cliente = new Cliente();
            Vendedor = new Vendedor();
        }

        public List<ItemVenda> Produtos { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
    }
}
