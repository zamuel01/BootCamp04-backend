﻿using System;

namespace nullablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int? nx = null;

            Console.WriteLine("nx has a value? {0}", nx.HasValue);
            Console.WriteLine("x == nx {0}", x == nx);
            Console.WriteLine("x != nx {0}", x != nx);

            nx = 20;
            Console.WriteLine("nx has a value? {0}", nx.HasValue);
            Console.WriteLine("nx has the value {0}", nx.Value);
            Console.WriteLine("x == nx: {0}", x == nx);
            Console.WriteLine("x != nx {0}", x != nx);

            nx = -1;
            Console.WriteLine("nx = {0}", nx ?? 1);
            nx = 0;
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault());
            nx = null;
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault(-2));

            nx = 10;
            Console.WriteLine("nx = {0}", nx ?? -1);
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault());
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault(-2));



        }
    }
}
