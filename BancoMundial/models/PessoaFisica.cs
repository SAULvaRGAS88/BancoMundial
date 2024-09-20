using BancoMundial.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial.models
{
    public class PessoaFisica : Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public double Renda { get; set; }

        //Propriedade de calculo de idade usando a clase Auxiliar
        public int Idade
        {
            get
            {
                return Auxiliar.CalcularIdade(DataNasc);
            }
        }

        //Propriedade de calculo de faixa etária usando a classe Auxiliar
        public string FaixaEtaria
        {
            get
            {
               return Auxiliar.FaixaEtaria(Idade);
            }
        }

        public PessoaFisica(
            string nome,
            string sobrenome,
            string rg,
            string cpf,
            DateTime dataNasc,
            double renda,
            int numeroDePessoas,
            int id,
            string endereco,
            string tel,
            string email)
            : base(numeroDePessoas, id, endereco, tel, email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Rg = rg;
            Cpf = cpf;
            DataNasc = dataNasc;
            Renda = renda;
        }
    }
}
