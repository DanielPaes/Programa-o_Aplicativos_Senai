using System;

namespace exercicio_1
{
    class Program
    {
       // Escreva um programa que leia 10 valores, e encontre o maior valor dentre eles

        static void Main(string[] args)
        {

            int[] nums = new int[10];
            int maior;

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Entre com o valor {0}: ", i + 1);
                nums[i] = int.Parse(Console.ReadLine());
            }

            maior = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maior)
                {
                    maior = nums[i];
                }
            }

            Console.WriteLine("\nO maior valor é {0}", maior);

            Console.ReadKey();

        }

    }
}
