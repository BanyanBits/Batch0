using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseTest1
{
    class SttudentDb
    {
        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public bool IsStudentExist(int id)
        {
            foreach (var iStudent in students)
            {
                if (iStudent.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public void DeleteStudent(int id)
        {
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    students.Remove(student);
                    return;
                }
            }
        }

        public Student FindStudentWithHighestScore()
        {
            Student studentWithHighestScore = null;
            int highScore = 0;
            foreach (var iStudent in students)
            {
                if (iStudent.Total > highScore)
                {
                    highScore = iStudent.Total;
                    studentWithHighestScore = iStudent;
                }
            }
            return studentWithHighestScore;
        }

        public List<Student> PrintStudentList()
        {
            return students;
        }

        public List<Student> FindStudentsByName(String name)
        {
            List<Student> studentsByName = new List<Student>();
            foreach (var student in students)
            {
                if (student.Name == name)
                {
                    studentsByName.Add(student);
                }
            }
            return studentsByName;
        }

        public List<Student> FindStudentsBySchoolName(String schoolName)
        {
            List<Student> studentsBySchoolName = new List<Student>();
            foreach (var student in students)
            {
                if (student.SchoolName== schoolName)
                {
                    studentsBySchoolName.Add(student);
                }
            }
            return studentsBySchoolName;
        }
        public delegate bool IsAGreaterB(Student a, Student b);
        public List<Student> SortStudents(IsAGreaterB compareMethod)
        {
            List<Student> sortStudents = new List<Student>(students);
            while (true)
            {
                bool swapped = false;
                for (int i = 0; i < sortStudents.Count - 1; i++)
                {
                    var first = sortStudents[i];
                    var second = sortStudents[i + 1];
                    if (compareMethod(first, second))
                    {
                        sortStudents[i] = second;
                        sortStudents[i + 1] = first;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
            return sortStudents;
        }

        public Student TopStudentByMarks(string subject)
        {
            Student topStudent = null;
            int temp = 0;
            foreach (var iStudent in students)
            {
                int marks=0;
                if(subject=="mark1")
                {
                    marks = iStudent.Mark1;
                }
                else if(subject=="mark2")
                {
                    marks = iStudent.Mark2;
                }
                else if(subject=="mark3")
                {
                    marks = iStudent.Mark3;
                }
                if(marks>temp)
                {
                    temp = marks;
                    topStudent = iStudent;
                }
            }
            return topStudent;
        }

        public List<Student> FindStudentsByDistrict(String district)
        {
            List<Student> studentsByDistrict = new List<Student>();
            foreach (var student in students)
            {
                if (student.District == district)
                {
                    studentsByDistrict.Add(student);
                }
            }
            return studentsByDistrict;
        }

        public List<Student> FindStudentWithMarks(int marks)
        {
            List<Student> studentWithMarks = new List<Student>();
            foreach (var iStudent in students)
            {
                if (iStudent.Mark1 == marks || iStudent.Mark2 == marks || iStudent.Mark3 == marks)
                {
                    studentWithMarks.Add(iStudent);
                }
            }
            return studentWithMarks;
        }

        public int Count
        {
            get
            {
                return students.Count;
            }
        }
    }
}
