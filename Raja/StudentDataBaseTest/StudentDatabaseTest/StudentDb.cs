using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseTest
{
    class StudentDb
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
            foreach (var iStudent in students)
            {
                if (iStudent.Id == id)
                {
                    students.Remove(iStudent);
                    return;
                }
            }
        }

        public Student FindStudentWithHighestScore()
        {
            Student HighestScoreStudent = null;
            int highScore = 0;
            foreach (var iStudent in students)
            {
                if (iStudent.Total > highScore)
                {
                    highScore = iStudent.Total;
                    HighestScoreStudent = iStudent;
                }
            }
            return HighestScoreStudent;
        }

        public List<Student> FindStudentsWithGivenMarks(int marks)
        {
            List<Student> studentswithGivenMarks = new List<Student>();
            foreach (var iStudent in students)
            {
                if(iStudent.Mark1==marks||iStudent.Mark2==marks||iStudent.Mark3 == marks)
                {
                    studentswithGivenMarks.Add(iStudent);
                }
            }
            return studentswithGivenMarks;
        }

        public List<Student> AllstudentsList()
        {
            return students;
        }

        public List<Student> FindStudentsByName(string name)
        {
            List<Student> studentByName = new  List<Student>();
            foreach (var iStudent in students)
            {
                if(iStudent.Name==name)
                {
                    studentByName.Add(iStudent);
                }
            }
            return studentByName;
        }

        public List<Student> FindStudentsBySchoolName(string schoolName)
        {
            List<Student> studentBySchoolName = new List<Student>();
            foreach (var iStudent in students)
            {
                if (iStudent.SchoolName == schoolName)
                {
                    studentBySchoolName.Add(iStudent);
                }
            }
            return studentBySchoolName;
        }

        public List<Student> FindStudentsByDistrict(string district)
        {
            List<Student> studentByDistrict = new List<Student>();
            foreach (var iStudent in students)
            {
                if (iStudent.District == district)
                {
                    studentByDistrict.Add(iStudent);
                }
            }
            return studentByDistrict;
        }

        //public delegate int GetMarksDelegateMethod(Student s);
        //public Student GetTopStudent(GetMarksDelegateMethod getMethod)
        //{
        //    Student topStudent = null;
        //    int temp = 0;
        //    foreach (var iStudent in students)
        //    {
        //        int mark = getMethod(iStudent);
        //        if(mark>temp)
        //        {
        //            temp = mark;
        //            topStudent = iStudent;
        //        }
        //    }
        //    return topStudent;
        //}
        
        public Student GetTopStudent(string subjects)
        {
            Student topStudent = null;
            int temp = 0;
            foreach (var iStudent in students)
            {
                int mark = 0;
                if(subjects=="mark1")
                {
                    mark = iStudent.Mark1;
                }
                else if(subjects=="mark2")
                {
                    mark = iStudent.Mark2;
                }
                else if(subjects=="mark3")
                {
                    mark = iStudent.Mark3;
                }
                if(mark>temp)
                {
                    temp = mark;
                    topStudent = iStudent;
                }
            }
            return topStudent;
        }

        public delegate bool IsAGreaterB(Student a, Student b);
        public List<Student> SortStudents(IsAGreaterB compareMethod)
        {
            List<Student> sortStudents = new List<Student>(students);
            while(true)
            {
                bool swapped = false;
                for (int i = 0; i < sortStudents.Count-1; i++)
                {
                    var first = sortStudents[i];
                    var second = sortStudents[i + 1];
                    if(compareMethod(first,second))
                    {
                        sortStudents[i] = second;
                        sortStudents[i + 1] = first;
                        swapped = true;
                    }
                }
                if(!swapped)
                {
                    break;
                }
            }
            return sortStudents;
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
