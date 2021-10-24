using System;

namespace exercicio_5
{
    class Program
    {
        // Esse programa recebe dois números e a operação matemática que deve ser realizada entre eles.
        // Caso a operação não seja informada corretamente, solicita-se novas informações do usuário.

        static void Main(string[] args)
        {
            string op = "sem";

            Console.WriteLine("\nInforme o 1º número:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o 2º número:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDígite a operação a ser realizada: soma, subtração, multiplicação ou divisão");
            op = Console.ReadLine();

            switch (op)
            {
                case "soma":
                    Console.WriteLine("\n#############\nResultado: {0}\n##############", n1 + n2);
                    break;

                case "subtração":
                    Console.WriteLine("\n#############\nResultado: {0}\n##############", n1 - n2);
                    break;

                case "multiplicação":
                    Console.WriteLine("\n#############\nResultado: {0}\n##############", n1 * n2);
                    break;

                case "divisão":
                    Console.WriteLine("\n#############\nResultado: {0}\n##############", n1 / n2);
                    break;

                default:
                    Console.WriteLine("\nOperação não encontrada.");
                    break;
            }     
        }
    }
}
