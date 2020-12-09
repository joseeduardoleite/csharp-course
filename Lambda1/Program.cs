using System;
using System.Collections.Generic;
using System.Linq;
using Lambda1.Entities;

namespace Lambda1
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection) {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            System.Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category category1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category category2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category category3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> list1 = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 500.0, Category = category2},
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = category1},
                new Product() { Id = 3, Name = "TV", Price = 800.0, Category = category3},
                new Product() { Id = 4, Name = "Notebook", Price = 550.0, Category = category2},
                new Product() { Id = 4, Name = "Mother Board", Price = 550.0, Category = category3},
                new Product() { Id = 4, Name = "Knife", Price = 110.0, Category = category1}
            };

            //forma alternativa
            // var result1 = from p in list1
            //               where p.Category.Tier == 1 && p.Price < 900.00
            //               select p;
            var result1 = list1.Where(x => x.Category.Tier == 1 && x.Price < 900);
            Print("TIER 1 AND PRICE < 900", result1);

            //forma alternativa
            // var result2 = from p in list1
            //               where p.Category.Name == "Tools"
            //               select p.Name;
            var result2 = list1.Where(x => x.Category.Name == "Tools").Select(x => x.Name);
            Print("NAME OF PRODUCTS FROM TOOLS", result2);

            // forma alternativa
            // var result3 = from p in list1
            //               where p.Name[0] == 'C'
            //               select new {
            //                 p.Name, p.Price, CategoryName = p.Category.Name
            //                };
            var result3 = list1.Where(p => p.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name } );
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", result3);

            // forma alternativa
            // var result4 = from x in list1
            //               where x.Category.Tier == 1
            //               orderby x.Name
            //               orderby x.Price
            //               select x;
            var result4 = list1.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", result4);

            // forma alternativa
            // var result5 = (from x in result4
            //               select x).Skip(2).Take(4);
            // Pula os dois elementos e pega os 4 primeiros
            var result5 = result4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", result5);

            // forma alternativa
            // var result6 = (from x in list1
            //               select x).FirstOrDefault();
            // O First pega o primeiro item da lista, porém se não houve nada exibirá uma exception
            // O FirstOrDefault pega o primeiro item da lista, porém se for nulo apenas não retorna nada, ou seja, null.
            var result6 = list1.FirstOrDefault();
            Console.WriteLine("First or default test1: " + result6);

            var result7 = list1.Where(x => x.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + result7);
            Console.WriteLine();

            var result8 = list1.Where(x => x.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: ", result8);

            var result9 = list1.Where(x => x.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: ", result9);

            var result10 = list1.Max(p => p.Price);
            Console.WriteLine("Max price: " + result10);

            var result11 = list1.Min(p => p.Price);
            Console.WriteLine("Max price: " + result11);

            // Soma
            var result12 = list1.Where(x => x.Category.Id == 1).Sum(x => x.Price);
            Console.WriteLine("Category 1 Sum prices: " + result12);

            // Média
            var result13 = list1.Where(x => x.Category.Id == 1).Average(x => x.Price);
            Console.WriteLine("Category 1 Average prices: " + result13);

            // Se o resultado de toda a expressão (coleção) for vazia, o 'DefaultIfEmpty' vai retornar um valor
            var result14 = list1.Where(x => x.Category.Id == 5).Select(x => x.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + result13);

                                                                                    // Função anônima
            var result15 = list1.Where(x => x.Category.Id == 1).Select(x => x.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + result15);

            // Esse 0.0 é como se fosse um DefaulIfEmpty, mas ele na verdade é definido como um valor inicial
            var result16 = list1.Where(x => x.Category.Id == 5).Select(x => x.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + result16);
            Console.WriteLine();

            // forma alternativa
            // var result17 = from x in list1
            //                group x by x.Category;
            var result17 = list1.GroupBy(x => x.Category);
            foreach (IGrouping<Category, Product> item in result17) {
                Console.WriteLine("Category " + item.Key.Name + ":");
                foreach (Product product in item) {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }
        }
    }
}
