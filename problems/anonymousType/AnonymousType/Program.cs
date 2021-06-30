using Newtonsoft.Json;
using System;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            Anonnymous anonymous = new Anonnymous();
            dynamic anonymousDynamicData = anonymous.getData();
            Console.WriteLine(string.Format("{0} {1}", anonymousDynamicData.Name, anonymousDynamicData.EmailID));
            

            object anonymousData = anonymous.getData();
            var obj = convert(anonymousData, new { Name = "", EmailID = "" });
               
            Console.WriteLine(string.Format("{0} {1}", obj.Name, obj.EmailID));
        }
        public static T convert<T>(object obj, T type)
        {
            return (T)obj;
        }

    }

    class Anonnymous
    {
        public object getData()
        {
            return new { Name = "Pepe", EmailID = "pepegmail.com" };
        }
    }
}
