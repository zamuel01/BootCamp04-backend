using System;

namespace anonymous
{
    class Program
    {
        public delegate void Print(int value);
        static void Main(string[] args)
        {
            Print print = delegate (int val)
            {
                Console.WriteLine("inside anonymous Method :{0}", val);
            };

            print(100);
        }
    }
}
