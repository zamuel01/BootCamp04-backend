using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Bill");
            arrayList.Add(2);
            arrayList.Add(true);
            arrayList.Add(10.0);
            arrayList.Add(null);

            var arrayList2 = new ArrayList(){
                2, "pepe", true, null
            };

            foreach(var item in arrayList)
              Console.WriteLine(item);

            foreach(var item in arrayList2)
              Console.WriteLine(item);

            var arrayLis4 = new ArrayList();
            int[] array1 = {1,2,3,4,5};
            Queue queue = new Queue();
            queue.Enqueue("data");

            arrayLis4.AddRange(arrayList2);
            arrayLis4.AddRange(array1);
            arrayLis4.AddRange(queue);

            //Accessing
            int testInt = (int)arrayList[2];
            string testString = (string) arrayList2[1];

            //remove
            arrayLis4.Remove(null);
            arrayLis4.Remove(4);
            //arrayLis4.RemoveRange(0, 10);

            //List<T>

            var students = new List<Student>() {
                new Student() {Id=1, Name="pepe"},
                new Student() {Id=1, Name="Maria"},
                new Student() {Id=1, Name="pepe3"}
            };

            string[] cities = new string[3] {"a", "b", "c"};

            var popularCities = new List<string>();
            popularCities.AddRange(cities);

            var popularCities2 = new List<string>();
            popularCities2.AddRange(popularCities);

            Console.WriteLine(popularCities2[0]);

            //LInq

            var result = from s in students
                         where s.Name == "Maria"
                         select s;

            foreach(var student in result)
                Console.WriteLine($"{student.Id}, {student.Name}");

            //Contains
            Console.WriteLine(popularCities.Contains("Maria"));

            //SortedList
            SortedList<int, string> numberNames = new SortedList<int, string>();

            numberNames.Add(3, "three");
            numberNames.Add(1, "one");
            numberNames.Add(4, "four");
            numberNames.Add(-1, "negative");
            numberNames.Add(10, "negative");

            foreach(KeyValuePair<int, string> item in numberNames)
                Console.WriteLine($"{item.Key}, {item.Value}");

            Console.WriteLine(numberNames[2]);

            IDictionary<int, string> keyName = new Dictionary <int, string>();
            keyName.Add(3, "three");
            keyName.Add(1, "one");
            keyName.Add(4, "four");

            foreach(KeyValuePair<int, string> item in keyName)
              Console.WriteLine($"{item.Key}, {item.Value}");

            var cities2 = new Dictionary<string, string>(){
                {"CBBA", "cocha"},
                {"LP", "LP"},
            };
        }
    }

    class Student 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
