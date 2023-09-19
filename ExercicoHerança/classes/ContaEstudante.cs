using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoHerança.classes
{
    internal class ContaEstudante:ContaBancaria
    {
        public double LimiteChequeEspecial { get; set; }
        public string Cpf { get; set; }
        public string nomeInstituicao { get; set; }

       
        public ContaEstudante(int numeroConta, string agencia, string titular, double saldo, double limiteChequeEspecial, string cpf, string instituicaoEnsino)
            : base(numeroConta, agencia, titular, saldo)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
            Cpf = cpf;
            nomeInstituicao = instituicaoEnsino;

        }

        public override void Saque(double valor)
        {
            if (valor <= Saldo + LimiteChequeEspecial)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
        }

    }
    
}
