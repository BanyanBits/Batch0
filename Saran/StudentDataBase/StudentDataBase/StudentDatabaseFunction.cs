using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBase
{
    class StudentDatabaseFunction
    {
        string[,] students = new string[2, 5];
        int AddedStudentRecord = 0;

        public StudentDatabaseFunction(int totalStudents)
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
            Console.WriteLine("\t\nAll Student Infomatiom");
            Console.WriteLine("*** ******* **********\n");
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
            Console.WriteLine("Enter the Student Valid Id Number");




        }

        public void StudentTotalMark()
        {
            for (int i = 0; i < AddedStudentRecord; i++)
            {
                int total = Convert.ToInt32(students[i, 2]) + Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]);
                float average = total / 3;
                Console.WriteLine("Id:{0},Name:{1},Mark1:{2},Mark2:{3},Mark3:{4},Total : {5},Average : {6}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], total, average);

            }

        }

    }
}
