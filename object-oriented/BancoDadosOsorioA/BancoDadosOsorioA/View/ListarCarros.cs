using BancoDadosOsorioA.DAL;
using BancoDadosOsorioA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.View
{
    class ListarCarros
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine(" -- LISTAR CARROS -- \n");
            foreach (Carro carroCadastrado in CarroDAO.ListarCarros())
            {
                Console.WriteLine("Modelo: " + carroCadastrado.Modelo);
                Console.WriteLine("Fabricação: " + 
                    carroCadastrado.DataFabricacao.ToShortDateString());

            }
        }
    }
}
