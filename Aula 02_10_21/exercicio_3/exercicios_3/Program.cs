using System;

namespace exercicio_3
{
    class Program
    {
        // Escreva um programa que imprima os números entre 1000 e 1999 *

         static void Main(string[] args)
         {

            for (int i = 1000; i <= 1999; i++)
            {
                Console.WriteLine("{0}", i);
            }

            Console.ReadKey();
        }
    }
}
