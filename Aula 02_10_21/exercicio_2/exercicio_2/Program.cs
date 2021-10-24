using System;

namespace exercicio_2
{
    class Program
    {
        // Preencha uma matriz com 10 números, e mostre a soma desses números

        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int soma = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Entre com o valor {0}: ", i + 1);
                nums[i] = int.Parse(Console.ReadLine());

                soma += nums[i];
            }

            Console.WriteLine("\nO somatório dos valores é {0}", soma);

            Console.ReadKey();

        }
    }
}
