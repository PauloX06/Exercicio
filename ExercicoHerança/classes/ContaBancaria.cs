using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoHerança.classes
{
    internal class ContaBancaria
    {
        public int Nconta { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }


       

        public ContaBancaria(int numeroConta, string agencia, string titular, double saldo)
        {
            Nconta = numeroConta;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;

        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public virtual void Saque(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}
