using BancoDadosOsorioA.DAL;
using BancoDadosOsorioA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.View
{
    class RemoverCarro
    {
        public static void Executar()
        {
            Carro c = new Carro();
            Console.Clear();
            Console.WriteLine(" -- REMOVER CARRO POR MODELO -- \n");
            Console.WriteLine("Digite o modelo do carro:");
            c.Modelo = Console.ReadLine();
            c = CarroDAO.BuscarCarroPorModelo(c);
            if (c != null)
            {
                Console.WriteLine("Modelo: " + c.Modelo);
                Console.WriteLine("Fabricação: " + c.DataFabricacao.ToShortDateString());
                Console.WriteLine("\nDeseja remover o carro? (S/N)");
                if (Console.ReadLine().ToUpper().Equals("S"))
                {
                    c = new Carro();
                    //Chamar o método no DAO que remove o carro
                    CarroDAO.RemoverCarro(c);
                    Console.WriteLine("Carro removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Operação cancelada!");
                }
            }
            else
            {
                Console.WriteLine("Esse carro não existe!");
            }
        }
    }
}
