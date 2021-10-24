using System;

namespace exercicio_4
{
    class Program
    {
        // Faça um algoritmo que receba três números inteiros quaisquer e os apresenta em ordem decrescente. *

        static void Main(string[] args)
        {

            Console.Write("Entre com o numero 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Entre com o numero 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Entre com o numero 3: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} - {1} - {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} - {1} - {2}", a, c, b);
                }
            } else if (b > a && b > c)
                {
                if (a > c)
                {
                    Console.WriteLine("{0} - {1} - {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} - {1} - {2}", b, c, a);
                }
            } else
                {
                if (a > b)
                {
                    Console.WriteLine("{0} - {1} - {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0} - {1} - {2}", c, b, a);
                }
            }

            Console.ReadKey();
        }
    }
}
