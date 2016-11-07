using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth=120;
            List<Student> studentList = new List<Student>()
            {
                new Student("Nechui Ivan Petrovych", 1994, "Nezalezhnosti st. 24, app.138", "Gymnasium №3"),
                new Student("Polyova Olga Volodymyrivna", 1997, "Dnipra st. 2, app.85", "School №2"),
                new Student("Korzun Volodymyr Ivanovych", 1995, "Ostrogratskogo st. 27, app.33", "Gymnasium №3"),
                new Student("Holosha Sergiy Anatolievych", 1993, "Nezalezhnosti st. 10 app.18", "Gymnasium №3"),
                new Student("Golova Anna Mychailivna", 1994, "Budivelnikiv st. 72, app.145", "School №2")
            };
            //First methot using LINQ
            //studentList =
            //    studentList.OrderBy(x => x.YearOfBirth)
            //    .Where(x => x.School == "Gymnasium №3")
            //    .ToList();
            //
            //Second method using my sorting and filtration 
            studentList.SortBySchool("Gymnasium №3");
            studentList.Sort(new StudentComparerByAge());

            foreach (var student in studentList)
            {
                Console.WriteLine(student.ToString());
            }
            Console.Read();
        }
    }
}
