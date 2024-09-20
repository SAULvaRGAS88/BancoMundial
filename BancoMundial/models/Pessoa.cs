using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial.models
{
    // Classe abstrata Pessoa, serve de padrão para outras classes
    public abstract class Pessoa
    {
        public int NumeroDePessoas { get; set; }
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

        protected Pessoa(int numeroDePessoas, int id, string endereco, string tel, string email)
        {
            NumeroDePessoas = numeroDePessoas;
            Id = id;
            Endereco = endereco;
            Tel = tel;
            Email = email;
        }
    }
}
