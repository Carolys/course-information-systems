using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioA.Model;

namespace VendasOsorioA.DAL
{
    class VendedorDAO
    {
        private static List<Vendedor> vendedores = new List<Vendedor>();

        public static bool CadastrarVendedor(Vendedor vendedor)
        {
            if(BuscarVendedorPorCpf(vendedor) != null)
            {
                return false;
            }
            vendedores.Add(vendedor);
            return true;
        }

        public static Vendedor BuscarVendedorPorCpf(Vendedor vendedor)
        {
            foreach (Vendedor vendedorCadastrado in vendedores)
            {
                if (vendedorCadastrado.Cpf.Equals(vendedor.Cpf))
                {
                    return vendedorCadastrado;
                }
            }        
            return null;
        }

        public static List<Vendedor> RetornarVendedores()
        {
            return vendedores;
        }
    }
}
