using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace execptions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var group1 = new string[]{"Michael", "Maria", "Joel", "Joel" };
            var group2 = new string[]{"Bob", "Kevin", "Adan", "Maria" };
            var group3 = new string[]{"Pepe", "Pedro" };
            ShowArray(group1, "group 1");
            //multitheread LINQ
            var watch = new Stopwatch();
            Console.WriteLine("Press Press enter");
            Console.ReadLine();
            watch.Start();
            IEnumerable<int> numbers = Enumerable.Range(1, 2_000_000_000);
            var squares = numbers.Select(number => number * number).ToArray();
            watch.Stop();
            Console.WriteLine("{0}: milliseconds", arg0: watch.ElapsedMilliseconds);*/

            List<Product> products = new List<Product>() {
                new Product() {ID = 1, Price = 35},
                new Product() {ID = 1, Price = 150},
                new Product() {ID = 1, Price = 650},
                new Product() {ID = 1, Price = 150},
                new Product() {ID = 1, Price = 15},
                new Product() {ID = 1, Price = 35},
                new Product() {ID = 1, Price = 650},
                new Product() {ID = 1, Price = 78},
                new Product() {ID = 1, Price = 35},
                new Product() {ID = 1, Price = 78}
                            };

            Console.WriteLine("Average " + products.Average(p => p.Price));
            Console.WriteLine("Mode " + products.Mode(p => p.Price));
            Console.WriteLine("UnMode " + products.UnMode(p => p.Price));

            Console.WriteLine("Median " + products.Median(p => p.Price));
        }

        class Product {
            public int ID { get; set; }
            public int Price { get; set; }
        }

        public static void ShowArray(IEnumerable<string> group, string description)
        {
            Console.WriteLine("{0:#,##0} {1}", description, string.Join(", ", group.ToArray()));
        } 
    }   
}
