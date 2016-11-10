using System;
using System.Collections.Generic;

namespace Task5
{
    class Teacher : Person
    {
        public string AcademicDegree { get; set; }
        public Subject Subject { get; set; }
        public List<Student> Students { get; set; }
        public Teacher() { }
        public Teacher(string fio, byte age, string academicDegree, Subject subject)
            : base(fio, age)
        {
            this.AcademicDegree = academicDegree;
            this.Subject = subject;
        }

        public override void Print()
        {
            base.Print();
            Console.Write(", academic degree: {0}, subject: {1}, students: {2}\n", this.AcademicDegree, this.Subject, this.Students.Print());
        }

        // My override of ToString() method for Teacher
        //public override string ToString()
        //{
        //    return base.ToString() + string.Format(", academic degree: {0}, subject: {1}", this.AcademicDegree, this.Subject);
        //}

        // My override of GetHashCode() method for Teacher
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        // My override of Equals() method for Teacher
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Teacher teacher = (Teacher)obj;
            return (base.Equals(teacher) 
                && this.AcademicDegree == teacher.AcademicDegree 
                && this.Subject.subjectId == teacher.Subject.subjectId);
        }

        // My override of virtual Clone() method for Teacher class
        public override object Clone()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < this.Students.Count; i++)
            {
                students.Add((Student)this.Students[i].Clone());
            }
            return new Teacher()
            {
                Fio = this.Fio,
                Age = this.Age,
                AcademicDegree = this.AcademicDegree,
                Subject = this.Subject,
                Students = students
            };
        }
    }
}
