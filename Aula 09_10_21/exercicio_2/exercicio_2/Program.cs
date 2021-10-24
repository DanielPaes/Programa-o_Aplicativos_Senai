using System;

namespace exercicio_2
{
    class Program
    {
        /*Faça um programa que leia valores inteiros do usuário
         * até que seja digitado dois números iguais. 
         * Deve-se retornar a soma dos valores lidos 
        */

        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;

            while (true)
            {
                Console.WriteLine("Entre com o 1º número:");
                n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com o 2º número:");
                n2 = int.Parse(Console.ReadLine());

                if (n1 == n2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nNúmeros diferentes. Entre com números iguais.\n");
                }
            }

            Console.WriteLine("\nA soma dos valores é {0}", n1 + n2);
        }
    }
}
