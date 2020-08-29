using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioA.Model;

namespace VendasOsorioA.DAL
{
    class VendaDAO
    {
        private static List<Venda> vendas = new List<Venda>();

        public static void CadastrarVenda(Venda venda)
        {
            vendas.Add(venda);
        }

        public static List<Venda> RetonarVendas()
        {
            return vendas;
        }
    }
}
