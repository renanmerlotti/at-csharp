using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao7
{
    internal class ContaBancaria
    {
        private String titular;
        private decimal saldo;

        public ContaBancaria(string titular, decimal saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        public string Titular { get => titular; set => titular = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }

        public void Depositar(decimal valor)
        {
            if (valor <= 0) 
            {
                Console.WriteLine("Erro: O valor do depósito deve ser positivo!");
            }
            else
            {
                saldo += valor;
                Console.WriteLine("Deposito de R$" + valor + " foi realizado com sucesso");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Tentativa de saque: " + Saldo);
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            }
            else 
            { 
                Saldo -= valor;
                Console.WriteLine("Saque de R$" + valor + " foi realizado com sucesso");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo da conta: " + Saldo);
        }
    }
}
