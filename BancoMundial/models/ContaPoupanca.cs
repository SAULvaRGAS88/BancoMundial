using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial.models
{
   public class ContaPoupanca : Conta, IDepositavel
    {
        public ContaPoupanca(Pessoa titular, long numero, int agencia, double saldoInicial, double taxaSaque)
            : base(titular, numero, agencia, saldoInicial, taxaSaque)
        {
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado na poupança com sucesso. Seu novo saldo e {Saldo}");
        }
    }
}
