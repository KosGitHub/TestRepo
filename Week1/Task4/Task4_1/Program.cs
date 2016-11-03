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
            //List<Student> sortedStudentList =
            //    studentList.OrderBy(x => x.YearOfBirth).Where(x => x.School == "Gymnasium №3").ToList();
            //foreach (var student in sortedStudentList)
            //{
            //    Console.WriteLine(student.ToString());
            //}
            //
            //Second method using my sorting
            studentList.SortBySchool(new StudentComparerByAge(), "Gymnasium №3");

            foreach (var student in studentList)
            {
                Console.WriteLine(student.ToString());
            }
            Console.Read();
        }
    }
    class Student
    {
        public string Fio { get; set; }
        public int YearOfBirth { get; set; }
        public string Address { get; set; }
        public string School { get; set; }

        public Student(string fio, int yearOfBirth, string address, string school)
        {
            this.Fio = fio;
            this.YearOfBirth = yearOfBirth;
            this.Address = address;
            this.School = school;
        }
        public override string ToString()
        {
            return String.Format("Fio: {0}, year of birthday: {1}, address: {2}, school: {3}",
                    Fio, YearOfBirth, Address, School);
        }
    }
    //My realization of Compare method for students comparing by age
    class StudentComparerByAge:IComparer<Student>
    {
         public int Compare(Student student1, Student student2)
        {
             if (student1.YearOfBirth>student2.YearOfBirth)
             {
                 return 1;
             }
             if (student1.YearOfBirth<student2.YearOfBirth)
             {
                 return -1;
             }
             return 0;
        }
    }
    static class StudentExtension
    {
        //Extension method for filtration of studentsList and compare by Age (with my own comparer)
        public static void SortBySchool(this List<Student> studentsList, IComparer<Student> studentComparer ,string schoolName)
        {
            List<Student> tempStudentsList = new List<Student>();
            foreach (var student in studentsList)
            {
                if (student.School == schoolName)
                {
                    tempStudentsList.Add(student);
                }
            }
            studentsList.Clear();
            studentsList.AddRange(tempStudentsList);
            studentsList.Sort(studentComparer);
        } 
    }
}
