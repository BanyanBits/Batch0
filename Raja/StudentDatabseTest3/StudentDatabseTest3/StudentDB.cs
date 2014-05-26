using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabseTest3
{
    class StudentDB
    {
        List<Student> students = new List<Student>();

        public int Count
        {
            get
            {
                return students.Count;
            }
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public bool IsStudentExist(int id)
        {
            foreach (var iStudent in students)
            {
                if(iStudent.Id==id)
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
                if(iStudent.Id==id)
                {
                    students.Remove(iStudent);
                    return;
                }
            }
        }

        public Student FindStudentHighestScore()
        {
            Student studentHighestMark = null;
            int highMark = 0;
            foreach (var student in students)
            {
               if(student.Total>highMark)
               {
                   highMark = student.Total;
                   studentHighestMark = student;
               }
            }
            return studentHighestMark;
        }

        public List<Student> GetAllStudentsList()
        {
            return students;
        }

        public delegate bool IsMatch(Student s);
        public List<Student> FindStudent(IsMatch isMatch)
        {
            List<Student> returnList = new List<Student>();
            foreach (var student in students)
            {
               if(isMatch(student))
               {
                   returnList.Add(student);
               }
            }
            return returnList;
        } 

        public delegate int GetMarksDelegate(Student s);
        public Student TopStudentByMarks(GetMarksDelegate getMarksMethod)
        {
            Student topStudent = null;
            int temp = 0;
            foreach (var student in students)
            {
                int marks = getMarksMethod(student);
                if(marks>temp)
                {
                    temp = marks;
                    topStudent = student;
                }
            }
            return topStudent;
        }

        public delegate bool IsGreaterB(Student a,Student b);
        public List<Student> FindSortStudents(IsGreaterB compare)
        {
            List<Student> sorted = new List<Student>(students);
            while(true)
            {
                bool swapped = false;
                for (int i = 0; i <students.Count-1; i++)
                {
                    var first = sorted[i];
                    var second = sorted[i + 1];
                    if(compare(first,second))
                    {
                        sorted[i + 1] = first;
                        sorted[i] = second;
                        swapped = true;
                    }
                }
                if(!swapped)
                {
                    break;
                }
            }
            return sorted;
        }
    }
}
