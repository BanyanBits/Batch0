using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseUsingArray
{
    class StudentDatabase
    {
        String[,] students;
        int noOfStudentAdded = 0;
        int noOfStudents;

        public StudentDatabase(int totalStudents)
        {
            students = new String[totalStudents, 5];
            this.noOfStudents = totalStudents;
        }

        public void AddStudent(int id, string name, int mark1, int mark2, int mark3)
        {
            students[noOfStudentAdded, 0] = id.ToString();
            students[noOfStudentAdded, 1] = name;
            students[noOfStudentAdded, 2] = mark1.ToString();
            students[noOfStudentAdded, 3] = mark2.ToString();
            students[noOfStudentAdded, 4] = mark3.ToString();
            noOfStudentAdded++;
        }

        public void PrintAllStudentsInfo()
        {

            for (int i = 0; i < noOfStudentAdded; i++)
            {
                Console.WriteLine("Id:{0} Name:{1} Mark1:{2} Mark2:{3} Mark3:{4}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4]);

            }

        }


        // input 1 saran 43 54 76 
        //      2 raj   65 65 98 

        //output 1 saran 43 54 76 
        //       2 raj   65 65 98 




    }
}

