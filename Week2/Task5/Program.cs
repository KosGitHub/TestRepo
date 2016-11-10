using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 110;

            List<Student> students = InstanceInitializer.students;
            List<Teacher> teachers = InstanceInitializer.teachers;
            InstanceInitializer.StudentTeacherAttach();
            
            #region Console output of objects
            //// Console output of students
            //foreach (var student in students)
            //{
            //    student.Print();
            //    Console.WriteLine();
            //}
            //Console.WriteLine(new string('-', 50));
            //// Console output of teachers
            //foreach (var teacher in teachers)
            //{
            //    teacher.Print();
            //    Console.WriteLine();
            //}
            #endregion

            #region  Objects compare
            //Student compareStudent = new Student("Pavlenko M.V.", 20, 3, InstanceInitializer.faculties[0]);
            //foreach (var student in students)
            //{
            //    Console.WriteLine("HashCode of {0} is {1}", compareStudent, compareStudent.GetHashCode());
            //    Console.WriteLine("HashCode of {0} is {1}", student, student.GetHashCode());
            //    if (student.Equals(compareStudent))
            //    {
            //        Console.WriteLine("They are equals");
            //    }
            //    else
            //    {
            //        Console.WriteLine("They are not equals");
            //    }
            //    Console.WriteLine(new string('-', 50));
            //}           
            #endregion

            #region Get random Person/Student/Teacher from List of Persons/Students/Teachers
            //Console.Write("Random student is: ");
            //Console.WriteLine(students.RandomPerson());
            //Console.Write("Random teacher is: ");
            //Console.WriteLine(teachers.RandomPerson());
            #endregion

            #region Calculating of students and teachers
            //List<Person> persons = new List<Person>();
            //persons.AddRange(students);
            //persons.AddRange(teachers);
            //Console.WriteLine("There are {0} students and {1} teachers.", persons.GetObjectsOfType(new Student()), persons.GetObjectsOfType(new Teacher()));
            #endregion

            #region Cloning of Person/Student/Teacher
            //List<Student> clonedStudents = new List<Student>();
            //// Cloning of our students
            //foreach (var student in students)
            //{
            //    clonedStudents.Add((Student)student.Clone());
            //}
            //// Output our original list of students
            //Console.WriteLine("Our original list of students is:");
            //foreach (var student in students)
            //{
            //    student.Print();
            //}
            //Console.WriteLine();
            //// Output our clonned list of students
            //Console.WriteLine("Our clonned list of students is:");
            //foreach (var clonedStudent in clonedStudents)
            //{
            //    clonedStudent.Print();
            //}
            //Console.WriteLine();
            //// Remove last student in our list of students
            //students.Remove(students[students.Count-1]);
            //// Output our original list of students after removing last student
            //Console.WriteLine("We removed last student from our original list of students, and now it is:");
            //foreach (var student in students)
            //{
            //    student.Print();
            //}
            //Console.WriteLine();
            //// Output our clonned list of students after removing last student from original list
            //Console.WriteLine("Our clonned list of students is:");
            //foreach (var clonedStudent in clonedStudents)
            //{
            //    clonedStudent.Print();
            //}
            #endregion

            #region Output all parents of Student type
            GetParents(new Student());
            #endregion
            Console.ReadLine();
        }

        private static void GetParents<T>(T typeObj) where T: class
        {
            Type type = typeObj.GetType();
            Console.WriteLine("Type {0} derived from:", type.FullName);
            var parentType = type;
            do
            {
                parentType = parentType.BaseType;
                if (parentType != null)
                    Console.WriteLine("   {0}", parentType.FullName);

            } while (parentType != null);
            Console.WriteLine();
        }
    }
}
