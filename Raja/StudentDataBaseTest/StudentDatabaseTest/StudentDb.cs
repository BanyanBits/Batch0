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

        public int Count
        {
            get
            {
                return students.Count;
            }
        }
    }
}
