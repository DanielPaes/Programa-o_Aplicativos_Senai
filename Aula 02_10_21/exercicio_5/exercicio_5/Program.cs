using System;

namespace exercicio_5
{
    class Program
    {
        
        // Faça um algoritmo que receba duas notas, calcula e mostra a média ponderada dessas notas,
        // considerando peso 4 para a primeira e peso 6 para a segunda.

    static void Main(string[] args)
        {

            Console.Write("Entre com a nota 1: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a nota 2: ");
            double n2 = double.Parse(Console.ReadLine());

            double media = (4 * n1 + 6 * n2) / 10;

            Console.WriteLine("Média = {0}", media);
            Console.ReadKey();
        }

    }
}
