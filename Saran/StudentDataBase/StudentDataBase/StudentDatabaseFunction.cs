﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBase
{
    class StudentDatabaseFunction
    {
        string[,] students;
        int AddedStudentRecord = 0;

        public StudentDatabaseFunction(int totalStudents)
        {
            students = new string[totalStudents, 6];
        }

        public void AddStudent(int id, string name, int mark1, int mark2, int mark3, string district)
        {
            students[AddedStudentRecord, 0] = id.ToString();
            students[AddedStudentRecord, 1] = name;
            students[AddedStudentRecord, 2] = mark1.ToString();
            students[AddedStudentRecord, 3] = mark2.ToString();
            students[AddedStudentRecord, 4] = mark3.ToString();
            students[AddedStudentRecord, 5] = district;
            AddedStudentRecord++;
        }

        public void PrintAllStudentInfo()
        {
            Console.WriteLine("\t\nAll Student Infomatiom");
            Console.WriteLine("*** ******* **********\n");

            Console.WriteLine("\n Id\tName\tMark1\tMark2\tMark3\tDistrict");
            Console.WriteLine(" **\t****\t*****\t*****\t*****\t**********\n");

            for (int i = 0; i < AddedStudentRecord; i++)
            {
                Console.WriteLine(" {0}\t{1}\t{2}\t{3}\t{4}\t{5}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5]);
            }
        }

        public void PrintStudentNameById()
        {
            string StudentId;
            Console.Write("\nEnter the Student Id: ");
            StudentId = (Console.ReadLine());
            Console.WriteLine("\n\n Id\t Name\t Mark1 \t Mark2\t Mark3");
            for (int i = 0; i < AddedStudentRecord; i++)
            {
                if (students[i, 0] == StudentId)
                {
                    Console.WriteLine("\n {0}\t {1}\t {2}\t {3}\t {4}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4]);
                }
            }
            Console.WriteLine("Enter the Student Valid Id Number");

        }

        public void StudentTotalMarkAndAverage()
        {
            Console.WriteLine("\n\n Id\tName\tMark1\tMark2\tMark3\tTotal\tAverage");
            Console.WriteLine(" **\t****\t*****\t*****\t*****\t*****\t*******\n");
            for (int i = 0; i < AddedStudentRecord; i++)
            {
                int total = Convert.ToInt32(students[i, 2]) + Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]);
                float average = total / 3;
                Console.WriteLine(" {0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], total, average);

            }

        }

        public void MaxMarkOfStudent()
        {
            Console.WriteLine("\n\n Id \t Name \t MaximumMark");
            Console.WriteLine(" **\t ****\t ***********");

            for (int i = 0; i < AddedStudentRecord; i++)
            {
                int mark1 = Convert.ToInt32(students[i, 2]);
                int mark2 = Convert.ToInt32(students[i, 3]);
                int mark3 = Convert.ToInt32(students[i, 4]);

                if (mark1 > mark2)
                    if (mark1 > mark3)
                        Console.WriteLine(" {0} \t{1} \t {2}", students[i, 0], students[i, 1], mark1);

                if (mark2 > mark3)
                    Console.WriteLine(" {0} \t{1} \t {2}", students[i, 0], students[i, 1], mark2);

                else
                    Console.WriteLine(" {0} \t{1} \t {2}", students[i, 0], students[i, 1], mark3);

            }
        }

        public void MinimumMarkOfStudent()
        {
            Console.WriteLine("\n\n Id \t Name \t MinimumOfMark");
            Console.WriteLine(" **\t ****\t *************");

            for (int i = 0; i < AddedStudentRecord; i++)
            {
                int mark1 = Convert.ToInt32(students[i, 2]);
                int mark2 = Convert.ToInt32(students[i, 3]);
                int mark3 = Convert.ToInt32(students[i, 4]);

                if (mark1 < mark2)
                    if (mark1 < mark3)
                        Console.WriteLine(" {0} \t{1} \t {2}", students[i, 0], students[i, 1], mark1);

                    else if (mark2 < mark3)

                        Console.WriteLine(" {0} \t{1} \t {2}", students[i, 0], students[i, 1], mark2);

                    else
                        Console.WriteLine(" {0} \t{1} \t {2}", students[i, 0], students[i, 1], mark3);

            }
        }

        public void PassOrFail()
        {
            string result;
            Console.WriteLine("\n\n Id\t Name \t Result");
            Console.WriteLine(" **\t **** \t ******\n");
            for (int i = 0; i < AddedStudentRecord; i++)
            {
                int mark1 = Convert.ToInt32(students[i, 2]);
                int mark2 = Convert.ToInt32(students[i, 3]);
                int mark3 = Convert.ToInt32(students[i, 4]);

                if (mark1 >= 40 && mark2 >= 40 && mark3 >= 40)
                {
                    result = "Pass";
                    Console.WriteLine(" {0} \t {1} \t {2}", students[i, 0], students[i, 1], result);
                }
                else
                {
                    result = "Fail";
                    Console.WriteLine(" {0} \t {1} \t {2}", students[i, 0], students[i, 1], result);
                }
            }


        }

        public void FindStudentByMark()
        {
            Console.WriteLine("\n\t\t To Find Student By Mark");
            Console.WriteLine("\t\t ** **** ******* ** ****\n");

            Console.Write("Enter the Student Mark :  ");
            string mark = Console.ReadLine();

            Console.WriteLine("\n Id \t Name \t Mark1 \t Mark2 \t Mark3 \t Address");
            Console.WriteLine(" ** \t **** \t ***** \t ***** \t ***** \t *******");

            for (int i = 0; i < AddedStudentRecord; i++)
            {
                if ((students[i, 2] == mark) || (students[i, 3] == mark) || (students[i, 4] == mark))
                {
                    Console.WriteLine(" {0}\t {1}\t {2}\t {3}\t {4} \t {5}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5]);
                }
            }
            Console.WriteLine("Enter the Student Valid Mark");
        }

        public void FindStudentByAddress()
        {
            Console.WriteLine("\n\t\t To Find Student By Address");
            Console.WriteLine("\t\t ** **** ******* ** *******\n");

            Console.Write("Enter the Student Addresss : ");
            string address = Console.ReadLine();

            Console.WriteLine("\n Id \t Name \t Address");
            Console.WriteLine(" ** \t **** \t *******");

            for (int i = 0; i < AddedStudentRecord; i++)
            {
                if (students[i, 5] == address)
                {
                    Console.WriteLine(" {0}\t {1}\t {2} ", students[i, 0], students[i, 1], students[i, 5]);
                }
            }
            Console.WriteLine("\n\nEnter the Student Valid Address");
            Console.WriteLine();
        }

        public void FindStudentFirstMark()
        {
            int temp = 0;
            int i;
            int[] rank = new int[AddedStudentRecord];
            Console.WriteLine("\t\t The State First Rank");
            Console.WriteLine("\t\t *** ***** ***** ****\n\n");
                        
            for ( i = 0; i < AddedStudentRecord; i++)
            {
                int total = Convert.ToInt32(students[i, 2]) + Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]);
                rank[i] = total;               
            }

            foreach (int total in rank)
            {
                if (temp < total)
                    temp = total;
            }
            Console.WriteLine("The State First Mark is : {0} ",temp);

        }
        
    }
}
