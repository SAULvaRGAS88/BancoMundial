using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial.models
{
    public class ContaSalario : Conta
    {
        public ContaSalario(Pessoa titular, long numero, int agencia, double saldoInicial, double taxaSaque)
            : base(titular, numero, agencia, saldoInicial, taxaSaque)
        {

        }
    }
}
