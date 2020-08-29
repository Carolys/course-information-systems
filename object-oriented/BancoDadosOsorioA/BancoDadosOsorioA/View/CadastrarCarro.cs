using BancoDadosOsorioA.DAL;
using BancoDadosOsorioA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.View
{
    class CadastrarCarro
    {
        public static void Executar()
        {
            Carro c = new Carro();
            Console.Clear();
            Console.WriteLine(" -- CADASTRAR CARRO -- \n");
            Console.WriteLine("Digite o modelo do carro:");
            c.Modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano do carro:");
            c.Ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a cor do carro:");
            c.Cor = Console.ReadLine();
            Console.WriteLine("Digite a data de fabricação do carro:");
            c.DataFabricacao = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite o peso do carro:");
            c.Peso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a montadora do carro:");
            c.Montadora.Nome = Console.ReadLine();
            c.Montadora = MontadoraDAO.BuscarMontadoraPorNome(c.Montadora);
            if (c.Montadora != null)
            {
                CarroDAO.CadastrarCarro(c);
                Console.WriteLine("Carro salvo com sucesso!");
            }
            else
            {
                Console.WriteLine("Essa montadora não existe!");
            }

        }
    }
}
