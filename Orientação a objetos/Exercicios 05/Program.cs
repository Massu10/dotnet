using System;
using Course; // Supondo que Course seja o namespace onde está a classe Conta

namespace Exercicio
{
    class Operacao
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            string depositoInicial = Console.ReadLine();
            double valor = 0;

            Conta c;

            if (depositoInicial == "s")
            {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
                c = new Conta(numero, nome, valor);
            }
            else
            {
                c = new Conta(numero, nome);
            }

            Console.WriteLine("Dados da conta");
            Console.WriteLine(c);

            Console.WriteLine("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine());
            c.Depositar(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            c.Sacar(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
        }
    }
}
