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

        public int Count
        {
            get
            {
                return students.Count;
            }
        }
    }
}
