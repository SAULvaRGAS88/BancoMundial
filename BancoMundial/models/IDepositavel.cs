using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial.models
{
    public interface IDepositavel
    {
        void Depositar(double valor);
    }
}
