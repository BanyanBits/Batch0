using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseUsingArray
{
    class StudentDatabase
    {
        string[,] students;
        int noOfStudentdAdded = 0;

        public StudentDatabase(int totalStudents)
        {
            students = new string[totalStudents, 6];
        }

        public void AddStudent(int id, string name, int mark1, int mark2, int mark3, string district)
        {
            students[noOfStudentdAdded, 0] = id.ToString();
            students[noOfStudentdAdded, 1] = name;
            students[noOfStudentdAdded, 2] = mark1.ToString();
            students[noOfStudentdAdded, 3] = mark2.ToString();
            students[noOfStudentdAdded, 4] = mark3.ToString();
            students[noOfStudentdAdded, 5] = district;
            noOfStudentdAdded++;
        }

        public void PrintAllStudentInfo()
        {
            Console.WriteLine("All Student Infomatiom");
            Console.WriteLine("***********************");
            Console.WriteLine("\n\tId\tname\tMark1\tmark2\tmark3\tDistrict");
            Console.WriteLine("\t***\t*****\t****\t****\t*****\t********");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5]);
            }
        }

        public void PrintStudentNameById()
        {
            string StudentId;
            Console.Write("Enter the Student Id:");
            StudentId = (Console.ReadLine());
            Console.WriteLine("*********************");
            Console.WriteLine("\n\tId\tName\tMark1\tMark2\tMark3\tDistict");
            Console.WriteLine("\t***\t*****\t****\t****\t*****\t********");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if (students[i, 0] == StudentId)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5]);
                    return;
                }
            } Console.WriteLine("Enter Valid Id Number");

        }
        public void printStudentNameByDistrict()
        {
            string district;
            Console.Write("Enter the Student District:");
            district = Console.ReadLine();
            Console.WriteLine("************************");
            Console.WriteLine("\n\tId\tName\tDistict");
            Console.WriteLine("\t***\t*****\t********");
            int addedStudentMark = 0;
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if (students[i, 5] == district)
                {
                    addedStudentMark++;
                    Console.WriteLine("\t{0}\t{1}\t{2}", students[i, 0], students[i, 1], students[i, 5]);                 
                    
                }
            }
            Console.WriteLine("Enter the Valid Student District");
        }


        public void printStudentNameByMarks()
        {
            string studentMark;
            Console.Write("Enter the Student marks:");
            studentMark = Console.ReadLine();
            Console.WriteLine("************************");
            Console.WriteLine("\n\tId\tName\tMark1\tMark2\tMark3\tDistict");
            Console.WriteLine("\t***\t*****\t****\t****\t*****\t********");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if ((students[i, 2] == studentMark) || (students[i, 3] == studentMark) || (students[i, 4] == studentMark))
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5]);
                    return;
                }
            }
            Console.WriteLine("Enter the Valid Student Marks");
        }

        public void MaximumOfMark()
        {
            Console.WriteLine("Maximum Marks Of Student");
            Console.WriteLine("************************");
            for (int i = 0; i < noOfStudentdAdded; i++)
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
            for (int i = 0; i < noOfStudentdAdded; i++)
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
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int total;
                float Average;
                int mark1 = Convert.ToInt32(students[i, 2]);
                int mark2 = Convert.ToInt32(students[i, 3]);
                int mark3 = Convert.ToInt32(students[i, 4]);
                total = mark1 + mark2 + mark3;
                Console.WriteLine("Total:{0}", total);
                Average = total / 3;
                Console.WriteLine("Average:{0}", Average);               
            }

        }

        public void StudentOfResult()
        {

            Console.WriteLine("Student Of Result");
            Console.WriteLine("*****************");
            for (int i = 0; i < noOfStudentdAdded; i++)
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

        private string GradeOfStudent(int mark)
        {
            if (mark >= 50 && mark >= 70)
                return "C Grade";
            else if (mark > 71 && mark >= 80)
                return "B Grade";
            else if (mark < 90)
                return "A Grade";
            else
                return "S Grade";
        }

        public void GradePriority()
        {
            Console.WriteLine("Grade of Student");
            Console.WriteLine("*****************");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int mark1 = Convert.ToInt32(students[i, 2]);
                int mark2 = Convert.ToInt32(students[i, 3]);
                int mark3 = Convert.ToInt32(students[i, 4]);
                Console.WriteLine(GradeOfStudent(mark1));
                Console.WriteLine(GradeOfStudent(mark2));
                Console.WriteLine(GradeOfStudent(mark3));
            }

        }
    }
}
