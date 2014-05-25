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
               if(iStudent.Id==id)
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
               if(student.Id==id)
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
                if(iStudent.Total>highScore)
                {
                    highScore = iStudent.Total;
                    studentWithHighestScore = iStudent;
                }
            }
            return studentWithHighestScore;
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
