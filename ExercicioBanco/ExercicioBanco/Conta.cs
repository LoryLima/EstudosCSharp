using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    internal class Conta
    {
        public string Titular
        {
            get; set;
        }
        public int NumeroConta
        {
            get; private set;
        }
        public double Saldo
        {
            get; private set;
        }
       

        public Conta(string nome, int numeroConta)
        {
            Titular = nome;
            NumeroConta = numeroConta;
        }

        public Conta(string titular, int numeroConta, double saldo) : this(titular, numeroConta)
        {
            Saldo = saldo;
        }

        public void Deposito(double value)
        {
            if (value >= 0)
            {
                Saldo += value;
            }
       
        
        }
        public void Saque(double value)
        {
            Saldo -= value + 5;

        }


        public override string ToString()
        {
            return ($"****DADOS DA CONTA****\nTitular: {Titular}\nConta: {NumeroConta}\nSaldo: {Saldo:C}");
        }
    }
}
