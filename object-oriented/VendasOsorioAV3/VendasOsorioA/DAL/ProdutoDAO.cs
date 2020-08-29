using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioA.Model;

namespace VendasOsorioA.DAL
{
    class ProdutoDAO
    {
        private static List<Produto> produtos = new List<Produto>();

        public static bool CadastrarProduto(Produto produto)
        {
            if (BuscarProdutoPorNome(produto) != null)
            {
                return false;
            }
            produtos.Add(produto);
            return true;
        }
        public static Produto BuscarProdutoPorNome(Produto produto)
        {
            foreach (Produto produtoCadastrado in produtos)
            {
                if (produtoCadastrado.Nome.Equals(produto.Nome))
                {
                    return produtoCadastrado;
                }
            }
            return null;
        }

        public static List<Produto> RetornarProdutos()
        {
            return produtos;
        }
    }
}
