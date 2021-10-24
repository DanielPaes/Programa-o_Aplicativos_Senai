using System;

namespace exercicio_6
{
    class Program
    {
        // Faça um programa que receba uma senha formada de quatro números inteiros, verifique se a senha está correta e,
        // caso não esteja, solicite novamente a senha.Se a senha entrada for a correta, deverá ser apresentada a
        // mensagem “Senha Correta”, caso contrário, “Senha Incorreta”. *

        static void Main(string[] args)
        {
            string senha = "1234";

            while (true)
            {
                Console.WriteLine("\nEntre com a senha formada por 4 números inteiros:");
                string senha_ent = Console.ReadLine();

                if (senha_ent.Equals(senha))
                {
                    Console.WriteLine("\nSenha correta!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nSenha incorreta. Tente novamente.");
                }
            }
        }
    }
}


       
        
