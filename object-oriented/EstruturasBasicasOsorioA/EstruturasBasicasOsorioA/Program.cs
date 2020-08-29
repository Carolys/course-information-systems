using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasBasicasOsorioA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir mensagem no console
            Console.WriteLine("Digite o seu nome:");
            //Comando que faz leitura do teclado
            string nome = Console.ReadLine();
            Console.WriteLine("Nome digitado: " + nome);

            Console.WriteLine("Digite a sua idade:");
            //Converter tipos primitivos
            //int idade = int.Parse(Console.ReadLine());
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Idade digitada: " + idade);

            //Console.WriteLine(idade > 18 ? "Maior" : "Menor");

            if (idade >= 18)
            {
                Console.WriteLine("Maior");
            }
            else
            {
                Console.WriteLine("Menor");
            }

            Console.WriteLine("\nAperte uma tecla para continuar...");
            //Comando que espera uma tecla ser pressionada
            Console.ReadKey();
        }
    }
}
