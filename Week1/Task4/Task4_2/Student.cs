using System;
using System.Collections.Generic;

namespace Task4_2
{
    class Student
    {
        public string Fio { get; set; }
        public byte GroupNumber { get; set; }
        public List<Exam> Exams { get; set; }
        public Student(string fio, byte groupNumber, List<Exam> exams)
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
        public static void SortByExams(this List<Student> studentsList)
        {
            List<Student> tempStudentsList = new List<Student>();
            foreach (var student in studentsList)
            {
                byte sum = 0;
                foreach (var exam in student.Exams)
                {
                    sum += exam.Mark;
                }
                if (sum >= 12)//average mark is "4" in in 3 subjects
                {
                    tempStudentsList.Add(student);
                }
            }
            studentsList.Clear();
            studentsList.AddRange(tempStudentsList);
        }
    }
}
