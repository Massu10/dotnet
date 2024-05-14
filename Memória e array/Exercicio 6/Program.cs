using System;
using Course;

namespace Exercicio
{
    class Pensionato
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados? ");
            int qtd = int.Parse(Console.ReadLine());
            Quarto[] quarto = new Quarto[10];

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1));
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                int numero = int.Parse(Console.ReadLine());
                quarto[numero] = new Quarto(nome, email, numero);
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (quarto[i] != null)
                {
                    Console.WriteLine(quarto[i]);
                }
            }
        }
    }
}
