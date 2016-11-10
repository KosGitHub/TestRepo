using System;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student._fio = "Pautov Ivan Pavlovich";
            student._formOfEducation = "Daily";
            student._course = 3;
            student._faculty = "Information Systems";
            Console.WriteLine("We have a student {0} at {1} form of education on {2} cource of {3}",
                student._fio, student._formOfEducation, student._course, student._faculty);
            Console.ReadLine();
        }
    }
    struct Student
    {
        public string _fio;
        public string _formOfEducation;
        public int _course;
        public string _faculty;
    }

}
