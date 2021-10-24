using System;

namespace exercicio_6
{
    class Program
    {
        // Faça um algoritmo que receba um valor em bytes, calcula e mostra esse valor em gigabytes.
        // Obs: procure a formula para fazer essa conversão*

         static void Main(string[] args)
        {

            Console.Write("Entre com o valor em bytes: ");
            double bt = double.Parse(Console.ReadLine());

            double gbt = bt / (1024 * 1024 * 1024);

            Console.WriteLine("{0} bytes = {1} Gigabytes", bt, gbt);
            Console.ReadKey();
        }
    }
}
