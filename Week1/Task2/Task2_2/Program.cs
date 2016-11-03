using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2_2
{
    struct Student
    {
        public string _firstName;
        public string _lastName;
        public int _age;
        public string _formOfEducation;
        public int _course;
        public string _faculty;

        public Student(string firstName, string lastName, int age, string formOfEducation, int course, string faculty)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _formOfEducation = formOfEducation;
            _course = course;
            _faculty = faculty;
        }
        public override string ToString()
        {
            return String.Format("First name: {0}, second name: {1}, age: {2} years, form of education: {3}, course: {4}, faculty: {5}",
                    _firstName, _lastName, _age, _formOfEducation, _course, _faculty);
        }
    }

    class StudentComparer : IComparer<Student>
    {
        public int Compare(Student student1, Student student2)
        {
            if (student1._age > student2._age)
            {
                return 1;
            }
            if (student1._age < student2._age)
            {
                return -1;
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = new Student[]
            {
                new Student("Pavlo", "Kruglikov", 18, "Daily", 1, "Information Systems"),
                new Student("Kostyantyn", "Velukiy", 23, "Daily", 5, "Information Systems"),
                new Student("Andryi", "Volovyi", 19, "Daily", 2, "Information Systems"), 
                new Student("Olga", "Krikova", 21, "Daily", 4, "Information Systems"),
                new Student("Petro", "Matush", 20, "Daily", 3, "Information Systems")
            };

            Console.WindowWidth = 130;

            Console.WriteLine("Sort by _firstName field:");
            foreach (var student in studentArray.OrderBy(x => x._firstName))
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Sort by _age (by method Sort(IComparer)):");
            Array.Sort(studentArray, new StudentComparer());
            foreach (var student in studentArray)
            {
                Console.WriteLine(student.ToString());
            }
            Console.ReadLine();
        }
    }
}

