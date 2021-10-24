using System;

namespace exercicio_4
{
    class Program
    {
        // Escreva um programa que apresente quatro opções: (a) consulta saldo, (b) saque e(c)depósito e(d) sair.
        // O saldo deve iniciar em R$ 0,00. A cada saque ou depósito o valor do saldo deve ser atualizado *

        static void Main(string[] args)
        {
            string op;
            double saldo = 0;

            while (true)
            {
                Console.WriteLine("\n###########################");
                Console.WriteLine("Digíte a operação desejada:\na - Consulta saldo\nb - Saque\nc - Depósito\nd - Sair");
                Console.WriteLine("###########################\n");
                op = Console.ReadLine();

                if (op.Equals("d"))
                {
                    break;
                }

                if (op.Equals("a"))
                {
                    Console.WriteLine("\nSaldo -> {0}", saldo);
                }

                if (op.Equals("b"))
                {
                    Console.WriteLine("Valor do saque -> ");
                    double saq = double.Parse(Console.ReadLine());
                    saldo -= saq;
                }

                if (op.Equals("c"))
                {
                    Console.WriteLine("Valor do depósito -> ");
                    double dep = double.Parse(Console.ReadLine());
                    saldo += dep;
                }
            }
        }

    }
}
