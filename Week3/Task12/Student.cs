using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Student : Person, IPrintable, IComparable<Student>
    {
        public string Faculty { get; set; }
        public byte Course { get; set; }
        public Teacher Teacher { get; set; }

        public Student(string name, byte age, string faculty, byte course) : base(name, age)
        {
            Faculty = faculty;
            Course = course;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(", faculty: {0}, course: {1}", Faculty, Course);
        }

        void IPrintable.Print()
        {
            Console.Write("IPrintable.Print in Student class - ");
            base.Print();
            Console.WriteLine(", faculty: {0}, course: {1}", Faculty, Course);
        }

        public int CompareTo(Student student)
        {
            return Name.CompareTo(student.Name);
        }

        //static object _comparatorProp;
        public static IComparer<Student> SortByCourse { get { return (IComparer<Student>) new StudentComparer(); } } 

        class StudentComparer:IComparer<Student>
        {

            //private Student _student;
            //object _property;
            //public StudentComparer(Student student)
            //{
            //    _student = student;
            //}

            int IComparer<Student>.Compare(Student student1, Student student2)
            {
                if (student1.Course > student2.Course)
                {
                    return 1;
                }
                if (student1.Course < student2.Course)
                {
                    return -1;
                }
                return 0;
            }
        }

        public override object Clone()
        {
            Teacher teacher = new Teacher(Teacher.Name, Teacher.Age, Teacher.Subject);
            Student student = new Student(Name, Age, Faculty, Course);
            student.Teacher = teacher;
            return student;
        }
    }

    static class StudentExtensions
    {
        public static string Print(this Student[] students)
        {
            string resultString = string.Empty;
            foreach (var student in students)
            {
                resultString += student.Name + ", ";
            }
            return resultString.Trim(' ', ',');
        }
    }
}
