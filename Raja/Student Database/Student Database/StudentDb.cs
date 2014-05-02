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
            Console.WriteLine("");
            foreach (Student iStudent in students)
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
            Console.WriteLine("Enter the Id:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            foreach (var stu in students)
            {
                if (stu.Id == userInput)
                {
                    students.RemoveAt(userInput);
                    Console.WriteLine("Student has been deleted Successfully");
                }
            }
        }

        public void StudentWithTopMark()
        {
            Console.WriteLine("Enter the Mark1:");
            int mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("StudentId|StudentName");
            Console.WriteLine("*********|***********");

            foreach (var iStudent in students)
            {
                if (iStudent.Mark1 == mark1)
                {
                    Console.WriteLine("{0}       {1}", iStudent.Id, iStudent.Name);
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
