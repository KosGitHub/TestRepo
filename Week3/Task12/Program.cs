using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
#region 12.1
            Teacher teacher1 = new Teacher("Joanna Male", 41, "History");
            Student student1 = new Student("Bill Norman", 20, "Information System", 3);
            student1.Teacher = teacher1;
            student1.Print();
            IPrintable student2 = student1;
            student2.Print();
            Console.WriteLine(new string('-', 50));
#endregion
#region 12.2
            Student[] studentsArray = new Student[]
            {
                new Student("Bill Norman", 20, "Information System", 3),
                new Student("John Heui", 19, "Information System", 2),
                new Student("Paul McCalister", 21, "Information System", 4),
                new Student("Helen Batler", 20, "Information System", 3),
                new Student("Martina Luciano", 22, "Information System", 5)
            };
            Console.WriteLine("Array of students before Sorting by name (using IComparable<Student>.CompareTo):");
            Console.WriteLine(studentsArray.Print());
            Array.Sort(studentsArray);
            Console.WriteLine("Array of students after Sorting by name (using IComparable<Student>.CompareTo):");
            Console.WriteLine(studentsArray.Print());
            Console.WriteLine(new string('-', 50));
            #endregion
#region 12.3
            Array.Sort(studentsArray, Student.SortByCourse);
            Console.WriteLine("Array of students after Sorting by course (using IComparer<Student>.Compare):");
            Console.WriteLine(studentsArray.Print());
            Console.WriteLine(new string('-', 50));
            #endregion
#region 12.4
            foreach (var student in studentsArray)
            {
                student.Teacher = teacher1;
            }
            teacher1.Students = new List<Student>();
            teacher1.Students.AddRange(studentsArray);
            Teacher teacher2 = (Teacher)teacher1.Clone();
            teacher2.Name = "Ann Moderra";
            teacher2.Age = 39;
            teacher2.Subject = "Socialogy";
            Console.Write("teacher1:    "); teacher1.Print();
            Console.Write("teacher1:    "); teacher2.Print();

            Student student3 = (Student)student1.Clone();
            student3.Name = "Renald";
            student3.Teacher = teacher2;
            Console.Write("student1:    "); student1.Print();
            Console.Write("student2:    "); student3.Print();
            Console.Write("student1.Teacher:    "); student1.Teacher.Print();
            Console.Write("student3.Teacher:    "); student3.Teacher.Print();

            #endregion
#region 12.5
            using (student1)
            {
                //Checking Dispose() method
            }
            Console.WriteLine(new string('-', 50));
#endregion
#region 12.6
            Persons persons = new Persons();
            persons.Add(student1);
            persons.Add(teacher1);
            persons.AddRange(studentsArray);
            persons.Add(teacher2);
            string personsList = string.Empty;
            foreach (Person person in persons)
            {
                personsList += persons.IndexOf(person) + 1 + " " + person.Name + " - " + person.GetType().Name + "\n";
            }
            Console.WriteLine("List of persons from container Persons:\n{0}",personsList);
#endregion
            Console.ReadLine();
        }
    }
}
