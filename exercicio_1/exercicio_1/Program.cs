using System;

namespace exercicio_1
{
    class Program
    {
        /*Escreva um programa que solicita 10 números ao usuário, 
         *através de um laço while, e ao final mostre qual destes
         *números é o maior. 
         */

        static void Main(string[] args)
        {
            int i = 0;
            double maior_num;

            Console.WriteLine("Informe o numero {0}:", i + 1);
            double num = double.Parse(Console.ReadLine());
            maior_num = num;
            i++;

            while (i < 10)
            {
                Console.WriteLine("Informe o numero {0}:", i + 1);
                double n1 = double.Parse(Console.ReadLine());

                if (maior_num < n1)
                {
                    maior_num = n1;
                }

                i++;
            }

            Console.WriteLine("\nO maior número digitado foi --> {0}", maior_num);
        }
    }
}
