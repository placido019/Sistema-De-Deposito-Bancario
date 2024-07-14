using System;
using System.Globalization;

namespace SistemaParaDepósitoBancario
{
    internal class ContaBancaria
    {
        //get = acessado
        //private = não pode ser alterado


        //Atributos
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

        //Construtor
        //"This" reutiliza os parametros do construtor anterior (numero conta e titular)
        public ContaBancaria(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            //Atributos recebendo argumentos
            Saldo = saldo;

        }

        //ToString serve como uma "Função" para mostrar a saída dos dados
        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
