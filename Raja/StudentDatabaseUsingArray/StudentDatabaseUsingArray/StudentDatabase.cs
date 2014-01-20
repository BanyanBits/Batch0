using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseUsingArray
{
    class StudentDatabase
    {
        string[,] students = new string[2, 5];
        int AddedStudentRecord = 0;

        public StudentDatabase(int totalStudents)
        {
            students = new string[totalStudents, 5];
        }

        public void AddStudent(int id, string name, int mark1, int mark2, int mark3)
        {
            students[AddedStudentRecord, 0] = id.ToString();
            students[AddedStudentRecord, 1] = name;
            students[AddedStudentRecord, 2] = mark1.ToString();
            students[AddedStudentRecord, 3] = mark2.ToString();
            students[AddedStudentRecord, 4] = mark3.ToString();
            AddedStudentRecord++;
        }

        public void PrintAllStudentInfo()
        {
            Console.WriteLine("All Student Infomatiom");
            for (int i = 0; i < AddedStudentRecord; i++)
            {
                Console.WriteLine("Id:{0},Name:{1},Mark1:{2},Mark2:{3},Mark3:{4}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4]);
            }
        }

        public void PrintStudentNameById()
        {
            string StudentId;
            Console.WriteLine("Enter the Student Id:");
            StudentId = (Console.ReadLine());
            for (int i = 0; i < AddedStudentRecord; i++)
            {
                if (students[i, 0] == StudentId)
                {
                    Console.WriteLine("Id:{0},Name:{1},Mark1:{2},Mark2:{3},Mark3:{4}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4]);
                }
            }

        }
    }
}
