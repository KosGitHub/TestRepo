using System;
using System.Collections.Generic;

namespace Task5
{
    class Student : Person
    {
        public byte Course { get; set; }
        public Faculty Faculty { get; set; }
        public Teacher Teacher { get; set; }
        public Student(string fio, byte age, byte course, Faculty faculty)
            : base(fio, age)
        {
            this.Course = course;
            this.Faculty = faculty;
        }
        public Student() { }
        public override void Print()
        {
            base.Print();
            Console.Write(", course: {0}, faculty: {1}, treacher: {2}\n", this.Course, this.Faculty, this.Teacher);
        }

        // My override of ToString() method for Student
        //public override string ToString()
        //{
        //    return base.ToString() + string.Format(", course: {0}, faculty: {1}", this.Course, this.Faculty.ToString());
        //}

        // My override of GetHashCode() method for Student
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        // My override of Equals() method for Student
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Student student = (Student) obj;
            return (base.Equals(student) && 
                this.Course == student.Course &&
                this.Faculty.facultyId == student.Faculty.facultyId);
        }

        // My override of virtual Clone() method for Student class
        public override object Clone()
        {
            Teacher teacher = new Teacher(this.Fio, this.Age, this.Teacher.AcademicDegree, this.Teacher.Subject);
            return new Student()
            {
                Fio = this.Fio,
                Age = this.Age,
                Course = this.Course,
                Faculty = this.Faculty,
                Teacher = teacher
            };
        }
    }

    // Extension class for List<Student>
    static class StudentExtenshion
    {
        // Extenshion method Print() for List<Student> - needed in Teacher.Print
        public static string Print(this List<Student> students)
        {
            string resultString = string.Empty;
            foreach (var student in students)
            {
                resultString += string.Format("{0}, ", student.Fio);
            }
            return resultString;
        }
    }
}
