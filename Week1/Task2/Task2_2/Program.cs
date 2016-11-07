using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2_2
{
    struct Student
    {
        public string firstName;
        public string lastName;
        public int age;
        public string formOfEducation;
        public int course;
        public string faculty;
        public Student(string firstName, string lastName, int age, string formOfEducation, int course, string faculty)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.formOfEducation = formOfEducation;
            this.course = course;
            this.faculty = faculty;
        }
        public override string ToString()
        {
            return String.Format("First name: {0}, second name: {1}, age: {2} years, form of education: {3}, course: {4}, faculty: {5}",
                    firstName, lastName, age, formOfEducation, course, faculty);
        }
    }
    //My realization of Compare method for students comparing by age
    class StudentComparer : IComparer<Student>
    {
        public int Compare(Student student1, Student student2)
        {
            if (student1.age > student2.age)
            {
                return 1;
            }
            if (student1.age < student2.age)
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
            //First methot of sorting by Firstname using LINQ
            foreach (var student in studentArray.OrderBy(x => x.firstName))
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Sort by _age (by method Sort(IComparer)):");
            //Second method of sorting by age using my sorting
            Array.Sort(studentArray, new StudentComparer());
            foreach (var student in studentArray)
            {
                Console.WriteLine(student.ToString());
            }
            Console.ReadLine();
        }
    }
}

