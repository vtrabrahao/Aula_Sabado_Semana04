using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Semana04
{
    class Vetor_Pasado
    {
        private int[] notas;
        public Vetor_Pasado(params int[] x)
        {
            notas = new int[x.Length];
            notas = x; 
        }

        public int Retorna_Media()
        {
            var soma = notas.Sum();
            Console.WriteLine("Soma = {0}", soma);
            var M = soma / 8;
            return M;
        }
    }
}
