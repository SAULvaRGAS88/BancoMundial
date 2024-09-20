using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial.utils
{
    /** Uma Classe auxiliar para uso geral, pode ser usada em outros
     partes do programa, diminuindo assim o tempo de escrita e deixando o 
    código mais limpo e organizado
     */
    public static class Auxiliar
    {
        // Método para calcular a idade com base na data de nascimento
        public static int CalcularIdade(DateTime dataNasc)
        {
            int idade = DateTime.Now.Year - dataNasc.Year;
            if (DateTime.Now.DayOfYear < dataNasc.DayOfYear)
                idade--;

            return idade;
        }

        // Método para determinar a faixa etária com base na idade
        public static string FaixaEtaria(int idade)
        {
            if (idade < 12)
                return "Criança";
            else if (idade < 18)
                return "Adolescente";
            else if (idade < 60)
                return "Adulto";
            else
                return "Idoso";
        }
    }

}

