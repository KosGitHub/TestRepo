using System;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.fio = "Pautov Ivan Pavlovich";
            student.formOfEducation = "Daily";
            student.course = 3;
            student.faculty = "Information Systems";
            Console.WriteLine("We have a student {0} at {1} form of education on {2} cource of {3}",
                student.fio, student.formOfEducation, student.course, student.faculty);
            Console.ReadLine();
        }
    }
    struct Student
    {
        public string fio;
        public string formOfEducation;
        public int course;
        public string faculty;
    }
}
