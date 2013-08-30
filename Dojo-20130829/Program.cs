using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo_20130829
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }
        public void teste()
        {
        }

        internal Dictionary<int, int> saque(int p)
        {
            var notas = new []{2, 5, 10, 20, 50, 100};
            var retorno = new Dictionary<int,int>();

            var resto = p;

            for (int i = (notas.Length - 1); i >= 0; i--)
            {
                int divi = resto / notas[i];
                if (divi > 0)
                    retorno[notas[i]] = divi;

                resto = resto - (notas[i] * divi);
                if (resto <= 0)
                    break;
            }

            if (resto > 0)
            {
                throw new Exception("Não é possível sacar o valor esperado.");
            }
            return retorno;
            
        }
    }
}
