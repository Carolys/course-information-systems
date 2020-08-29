using BancoDadosOsorioA.DAL;
using BancoDadosOsorioA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.View
{
    class BuscarCarroPorModelo
    {
        public static void Executar()
        {
            Carro c = new Carro();
            Console.Clear();
            Console.WriteLine(" -- BUSCAR CARRO POR MODELO -- \n");
            Console.WriteLine("Digite o modelo do carro:");
            c.Modelo = Console.ReadLine();
            c = CarroDAO.BuscarCarroPorModelo(c);
            if (c != null)
            {
                Console.WriteLine("Modelo: " + c.Modelo);
                Console.WriteLine("Fabricação: " + c.DataFabricacao.ToShortDateString());
            }
            else
            {
                Console.WriteLine("Esse carro não existe!");
            }
        }
    }
}
