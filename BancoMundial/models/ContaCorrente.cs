using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial.models
{
    //Classe ContaCorrente herda de Conta suas propriedades
    public class ContaCorrente : Conta, IDepositavel
    {
        public string Tipo { get; } = "Corrente";
        public double Limite { get; }
        public double TaxaDoLimite { get; }

        public ContaCorrente(Pessoa titular, long numero, int agencia, double saldoInicial, double taxaSaque, double limite, double taxaDoLimite)
            : base(titular, numero, agencia, saldoInicial, taxaSaque)
        {
            Limite = limite;
            TaxaDoLimite = taxaDoLimite;
        }

        public void Pagar(string codigoBarras)
        {
            Console.WriteLine($"Pagamento do código de barras {codigoBarras} realizado.");
        }

        public void Emprestimo(double valor)
        {
            if (valor <= Limite)
            {
                Saldo += valor;
                Console.WriteLine($"Empréstimo de {valor} concedido.");
            }
            else
            {
                Console.WriteLine("Valor do empréstimo excede o limite.");
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso.");
        }
    }
}