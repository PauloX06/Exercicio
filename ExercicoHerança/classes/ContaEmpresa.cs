using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoHerança.classes
{
    internal class ContaEmpresa : ContaBancaria
    {
        public double TaxaAnuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }


        public ContaEmpresa(int numeroConta, string agencia, string titular, double saldo, double taxaAnuidade, double limiteEmprestimo)
            : base(numeroConta, agencia, titular, saldo)
        {
            TaxaAnuidade = taxaAnuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = 0;
        }
        public void RealizarEmprestimo(double valorEmprestimo)
        {
            if (valorEmprestimo <= LimiteEmprestimo - TotalEmprestimo)
            {
                Saldo += valorEmprestimo;
                TotalEmprestimo += valorEmprestimo;
                Console.WriteLine($"Empréstimo de R$ {valorEmprestimo} realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor indisponivel");
            }

        }
        public override void Saque(double valor)
        {

            if (valor <= Saldo)
            {
               Saldo -= valor;
            }
            if(valor >= 5000)
            {
                Saldo -= 5;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
            
        }
    }
}

