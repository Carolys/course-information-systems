using BancoDadosOsorioA.DAL;
using BancoDadosOsorioA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.View
{
    class CadastrarMontadora
    {
        public static void Executar()
        {
            Montadora m = new Montadora();
            Console.Clear();
            Console.WriteLine(" -- CADASTRAR MONTADORA -- \n");
            Console.WriteLine("Digite o nome do carro:");
            m.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CNPJ do carro:");
            m.Cnpj = Console.ReadLine();
            MontadoraDAO.CadastrarMontadora(m);
            Console.WriteLine("Montadora salva com sucesso!");
        }
    }
}
