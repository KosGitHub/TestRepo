using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    static class InstanceInitializer
    {

        public static List<Subject> subjects = new List<Subject>
        {
            new Subject(1, "Programming"),
            new Subject(2, "Global Socialogy")
        };
        public static List<Faculty> faculties = new List<Faculty>
        {
            new Faculty(1, "Information Systems"),
            new Faculty(2, "Socialogy")
        };
        //Create a list of students
        public static List<Student> students = new List<Student>
        {
            new Student("Pavlenko M.V.", 20, 3, faculties[0]),
            new Student("Gudz O.M.", 20, 3, faculties[0]),
            new Student("Kruglikov P.O.", 20, 3, faculties[0]),
            new Student("Tkachenko V.P.", 20, 3, faculties[0]),
            new Student("Popov A.M.", 20, 3, faculties[0]),
            new Student("Lavrenko O.M.", 22, 5, faculties[1]),
            new Student("Dyachenko I.L.", 22, 5, faculties[1]),
            new Student("Krug V.O.", 22, 5, faculties[1]),
            new Student("Biluy A.R.", 22, 5, faculties[1]),
            new Student("Polyovuy D.P.", 22, 5, faculties[1])
        };
        public static List<Teacher> teachers = new List<Teacher>
        {
            new Teacher("Holosha S.A.", 45, "Doctor", subjects[0]),
            new Teacher("Veluchko A.M.", 33, "Doctor candidate", subjects[1])
        };
        
        // Method of the attaching teachers with students
        public static void StudentTeacherAttach()
        {
            // At first we attach teachers to the students instances
            foreach (var student in students)
            {
                if (student.Faculty.facultyId == faculties[0].facultyId)
                {
                    student.Teacher = teachers[0];
                }
                else
                {
                    student.Teacher = teachers[1];
                }
            }
            // Secondary we attach students to the teachers instances
            foreach (var teacher in teachers)
            {
                teacher.Students = new List<Student>();
                if (teacher.Subject.subjectId == subjects[0].subjectId) // if teacher is teacher of the first subject
                {
                    //teacher.Students = students.Where(x => x.Faculty.facultyId == 1).ToList(); // LINQ variant for solution
                    // Another solution of students finding for teachers (with foreach)
                    foreach (var student in students)
                    {
                        if (student.Faculty.facultyId == faculties[0].facultyId)
                        {
                            teacher.Students.Add(student);
                        }
                    }
                }
                else // if teacher is teacher of the secon subject
                {
                    //teacher.Students = students.Where(x => x.Faculty.facultyId == 2).ToList(); // LINQ variant for solution
                    // Another solution of students finding for teachers (with foreach)
                    foreach (var student in students)
                    {
                        if (student.Faculty.facultyId == faculties[1].facultyId)
                        {
                            teacher.Students.Add(student);
                        }
                    }
                }
            }
        }
    }
}
