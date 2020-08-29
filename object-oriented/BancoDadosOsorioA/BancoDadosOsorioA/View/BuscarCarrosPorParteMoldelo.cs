using BancoDadosOsorioA.DAL;
using BancoDadosOsorioA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.View
{
    class BuscarCarrosPorParteMoldelo
    {
        public static void Executar()
        {
            Carro c = new Carro();
            Console.Clear();
            Console.WriteLine(" -- BUSCAR CARROS POR PARTE MODELO -- \n");
            Console.WriteLine("Digite o modelo do carro:");
            c.Modelo = Console.ReadLine();
            foreach (Carro carroCadastrado in CarroDAO.BuscarCarrosPorParteModelo(c))
            {
                Console.WriteLine("Modelo: " + carroCadastrado.Modelo);
                Console.WriteLine("Fabricação: " +
                    carroCadastrado.DataFabricacao.ToShortDateString());

            }
        }
    }
}
