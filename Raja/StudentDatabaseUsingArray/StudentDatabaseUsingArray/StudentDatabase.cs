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
            Console.WriteLine("***********************");
            for (int i = 0; i < AddedStudentRecord; i++)
            {
                Console.WriteLine("Id:{0},Name:{1},Mark1:{2},Mark2:{3},Mark3:{4}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4]);
            }
        }

        public void PrintStudentNameById()
        {
            string StudentId;
            Console.WriteLine("Enter the Student Id:");
            Console.WriteLine("*********************");
            StudentId = (Console.ReadLine());
            for (int i = 0; i < AddedStudentRecord; i++)
            {
                if (students[i, 0] == StudentId)
                {
                    Console.WriteLine("Id:{0},Name:{1},Mark1:{2},Mark2:{3},Mark3:{4}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4]);
                }
            }

        }

        public void MaximumOfMark()
        {
            Console.WriteLine("Maximum Marks Of Student");
            Console.WriteLine("************************");
            for (int i = 0; i < AddedStudentRecord; i++)
            {
                int temp;
                int mark1 = Convert.ToInt32(students[i, 2]);
                int mark2 = Convert.ToInt32(students[i, 3]);
                int mark3 = Convert.ToInt32(students[i, 4]);
                if (mark1 > mark2)
                {
                    temp = mark1;
                }
                else
                {
                    temp = mark2;

                }
                if (temp > mark3)
                {
                    Console.WriteLine(temp);
                }
                else
                {
                    Console.WriteLine(mark3);
                }
            }

        }

        public void MinimumOFMark()
        {
            Console.WriteLine("Minimum Marks Of Students");
            Console.WriteLine("**************************");
            for (int i = 0; i < AddedStudentRecord; i++)
            {
                int temp;
                int mark1 = Convert.ToInt32(students[i, 2]);
                int mark2 = Convert.ToInt32(students[i, 3]);
                int mark3 = Convert.ToInt32(students[i, 4]);
                if (mark1 < mark2)
                {
                    temp = mark1;
                }
                else
                {
                    temp = mark2;

                }
                if (temp < mark3)
                {
                    Console.WriteLine(temp);
                }
                else
                {
                    Console.WriteLine(mark3);
                }
            }

        }

        public void AverageStudentOfMark()
        {
            Console.WriteLine("Average Marks Of Students");
            Console.WriteLine("*************************");
            for (int i = 0; i < AddedStudentRecord; i++)
            {
                int Total;
                float Average;
                int mark1 = Convert.ToInt32(students[i, 2]);
                int mark2 = Convert.ToInt32(students[i, 3]);
                int mark3 = Convert.ToInt32(students[i, 4]);
                Total = mark1 + mark2 + mark3;
                Console.WriteLine("Total:{0}", Total);
                Average = Total / 3;
                Console.WriteLine("Average:{0}", Average);
            }

        }

        public void StudentOfResult()
        {

            Console.WriteLine("Student Of Result");
            Console.WriteLine("*****************");
            for (int i = 0; i < AddedStudentRecord; i++)
            {
                string Result;
                int mark1 = Convert.ToInt32(students[i, 2]);
                int mark2 = Convert.ToInt32(students[i, 3]);
                int mark3 = Convert.ToInt32(students[i, 4]);
                if (mark1 >= 40 && mark2 >= 40 && mark3 >= 40)
                {
                    Result = "Pass";
                    Console.WriteLine(Result);
                }
                else
                {
                    Result = "Fail";
                    Console.WriteLine(Result);
                }
            }
        }

        public void GradesOfStudent()
        {
            Console.WriteLine("Grade of Student");
            Console.WriteLine("*****************");
            for (int i = 0; i < AddedStudentRecord; i++)
            {
                int mark1 = Convert.ToInt32(students[i, 2]);
                int mark2 = Convert.ToInt32(students[i, 3]);
                int mark3 = Convert.ToInt32(students[i, 4]);
                if (mark1 <= 60 && mark1 >= 70)
                {
                    Console.WriteLine("c Grade");
                }

                else if (mark1 < 71 && mark1 >= 80)
                {
                    Console.WriteLine(" B Grade");
                }

                else if (mark1 < 81 && mark1 >= 90)
                {
                    Console.WriteLine("A Grade");
                }

                if (mark1 < 91 && mark1 > 100)
                {
                    Console.WriteLine("S Grade");
                }

                if (mark2 <=60 && mark2 >=70)
                {
                    Console.WriteLine("c Grade");
                }

                else if (mark2 < 71 && mark2 >=80)
                {
                    Console.WriteLine(" B Grade");
                }

                else if (mark2 < 81 && mark2 >= 90)
                {
                    Console.WriteLine("A Grade");
                }

                if (mark2 < 91 && mark2 > 100)
                {
                    Console.WriteLine("S Grade");
                }

                if (mark3 <= 60 && mark3 >= 70)
                {
                    Console.WriteLine("c Grade");
                }

                else if (mark3 < 71 && mark3 >= 80)
                {
                    Console.WriteLine(" B Grade");
                }

                else if (mark3 < 81 && mark3 >= 90)
                {
                    Console.WriteLine("A Grade");
                }

                if (mark3 < 91 && mark3 > 100)
                {
                    Console.WriteLine("S Grade");
                }


            }

        }
    }
}
