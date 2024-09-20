using BancoMundial.models;
using BancoMundial.utils;
using System;
using System.Collections.Generic;

namespace BancoMundial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação da lista de PessoaFisica e add na lida de pessoas
            List<PessoaFisica> pessoasFisicas = new List<PessoaFisica>
            {
                new PessoaFisica
                (
                    nome: "João",
                    sobrenome: "Silva",
                    rg: "12345678",
                    cpf: "111.222.333-44",
                    dataNasc: new DateTime(1990, 5, 20),
                    renda: 3500.00,
                    numeroDePessoas: 0,
                    id: 0,
                    endereco: "Rua Exemplo, 123",
                    tel: "5555-1234",
                    email: "contato@exemplo.com"
                ),
                new PessoaFisica
                (
                    nome: "Saul",
                    sobrenome: "Vargas",
                    rg: "1234567891",
                    cpf: "111.222.333-45",
                    dataNasc: new DateTime(1988, 5, 01),
                    renda: 4200.00,
                    numeroDePessoas: 2,
                    id: 1,
                    endereco: "Travessa Escobar, 549",
                    tel: "9999-1235",
                    email: "saulvargascosta@hotmail.com"
                )
            };

            // Criando uma instância de PessoaJuridica
            PessoaJuridica empresa1 = new PessoaJuridica
            (
                cnpj: 1234567890,
                razaoSocial: "Empresa Exemplo Ltda",
                nomeFantasia: "Exemplo",
                inscricaoEstadual: 987654321,
                dataAbertura: new DateTime(2010, 10, 5),
                faturamento: 500000,
                numeroDePessoas: 50,
                id: 1,
                endereco: "Rua Exemplo, 123456",
                tel: "4444-1234",
                email: "contato@exemplo.com"
            );

            // Adicionando sócios à empresa
            empresa1.Socios = new List<PessoaFisica>
            {
                pessoasFisicas.First(p => p.Nome == "João"),
                new PessoaFisica
                (
                    nome: "Maria",
                    sobrenome: "Oliveira",
                    rg: "87654321",
                    cpf: "555.666.777-88",
                    dataNasc: new DateTime(1985, 8, 15),
                    renda: 4500.00,
                    numeroDePessoas: 3,
                    id: 2,
                    endereco: "Rua Exemplo, 456",
                    tel: "5555-5678",
                    email: "maria.oliveira@exemplo.com"
                )
            };

            // Exibindo as informações de PessoaFisica no console usando foreach
            foreach (var pessoa in pessoasFisicas)
            {
                Console.WriteLine("Informações de Pessoa Física:");
                Console.WriteLine($"Nome: {pessoa.Nome} {pessoa.Sobrenome}");
                Console.WriteLine($"Idade: {Auxiliar.CalcularIdade(pessoa.DataNasc)}");
                Console.WriteLine($"Faixa Etária: {Auxiliar.FaixaEtaria(Auxiliar.CalcularIdade(pessoa.DataNasc))}");
                Console.WriteLine($"CPF: {pessoa.Cpf}");
                Console.WriteLine($"Renda: {pessoa.Renda:C}");
                Console.WriteLine();
            }

            // Exibindo as informações de PessoaJuridica no console
            Console.WriteLine("Informações de Pessoa Jurídica:");
            Console.WriteLine($"Razão Social: {empresa1.RazaoSocial}");
            Console.WriteLine($"Nome Fantasia: {empresa1.NomeFantasia}");
            Console.WriteLine($"CNPJ: {empresa1.Cnpj}");
            Console.WriteLine($"Faturamento: {empresa1.Faturamento:C}");
            Console.WriteLine($"Data de Abertura: {empresa1.DataAbertura.ToShortDateString()}");
            Console.WriteLine($"Sócios:");

            foreach (var socio in empresa1.Socios)
            {
                Console.WriteLine($"- {socio.Nome} {socio.Sobrenome}, Idade: {Auxiliar.CalcularIdade(socio.DataNasc)}, Faixa Etária: {Auxiliar.FaixaEtaria(Auxiliar.CalcularIdade(socio.DataNasc))}");
            }

            // Usando métodos de Auxiliar
            Console.WriteLine();
            Console.WriteLine("Usando métodos da classe Auxiliar:");
            int idadeJoao = Auxiliar.CalcularIdade(pessoasFisicas.First(p => p.Nome == "João").DataNasc);
            Console.WriteLine($"Idade calculada de João: {idadeJoao}");
            string faixaEtariaJoao = Auxiliar.FaixaEtaria(idadeJoao);
            Console.WriteLine($"Faixa Etária de João: {faixaEtariaJoao}");
            Console.WriteLine();

            //Criando contas e executando seus metodos
            Console.WriteLine("Criando Conta Corrente");
            ContaCorrente contaCorrente1 = new ContaCorrente(
                pessoasFisicas.First(p => p.Nome == "João"),
                165156156156156156,
                1004,
                1000.00,
                10.00,
                5000.00,
                20.00
            );
            contaCorrente1.Pagar("1234567890123456789012345678901234567890");
            contaCorrente1.Emprestimo(2000.00);
            contaCorrente1.Depositar(500.00);
            contaCorrente1.Sacar(100.00);
            contaCorrente1.ConsultarSaldo();
            Console.WriteLine();

            Console.WriteLine("Criando Conta Poupanca");
            ContaPoupanca contaPoupaca1 = new ContaPoupanca(
                pessoasFisicas.First(p => p.Nome == "Saul"),
                656515615615615615,
                1004,
                6000.00,
                5.00
            );
            Console.WriteLine();
            contaPoupaca1.ConsultarSaldo();
            contaPoupaca1.Depositar(1000.00);
            contaPoupaca1.ConsultarSaldo();

            Console.WriteLine();
            Console.WriteLine("Criando Conta Salario");
            Console.WriteLine("Criando Conta Salario");
            ContaSalario contaSalario1 = new ContaSalario(
                pessoasFisicas.First(p => p.Nome == "Saul"),
                651651561561561,
                0004,            
                500.00,          
                0.00             
            );

            contaSalario1.Sacar(100.00);
            contaSalario1.ConsultarSaldo();
        }    
    }
}
