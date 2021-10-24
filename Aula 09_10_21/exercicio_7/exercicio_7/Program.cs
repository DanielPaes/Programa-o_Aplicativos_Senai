using System;

namespace exercicio_7
{
    class Program
    {
        // Simulação de uma urna eletrônica com impressão de relatório da votação

        static void Main(string[] args)
        {
            int op = 0;
            int c1 = 0, c2 = 0, c3 = 0, qtd_votos = 0;
            double b = 0, n = 0;

            while (true)
            {

                Console.WriteLine("\n###############\nURNA ELETRÔNICA\n###############");
                Console.WriteLine("\nEscolha uma das opções para votar\n");
                Console.WriteLine("1 - Candidata Maria Santos");
                Console.WriteLine("2 - Candidato Carlos Silva");
                Console.WriteLine("3 - Candidato Antonio Rocha");
                Console.WriteLine("4 - Nulo");
                Console.WriteLine("5 - Branco");
                Console.WriteLine("\nEntre com o seu voto:");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    c1++;
                    qtd_votos++;
                }
                else if (op == 2)
                {
                    c2++;
                    qtd_votos++;
                }
                else if (op == 3)
                {
                    c3++;
                    qtd_votos++;
                }
                else if (op == 4)
                {
                    n++;
                    qtd_votos++;
                }
                else if (op == 5)
                {
                    b++;
                    qtd_votos++;
                }
                else if (op == 6)
                {
                    Console.WriteLine("\nVotos na Candidata Maria Santos: {0}", c1);
                    Console.WriteLine("Votos no Candidato Carlos Silva: {0}", c2);
                    Console.WriteLine("Votos no Candidato Antonio Rocha: {0}", c3);
                    Console.WriteLine("Porcentagem de votos nulo: {0}%", (100 * n) / qtd_votos);
                    Console.WriteLine("Porcentagem de votos Branco: {0}%", (100 * b) / qtd_votos);

                    if (c1 > c2 && c1 > c3)
                    {
                        Console.WriteLine("\nVencedora: Candidata Maria Santos\n");
                    }
                    else if (c2 > c1 && c2 > c3)
                    {
                        Console.WriteLine("\nVencedor: Candidato Carlos Silva\n");
                    }
                    else if (c3 > c1 && c3 > c2)
                    {
                        Console.WriteLine("\nVencedor: Candidato Antonio Rocha\n");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("\nOpção inválida. Tente novamente");
                }
            }
        }
    }
}
