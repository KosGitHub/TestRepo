using System;

namespace Task11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Tom Brannon", 20, "Information systems", 2);
            Student student2 = new Student("Tom Brannon", 20, "Information systems", 2);
            Teacher teacher1 = new Teacher("Nick Jonhson", 43, "Programming");
            Teacher teacher2 = new Teacher("Michael Pallet", 50, "Sociology");
            if (student1 == student2)
            {
                Console.WriteLine("Students {0} and {1} are equals", student1.Name, student2.Name);
            }
            else
            {
                Console.WriteLine("Students {0} and {1} are not equals", student1.Name, student2.Name);
            }
            Console.WriteLine(new string('-',50));
            if (teacher1 == teacher2)
            {
                Console.WriteLine("Teacher {0} and {1} are equals", teacher1.Name, teacher2.Name);
            }
            else
            {
                Console.WriteLine("Teacher {0} and {1} are not equals", teacher1.Name, teacher2.Name);
            }
            Console.ReadLine();
        }
    }
}
