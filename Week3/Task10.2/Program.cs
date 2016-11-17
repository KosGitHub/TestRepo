using System;
using System.Collections;

namespace Task10._2
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList1 = new ArrayList() { 2, 45, 78, 12, 24, 8 };
            ArrayList arrayList2 = new ArrayList() { 6, 1, 54, 22, 98, 35 };

            Console.WriteLine("ArrayList №1 before SortBubble()");
            arrayList1.Print();
            arrayList1.SortBubble();
            Console.WriteLine("ArrayList №1 after SortBubble()");
            arrayList1.Print();

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("ArrayList №2 before SortSelection()");
            arrayList2.Print();
            arrayList2.SortSelection();
            Console.WriteLine("ArrayList №2 after SortSelection()");
            arrayList2.Print();
            Console.ReadLine();
        }
    }
}
