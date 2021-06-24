using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace valueTypes
{
    public struct DetaildInteger 
    {

        public List<string> detail;
        public int Number;
        public DetaildInteger(int number)
        {
            detail = new List<string>();
            this.Number = number;
        }
    
        public void AddDetail(string detail)
        {
            this.detail.Add(detail);
        }
 
        public override string ToString()
        {
            return this.Number + " [" + string.Join(",", detail.ToArray()) + "]";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var n1 = new DetaildInteger(0);
            n1.AddDetail("A");
            Console.WriteLine(n1);

            var n2 = n1;
            n2.Number = 7;
            n2.AddDetail("B");

            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
    }
}
