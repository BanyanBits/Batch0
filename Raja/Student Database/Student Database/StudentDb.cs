using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Database
{
    class StudentDb
    {
        List<Student> students = new List<Student>();

        public void AddStudents(Student student)
        {
            students.Add(student);
        } 

        public List<Student> PrintStudentWithHunderdMarks()
        {
            List<Student> studentWith100Marks = new List<Student>();
            foreach (var iStudent in students)
            {
              if(iStudent.Mark1==100||iStudent.Mark2==100||iStudent.Mark3==100)
              {
                  studentWith100Marks.Add(iStudent);
              }
            }
            return studentWith100Marks;
        }

        private bool IsStudentExsit(int id)
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

        public void DeleteStudents(int id)
        {
            foreach (var student in students)
            {
                students.Remove(student);
                return;
            }
        }

        public List<Student> FindStudentWithGivenMarks(int mark1)
        {
            List<Student> studentWithGivenMarks = new List<Student>();
            foreach (var iStudent in students)
            {
                if (iStudent.Mark1 == mark1)
                {
                    studentWithGivenMarks.Add(iStudent);
                }
            }
            return studentWithGivenMarks;
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
