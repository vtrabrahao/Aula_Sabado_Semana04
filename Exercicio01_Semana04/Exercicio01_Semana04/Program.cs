using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Semana04
{
    /// <summary>
    /// Faça um programa que leia 8 variaveis e as passe como parametro para um construtor, esse construtor
    /// deverá colocar as variaveis no vetor. E depois calcular e retornar a Média das Notas. (Construtores não possuem tipo de retorno).
    /// </summary>

    class Semana04_Notas
    {
        static void Main(string[] args)
        {

            int[] Vetor_Notas = new int[] { 10, 10, 10, 10, 0, 0, 10, 10 };

            Vetor_Pasado oito = new Vetor_Pasado(Vetor_Notas);
            var M = oito.Retorna_Media();
            Console.WriteLine("Média = {0}",M); // 7,5 na verdade hehe...
            Console.ReadLine();
        }
    }
}
