using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 105;
            List<Student> studentList = new List<Student>()
            {
                new Student("Nechui Ivan Petrovych", 3, new List<Exam>(){new Exam("History",3), new Exam("Mathematics",4), new Exam("Physics",5)}),
                new Student("Polyova Olga Volodymyrivna", 2, new List<Exam>(){new Exam("History",5), new Exam("Mathematics",3), new Exam("Physics",3)}),
                new Student("Korzun Volodymyr Ivanovych", 1, new List<Exam>(){new Exam("History",4), new Exam("Mathematics",4), new Exam("Physics",5)}),
                new Student("Holosha Sergiy Anatolievych", 3, new List<Exam>(){new Exam("History",3), new Exam("Mathematics",3), new Exam("Physics",4)}),
                new Student("Golova Anna Mychailivna", 1, new List<Exam>(){new Exam("History",4), new Exam("Mathematics",5), new Exam("Physics",3)}),
            };
            //First methot using LINQ
            //List<Student> sortedStudentList =
            //    studentList.OrderBy(x => x.GroupNumber).Where(x => x.Exams.Sum(y => y.Mark) >= 12).ToList();//average mark >=4 ==> exam handed
            //foreach (var student in sortedStudentList)
            //{
            //    Console.WriteLine(student.ToString());
            //}
            //
            //Second method using my sorting
            studentList.SortByExams(new StudentComparerByGroup());

            foreach (var student in studentList)
            {
                Console.WriteLine(student.ToString());
            }
            Console.Read();
        }
    }
    class Student
    {
        public string Fio { get; set; }
        public byte GroupNumber { get; set; }
        public List<Exam> Exams {get; set; } 
        public Student(string fio, byte groupNumber, List<Exam> exams )
        {
            this.Fio = fio;
            this.GroupNumber = groupNumber;
            this.Exams = exams;
        }
        public string PrintExams(List<Exam> exams)
        {
            string resultString = String.Empty;
            foreach (var exam in exams)
            {
                resultString += String.Format("{0} - {1}; ", exam.Subject, exam.Mark);
            }
            return resultString;
        }
        public override string ToString()
        {
            return String.Format("Fio: {0}, group number: {1}, exams: {2}",
                    Fio, GroupNumber, PrintExams(Exams));
        }
    }
    //My realization of Compare method for students comparing by age
    class StudentComparerByGroup : IComparer<Student>
    {
        public int Compare(Student student1, Student student2)
        {
            if (student1.GroupNumber > student2.GroupNumber)
            {
                return 1;
            }
            if (student1.GroupNumber < student2.GroupNumber)
            {
                return -1;
            }
            return 0;
        }
    }
    static class StudentExtension
    {
        //Extension method for filtration of studentsList and compare by Age (with my own comparer)
        public static void SortByExams(this List<Student> studentsList, IComparer<Student> studentComparer)
        {
            List<Student> tempStudentsList = new List<Student>();
            foreach (var student in studentsList)
            {
                byte sum = 0;
                foreach (var exam in student.Exams)
                {
                    sum += exam.Mark;
                }
                if (sum>=12)
                {
                    tempStudentsList.Add(student);
                }
            }
            studentsList.Clear();
            studentsList.AddRange(tempStudentsList);
            studentsList.Sort(studentComparer);
        }
    }
    class Exam
    {
        public string Subject { get; set; }
        public byte Mark { get; set; }

        public Exam(string subject, byte mark)
        {
            this.Subject = subject;
            this.Mark = mark;
        }
    }
}
