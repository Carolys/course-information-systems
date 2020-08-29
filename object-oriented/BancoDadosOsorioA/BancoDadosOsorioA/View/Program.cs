using BancoDadosOsorioA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.View
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 10;
            do
            {
                Console.Clear();
                Console.WriteLine(" -- BANCO DE DADOS -- \n");
                Console.WriteLine("1 - Cadastrar Carro");
                Console.WriteLine("2 - Listar Carros");
                Console.WriteLine("3 - Buscar Carro por Modelo");
                Console.WriteLine("4 - Buscar Carros por parte do modelo");
                Console.WriteLine("5 - Remover Carro");
                Console.WriteLine("6 - Alterar Carro");
                Console.WriteLine("7 - Cadastrar Montadora");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Escolha uma opção:");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        CadastrarCarro.Executar();
                        break;
                    case 2:
                        ListarCarros.Executar();
                        break;
                    case 3:
                        BuscarCarroPorModelo.Executar();
                        break;
                    case 4:
                        BuscarCarrosPorParteMoldelo.Executar();
                        break;
                    case 5:
                        RemoverCarro.Executar();
                        break;
                    case 6:
                        AlterarCarro.Executar();
                        break;
                    case 7:
                        CadastrarMontadora.Executar();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida...");
                        break;
                }
                Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (op != 0);
        }
    }
}
