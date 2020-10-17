using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inserir elemento na lista: Add, Insert
            // Tamanho da lista: Count
            // Encontrar primeiro ou último elemento da lista que satisfaça um predicado:
            // list.Find, list.FindLast
            // Encontrar primeira ou última posição de elemente da lista que satisfaça um predicado:
            // list.FindIndex, list.FindLastIndex
            // Filtrar a lista com base em um predicado: list.FindAll
            // Remover elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange
            
            List<string> lista = new List<string>();

            lista.Add("Eduardo");
            lista.Add("Maria");
            lista.Add("Carlos");
            lista.Add("Eliana");
            lista.Add("Joao");
            lista.Insert(2, "Judas");

            foreach (string obj in lista)
            {
                System.Console.WriteLine(obj);
            }
            System.Console.WriteLine("Contagem da lista: " + lista.Count);

            string s1 = lista.Find(p => p[0] == 'M');
            System.Console.WriteLine(s1);

            string s2 = lista.FindLast(p => p[0] == 'E');
            System.Console.WriteLine(s2);

            int p1 = lista.FindIndex(p => p[0] == 'E');
            System.Console.WriteLine("Primeira posicao comecando com E: " + p1);

            int p2 = lista.FindLastIndex(p => p[0] == 'E');
            System.Console.WriteLine("Ultima posicao comecando com E: " + p2);
            System.Console.WriteLine("--------------------");

            List<string> filtro = lista.FindAll(p => p.Length == 5);

            foreach (string obj in filtro) {
                System.Console.WriteLine(obj);
            }

            System.Console.WriteLine("-------------");

            lista.RemoveAt(5);
            System.Console.WriteLine("Agora removendo o jao");
            foreach (string obj in lista) {
                System.Console.WriteLine(obj);
            }

            System.Console.WriteLine("---------------------");

            lista.RemoveAll(p => p[0] == 'E');

            foreach (string objeto in lista) {
                System.Console.WriteLine(objeto);
            }
            System.Console.WriteLine("-------------");

            lista.RemoveRange(1, 2);

            foreach (string p in lista) {
                System.Console.WriteLine(p);
            }
        }
    }
}
