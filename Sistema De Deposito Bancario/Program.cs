using SistemaParaDepósitoBancario;
using System;
using System.Globalization;

namespace BancCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando a conta (outra classe)
            //declarei o construtor para que ele possa ser acessado
            //em qualquer escopo do meu projeto
            ContaBancaria conta;

            Console.WriteLine("---- Sistema de depósito bancario (Aperte enter)----");
            Console.ReadLine();

            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o títular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Havera depósito inicial? (S/N)");
            char resp = char.Parse(Console.ReadLine().ToUpper());

            if (resp == 'S')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Instanciando a conta com os argumentos recebidos nos console.readline
                conta = new ContaBancaria(numero, titular, depositoinicial);

            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine("---- Obrigado por usar o sistema bancário 1.0 ----");
        }
    }
}