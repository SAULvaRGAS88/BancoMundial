using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial.models
{
    /**Classe abstracta Conta, que serve de base para as outras classes, como 
     conta corrente, poupança e conta salário.
     * */
    public abstract class Conta
    {
        public Pessoa Titular { get; set; }
        public long Numero { get; set; }
        public int Agencia { get; set; }
        protected double Saldo { get; set; }
        public double TaxaSaque { get; set; }

        public Conta(Pessoa titular, long numero, int agencia, double saldoInicial, double taxaSaque)
        {
            Titular = titular;
            Numero = numero;
            Agencia = agencia;
            Saldo = saldoInicial;
            TaxaSaque = taxaSaque;
        }

        public virtual void Sacar(double valor)
        {
            if (Saldo >= valor + TaxaSaque)
            {
                Saldo -= (valor + TaxaSaque);
                Console.WriteLine($"Saque de {valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine("Saldo R$: " + Saldo);
        }

        public void Transferir(Conta conta, double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                conta.Saldo += valor;
                Console.WriteLine($"Transferência de {valor} realizada com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para transferência.");
            }
        }
    }
}
