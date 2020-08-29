using BancoDadosOsorioA.DAL;
using BancoDadosOsorioA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.View
{
    class AlterarCarro
    {
        public static void Executar()
        {
            Carro c = new Carro();
            Console.Clear();
            Console.WriteLine(" -- ALTERAR CARRO POR MODELO -- \n");
            Console.WriteLine("Digite o modelo do carro:");
            c.Modelo = Console.ReadLine();
            c = CarroDAO.BuscarCarroPorModelo(c);
            if (c != null)
            {
                Console.WriteLine("Modelo: " + c.Modelo);
                Console.WriteLine("Fabricação: " + c.DataFabricacao.ToShortDateString());
                Console.WriteLine("\nDeseja alterar o carro? (S/N)");
                if (Console.ReadLine().ToUpper().Equals("S"))
                {
                    Console.WriteLine(" -- DADOS PARA ALTERAR -- \n");
                    Console.WriteLine("Digite a cor do carro:");
                    c.Cor = Console.ReadLine();
                    Console.WriteLine("Digite o peso do carro:");
                    c.Peso = Convert.ToInt32(Console.ReadLine());
                    CarroDAO.AlterarCarro(c);
                    Console.WriteLine("Carro alterado com sucesso!");
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
