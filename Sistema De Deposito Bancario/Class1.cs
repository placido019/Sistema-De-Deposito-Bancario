using System;
using System.Globalization;

namespace SistemaParaDepósitoBancario
{
    internal class ContaBancaria
    {
        //get = acessado
        //private = não pode ser alterado


        //Atributos ou propriedades
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //Construtor com 2 argumentos
        public ContaBancaria(int numeroConta, string titular)
        {
            //Atributos recebendo argumentos
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = 0;
        }

        //Construtor com 3 argumentos
        //"This" reutiliza os parametros do construtor anterior (numero conta e titular)
        public ContaBancaria(int numeroConta, string titular, double depositoinicial) : this(numeroConta, titular)
        {
            //A função Depósito ira cuidar de toda a lógica do depósito
            //Se eu altera-la um dia, sera alterada no construtor tambem
            Deposito(depositoinicial);

        }

        //Void nao retorna saída
        //Função de depósito
        public void Deposito(double quantia)
        {
            //Saldo receberá o valor armazenado na quantia
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            //Saldo receberá o valor tirado da quantia 
            Saldo -= quantia;
            //5 é a taxa para saque !
            Saldo -= 5.0;
        }

        //ToString serve como uma "Função" para mostrar a saída dos dados
        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
