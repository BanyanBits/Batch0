using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseUsingArray
{
    class StudentDatabase
    {
        private string[,] students;
        //Id, Name, Mark1, Mark2, Mark3
        private const int noOfFields = 5;
        private int recordPointer = 0;

        public StudentDatabase(int noOfStudents)
        {
            students = new string[noOfStudents, noOfFields];
        }

        public void PrintInfo(string id)
        {
            for (int i = 0; i < recordPointer; i++)
            {
                if(students[i,0] == id)
                {
                    Console.WriteLine("Student Info: Id:{0}, Name:{1}", students[i,0], students[i,1]);
                    return;
                }
            }

            Console.WriteLine("No matching student found");
        }

        public void AddStudent(string id, string name, int mark1, int mark2, int mark3)
        {
            //Handele max students exception

            students[recordPointer, 0] = id;
            students[recordPointer, 1] = name;
            students[recordPointer, 2] = mark1.ToString();
            students[recordPointer, 3] = mark2.ToString();
            students[recordPointer, 4] = mark3.ToString();
            recordPointer++;
        }
    }
}
