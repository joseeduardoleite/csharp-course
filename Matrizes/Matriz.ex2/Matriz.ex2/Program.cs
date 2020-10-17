using System;

namespace Matriz.ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ler dois numeros inteiros M e N, ler uma mat de M l por N c contendo numeros inteiros,
            // podendo haver repeticoes. Ler um numero int X que pertence a matriz. Para cada ocorrencia de X,
            // mostrar os valores a esquerda, acima, a direita e abaixo de X, quando houver, conforme exemplo.

            string[] linha = Console.ReadLine().Split(' ');
            int m = int.Parse(linha[0]);
            int n = int.Parse(linha[1]);

            int[,] matriz = new int[m,n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            System.Console.WriteLine("Insira o numero que deseja: ");

            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
               for (int j = 0; j < n; j++)
               {
                   if (matriz[i,j] == numero)
                   {
                       System.Console.WriteLine("Posicao " + i + "," + j + ":");
                       if (j > 0) {
                           System.Console.WriteLine("Esquerda: " + matriz[i,j - 1]);
                       }
                       if (i > 0) {
                           System.Console.WriteLine("Acima: " + matriz[i - 1, j]);
                       }
                       if (j < n - 1) {
                           System.Console.WriteLine("Direita: " + matriz[i, j + 1]);
                       }
                       if (i < m -1) {
                           System.Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                       }
                   }
               }
            }
        }
    }
}
