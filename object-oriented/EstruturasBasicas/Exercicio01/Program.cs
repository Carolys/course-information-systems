using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = "s";
            while (op == "s")
            {
                Console.WriteLine("Escolha uma opçao: ");
                Console.WriteLine("1 - Par/Ímpar: ");
                Console.WriteLine("2 - Intervalo entre dois números: ");
                Console.WriteLine("3 - Sorteador: ");
                Console.WriteLine("4 - Bhaskara: ");
                Console.WriteLine("5 - Fibonacci: ");
                Console.WriteLine("6 - Bubble Sort: \n");
                int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite um número: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        if ((numero % 2) == 0)
                        {
                            Console.WriteLine("O número digitado é par");
                        }
                        else
                        {
                            Console.WriteLine("O número digitado é ímpar");
                        }
                        Console.ReadKey();
                        Console.WriteLine("Deseja continuar?\n");
                        op = Console.ReadLine();
                        break;
                    case 2:

                        Console.WriteLine("Digite o primeiro número: ");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("O intervalo entre os valores é: ");
                        if (n1 < n2)
                        {
                            for (int i = n1; i <= n2; i++)
                            {
                                Console.Write(i + ",");
                            }
                            Console.ReadKey();
                            Console.WriteLine("Deseja continuar?\n");
                            op = Console.ReadLine();
                        }
                        else
                        {
                            for (int i = n1; i >= n2; i--)
                            {
                                Console.Write(i + ",");
                            }
                            Console.ReadKey();
                            Console.WriteLine("Deseja continuar?\n");
                            op = Console.ReadLine();
                        }
                        break;
                    case 3:
                        int s1 = 0, s2 = 0, s3 = 0, s4 = 0, s5 = 0, s6 = 0, nsorteado;
                        double p1, p2, p3, p4, p5, p6;
                        Random r = new Random();
                        for (int i = 0; i < 9999; i++)
                        {

                            nsorteado = r.Next(1, 7);
                            //Console.Write(r.Next(6) + 1);
                            switch (nsorteado)
                            {
                                case 1:
                                    s1 += 1;
                                    break;
                                case 2:
                                    s2 += 1;
                                    break;
                                case 3:
                                    s3 += 1;
                                    break;
                                case 4:
                                    s4 += 1;
                                    break;
                                case 5:
                                    s5 += 1;
                                    break;
                                case 6:
                                    s6 += 1;
                                    break;

                            }

                        }
                        p1 = (double)(s1) / 10000;
                        p2 = (double)(s2 * 100) / 10000;
                        p3 = (double)(s3 * 100) / 10000;
                        p4 = (double)(s4 * 100) / 10000;
                        p5 = (double)(s5 * 100) / 10000;
                        p6 = (double)(s6 * 100) / 10000;
                        Console.WriteLine("Número 1: " + p1.ToString("P2"));
                        Console.WriteLine("Número 2: " + p2);
                        Console.WriteLine("Número 3: " + p3);
                        Console.WriteLine("Número 4: " + p4);
                        Console.WriteLine("Número 5: " + p5);
                        Console.WriteLine("Número 6: " + p6);

                        Console.ReadKey();
                        Console.WriteLine("Deseja continuar?\n");
                        op = Console.ReadLine();


                        break;
                    case 4:
                        //1,8,-9
                        Console.WriteLine("Digite o valor de a: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o valor de b: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o valor de c: ");
                        double c = Convert.ToDouble(Console.ReadLine());


                        double x1 = ((-b + (Math.Sqrt(b * b - (4.0 * a * c)))) / (2 * a));
                        double x2 = ((-b - (Math.Sqrt(b * b - (4.0 * a * c)))) / (2 * a));

                        Console.Write("\nO x'= " + x1 + "\nO x''= " + x2);

                        Console.ReadKey();
                        Console.WriteLine("Deseja continuar?\n");
                        op = Console.ReadLine();
                        break;
                    case 5:
                        int b1 = 1;
                        int b2 = 1;
                        int b3 = 0;
                        Console.Write("A sequência de Fibonacci é: ");
                        for (int i = 0; i < 9; i++)
                        {
                            b3 = b1 + b2;
                            Console.Write(b3 + ",");
                            b1 = b2;
                            b2 = b3;
                        }
                        Console.ReadKey();
                        Console.WriteLine("Deseja continuar?\n");
                        op = Console.ReadLine();
                        break;
                    case 6:
                        int[] v = new int[10];
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.Write("Digite um número: ");
                            v[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.ReadKey();
                        Console.WriteLine("Deseja continuar?\n");
                        op = Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
            

        }
    }
}
