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

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        private bool StudentExistId(int id)
        {
            Console.WriteLine("Enter the Id", id);
            foreach (Student iStudent in students)
            {
                if (iStudent.Id == id)
                {
                 break;
                }              
                               
            }
            return false;
        }

        public void DeleteStudent()
        {
           
         
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
