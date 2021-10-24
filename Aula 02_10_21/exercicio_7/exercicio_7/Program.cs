using System;

namespace exercicio_7
{
    class Program
    {
        // Faça um algoritmo que receba o peso e a altura de uma pessoa, calcule e mostra o seu IMC
        // e a Faixa de Risco com base nas informações abaixo: IMC = (peso/altura²)
        // Faixa de Risco: Abaixo de 20 - Abaixo do peso.De 20 a 25 - Peso normal.Acima de 25 até 30 -Acima do peso.
        // Acima de 30 - Obesidade. *

static void Main(string[] args)
        {

            Console.Write("Informe o peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("\nIMC = {0} ", imc);

            if (imc < 20)
            {
                Console.Write("Abaixo do peso.");
            }
            else if (imc <= 25)
            {
                Console.Write("Peso normal.");
            }
            else if (imc <= 30)
            {
                Console.Write("Acima do peso.");
            }
            else
            {

                Console.Write("Acima do peso.");
            }

            Console.ReadKey();
        }
    }
}
