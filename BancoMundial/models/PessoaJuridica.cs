using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial.models
{
    public class PessoaJuridica : Pessoa
    {
        public List<PessoaFisica> Socios { get; set; }
        public int Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public int InscricaoEstadual { get; set; }
        public DateTime DataAbertura { get; set; }
        public double Faturamento { get; set; }

        // Propriedade para retornar a idade
        public int Idade
        {
            get
            {
                return DateTime.Now.Year - DataAbertura.Year;
            }
        }

        public PessoaJuridica(
            int cnpj,
            string razaoSocial,
            string nomeFantasia,
            int inscricaoEstadual,
            DateTime dataAbertura,
            double faturamento,
            int numeroDePessoas,
            int id,
            string endereco,
            string tel,
            string email)
            : base(numeroDePessoas, id, endereco, tel, email)
        {
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            InscricaoEstadual = inscricaoEstadual;
            DataAbertura = dataAbertura;
            Faturamento = faturamento;
            Socios = new List<PessoaFisica>();
        }

        // Método para adicionar sócios
        public void AdicionarSocio(PessoaFisica socio)
        {
            Socios.Add(socio);
        }
    }
}
