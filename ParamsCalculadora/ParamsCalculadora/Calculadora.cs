using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsCalculadora
{
    internal class Calculadora
    {

        // Usando o modificador de paramêtro "params", você indica que a função pode responder uma quantia variável de valores. Tirando a necessidade de instanciar o vetor quando for usá-lo no programa.
        public static int Soma(params int[] numbers)
        {
            int soma = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                soma += numbers[i];
            }
            return soma;
        }
    }
}
