using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 105;
            List<Student> studentList = new List<Student>()
            {
                new Student("Nechui Ivan Petrovych", 3, new List<Exam>(){new Exam("History",3), new Exam("Mathematics",4), new Exam("Physics",5)}),
                new Student("Polyova Olga Volodymyrivna", 2, new List<Exam>(){new Exam("History",5), new Exam("Mathematics",3), new Exam("Physics",3)}),
                new Student("Korzun Volodymyr Ivanovych", 1, new List<Exam>(){new Exam("History",4), new Exam("Mathematics",4), new Exam("Physics",5)}),
                new Student("Holosha Sergiy Anatolievych", 3, new List<Exam>(){new Exam("History",3), new Exam("Mathematics",3), new Exam("Physics",4)}),
                new Student("Golova Anna Mychailivna", 1, new List<Exam>(){new Exam("History",4), new Exam("Mathematics",5), new Exam("Physics",3)}),
            };
            //First methot using LINQ
            //studentList =
            //    studentList.OrderBy(x => x.GroupNumber)
            //    .Where(x => x.Exams.Sum(y => y.Mark) >= 12)
            //    .ToList();//average mark >=4 ==> exam handed
            //
            //Second method using my sorting and filtration
            studentList.SortByExams();
            studentList.Sort(new StudentComparerByGroup());
            foreach (var student in studentList)
            {
                Console.WriteLine(student.ToString());
            }
            Console.Read();
        }
    }
}
