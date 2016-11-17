using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Teacher: Person, IPrintable
    {
        public string Subject { get; set; }
        public List<Student> Students { get; set; }

        public Teacher(string name, byte age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(", subject: {0}", Subject);
        }

        void IPrintable.Print()
        {
            Console.Write("IPrintable.Print in Teacher class - ");
            base.Print();
            Console.WriteLine(", subject: {0}", Subject);
        }

        public override object Clone()
        {
            List<Student> students = new List<Student>();
            foreach (var student in Students)
            {
                students.Add((Student)student.Clone());
            }
            Teacher teacher = new Teacher(Name, Age, Subject);
            teacher.Students = students;
            return teacher;
        } 
    }
}
