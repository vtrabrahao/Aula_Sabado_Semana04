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
        public Vetor_Pasado(int np1,int np2,int np3,int np4,int np5,int np6, int np7, int np8)
        {
            notas = new int[] { np1, np2, np3, np4, np5, np6, np7, np8 };
        }

        public int Retorna_Media()
        {
            var soma = notas.Sum();
            var M = soma / 8;
            return M;
        }
    }
}
