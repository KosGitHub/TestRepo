using System;
using System.Collections.Generic;

namespace Task4_1
{
    class Student
    {
        public string Fio { get; set; }
        public int YearOfBirth { get; set; }
        public string Address { get; set; }
        public string School { get; set; }

        public Student(string fio, int yearOfBirth, string address, string school)
        {
            this.Fio = fio;
            this.YearOfBirth = yearOfBirth;
            this.Address = address;
            this.School = school;
        }
        public override string ToString()
        {
            return String.Format("Fio: {0}, year of birthday: {1}, address: {2}, school: {3}",
                    Fio, YearOfBirth, Address, School);
        }
    }
    //My realization of Compare method for students comparing by age
    class StudentComparerByAge : IComparer<Student>
    {
        public int Compare(Student student1, Student student2)
        {
            if (student1.YearOfBirth > student2.YearOfBirth)
            {
                return 1;
            }
            if (student1.YearOfBirth < student2.YearOfBirth)
            {
                return -1;
            }
            return 0;
        }
    }
    static class StudentExtension
    {
        //Extension method for filtration of studentsList and compare by Age (with my own comparer)
        public static void SortBySchool(this List<Student> studentsList, string schoolName)
        {
            List<Student> tempStudentsList = new List<Student>();
            foreach (var student in studentsList)
            {
                if (student.School == schoolName)
                {
                    tempStudentsList.Add(student);
                }
            }
            studentsList.Clear();
            studentsList.AddRange(tempStudentsList);
        }
    }
}
