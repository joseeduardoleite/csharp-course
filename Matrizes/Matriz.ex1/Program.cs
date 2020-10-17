using System;

namespace Matriz.ex1
{
    class Program
    {
        static void Main(string[] args)
        {
           int[,] matriz;
           System.Console.Write("Tamanho da Matriz: ");
           int numeroMatriz = int.Parse(Console.ReadLine());
           matriz = new int[numeroMatriz , numeroMatriz];

           for (int i = 0; i < numeroMatriz; i++)
           {
               string[] values = Console.ReadLine().Split(' ');

               for (int j = 0; j < numeroMatriz; j++)
               {
                   matriz[i,j] = int.Parse(values[j]);
               }
               
           }

           System.Console.WriteLine("Diagonal principal:");
           for (int i = 0; i < numeroMatriz; i++)
           {
               System.Console.WriteLine(matriz[i,i] + " ");
           }
           System.Console.WriteLine("------------");

           int contador = 0;
           for (int i = 0; i < numeroMatriz; i++)
           {
               for (int j = 0; j < numeroMatriz; j++)
               {
                   if (matriz[i,j] < 0)
                    contador++;
               }
           }
           System.Console.WriteLine("Numeros negativos: " + contador);
        }
    }
}
