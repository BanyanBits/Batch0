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
        int noOfStudentdAdded = 0;

        public StudentDatabaseFunction(int totalStudents)
        {
            students = new string[totalStudents, 9];
        }

        public void AddStudent(int id, string name, string lastname, int mark1, int mark2, int mark3, int mark4, int mark5, string district)
        {
            students[noOfStudentdAdded, 0] = id.ToString();
            students[noOfStudentdAdded, 1] = name;
            students[noOfStudentdAdded, 2] = lastname;
            students[noOfStudentdAdded, 3] = mark1.ToString();
            students[noOfStudentdAdded, 4] = mark2.ToString();
            students[noOfStudentdAdded, 5] = mark3.ToString();
            students[noOfStudentdAdded, 6] = mark4.ToString();
            students[noOfStudentdAdded, 7] = mark5.ToString();
            students[noOfStudentdAdded, 8] = district;
            noOfStudentdAdded++;
        }

        public void PrintAllStudentInfo()
        {
            int totalStudent = 0;

            Console.WriteLine("\t\nAll Student Infomatiom");
            Console.WriteLine("*** ******* **********\n");

            Console.WriteLine("\n Id\tName\tLastName\tMark1\tMark2\tMark3\tMark4\tMark5\tDistrict");
            Console.WriteLine(" **\t****\t********\t*****\t*****\t*****\t*****\t*****\t********\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                totalStudent++;
                Console.WriteLine(" {0}\t{1}\t{2}\t\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8]);
            }
            Console.WriteLine();
            Console.Write("Total Number Of Student Are  : ");
            Console.WriteLine(totalStudent);
            Console.WriteLine();
        }

        public void PrintStudentNameById(string studentId)
        {
            string matchingStudentId = studentId;
            //String studentId;
            //Console.Write("\n Enter the Student Id: ");
            //studentId = (Console.ReadLine());

            Console.WriteLine("\nId\tName\tLastName\tMark1\tMark2\tMark3\tMark4\tMark5\tDistrict");
            Console.WriteLine("**\t****\t********\t*****\t*****\t*****\t*****\t*****\t********\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if (students[i, 0] == matchingStudentId)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8]);
                }
            }
            Console.WriteLine();
            int studentIdOutOfRange = Convert.ToInt32(matchingStudentId);

            if (studentIdOutOfRange > noOfStudentdAdded)
            {
                Console.WriteLine("Enter The Valid Student Id Number  \n");
            }
            Console.WriteLine();

        }

        public void StudentTotalMarkAndAverage()
        {
            int numberOfStudent = 0;
            Console.WriteLine("\n\n Id\tName\tLastName\tMark1\tMark2\tMark3\tMarrk4\tMark5\tTotal\tAverage\tDistrict");
            Console.WriteLine(" **\t****\t********\t*****\t*****\t*****\t*****\t*****\t*****\t*******\t********\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                numberOfStudent++;
                int total = Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]) + Convert.ToInt32(students[i, 5]) + Convert.ToInt32(students[i, 6]) + Convert.ToInt32(students[i, 7]);
                float average = total / 5;
                Console.WriteLine(" {0}\t{1}\t{2}\t\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\n", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], total, average, students[i, 8]);

            }

            Console.WriteLine();
            Console.Write("The Total Student Are   :  ");
            Console.WriteLine(numberOfStudent);
            Console.WriteLine();

        }

        public void MaxMarkOfStudent()
        {
            int numberOfStudent = 0;

            Console.WriteLine("\nId\tName\tLastName\tMark1\tMark2\tMark3\tMark4\tMark5\tMaximumMark");
            Console.WriteLine("**\t****\t********\t*****\t*****\t*****\t*****\t*****\t***********\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                numberOfStudent++;
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);

                int[] marks = new int[5] { mark1, mark2, mark3, mark4, mark5 };
                int maxMark = 0;

                foreach (int j in marks)
                    if (maxMark < j)
                        maxMark = j;

                Console.WriteLine(" {0}\t{1}\t{2}\t\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\n", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], maxMark);
            }
            Console.WriteLine();
            Console.WriteLine("The Number of Student Are  :  {0} \n ", numberOfStudent);
        }

        public void MinimumMarkOfStudent()
        {
            int numberOfStudent = 0;
            Console.WriteLine("\nId\tName\tLastName\tMark1\tMark2\tMark3\tMark4\tMark5\tMinimumMark");
            Console.WriteLine("**\t****\t********\t*****\t*****\t*****\t*****\t*****\t***********\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                numberOfStudent++;
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);

                int[] marks = new int[5] { mark1, mark2, mark3, mark4, mark5 };
                int minMark = 100;

                foreach (int j in marks)
                    if (minMark > j)
                        minMark = j;

                Console.WriteLine(" {0}\t{1}\t{2}\t\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\n", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], minMark);
            }

            Console.WriteLine();
            Console.WriteLine("The Number of Student Are  :  {0} \n ", numberOfStudent);
        }

        public void PassOrFail()
        {
            string result;
            Console.WriteLine("\nId\tName\tLastName\tResult");
            Console.WriteLine("**\t****\t********\t******\n");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);

                if (mark1 >= 40 && mark2 >= 40 && mark3 >= 40 && mark4 >= 40 && mark5 >= 40)
                {

                    result = "Pass";
                    Console.WriteLine(" {0}\t{1}\t{2}\t\t{3}\n", students[i, 0], students[i, 1], students[i, 2], result);
                }
                else
                {
                    result = "Fail";
                    Console.WriteLine(" {0}\t{1}\t{2}\t\t{3}\n", students[i, 0], students[i, 1], students[i, 2], result);
                }
            }


        }

        public void FindStudentByMark(string mark)
        {
            int matchingStudentCount = 0;

            Console.WriteLine("\n\t\t To Find Student By Mark");
            Console.WriteLine("\t\t ** **** ******* ** ****\n");

            Console.WriteLine("\n Id \t Name \t LastName \t Mark1 \t Mark2 \t Mark3 \t Mark4 \t Mark5 \t District");
            Console.WriteLine(" ** \t **** \t ******** \t ***** \t ***** \t ***** \t ***** \t ***** \t ********\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if ((students[i, 3] == mark) || (students[i, 4] == mark) || (students[i, 5] == mark) || (students[i, 6] == mark) || (students[i, 7] == mark))
                {
                    matchingStudentCount++;
                    Console.WriteLine(" {0} \t {1} \t {2} \t\t {3} \t {4} \t {5} \t {6} \t {7} \t {8}\n", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("\t {0}'  Students having {1} Mark ", matchingStudentCount, mark);

            if (matchingStudentCount == 0)
            {
                Console.WriteLine("Enter the Student Valid Mark");
            }
            Console.WriteLine();
        }

        public void FindStudentByDistrict(string district)
        {
            int numberOfStudent = 0;
            string studentDistrict = district;

            Console.WriteLine("\n\t\t To Find Student By District");
            Console.WriteLine("\t\t ** **** ******* ** *******\n");



            Console.WriteLine("\nId\tName\tLastName\tMark1\tMark2\tMark3\tMark4\tMark5\tDistrict");
            Console.WriteLine("**\t****\t********\t*****\t*****\t*****\t*****\t*****\t*********\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if (students[i, 8] == studentDistrict)
                {
                    numberOfStudent++;
                    Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\n ", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("\n The Number Of students Of this Districts  : {0}", numberOfStudent);

            if (numberOfStudent == 0)
            {
                Console.WriteLine("\n\nEnter the Student Valid District");
            }
            Console.WriteLine();
        }

        public void FindStudentFirstMark()
        {
            int temp = 0;
            int student = 0;

            Console.WriteLine("\t\t The State First Rank");
            Console.WriteLine("\t\t *** ***** ***** ****\n\n");
            Console.WriteLine("\t Id \t Name \t LastName \t Mark1 \t Mark2 \t Mark3 \t Mark4 \t Mark5 \t HighestMark \t Districk ");
            Console.WriteLine("\t ** \t **** \t ******** \t ***** \t ***** \t ***** \t ***** \t ***** \t *********** \t ********\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int total = Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]) + Convert.ToInt32(students[i, 5]) + Convert.ToInt32(students[i, 6]) + Convert.ToInt32(students[i, 7]);

                if (temp < total)
                {
                    temp = total;
                    student = i;
                }
            }
            Console.WriteLine("\t {0} \t {1} \t {2} \t\t {3} \t {4} \t {5} \t {6} \t {7} \t {8} \t\t {9}\n\n", students[student, 0], students[student, 1], students[student, 2], students[student, 3], students[student, 4], students[student, 5], students[student, 6], students[student, 7], temp, students[student, 8]);

            Console.WriteLine("\n The Number Of Student is : {0} \n\n", noOfStudentdAdded);
        }

        public void FindTopStudentGivenDistrict(string studentDistrict)
        {
            int temp = 0;
            int student = 0;
            int noOfStudentDistrict = 0;
            string districtStudent = studentDistrict;

            Console.WriteLine("\n\t\t To Find Top Mark  By District");
            Console.WriteLine("\t\t ** **** *** **** ** ********\n");



            Console.WriteLine("\nId\tName\tLastName\tMark1\tMark2\tMark3\tMark4\tMark5\tDistrict\tHighestMark");
            Console.WriteLine("**\t****\t********\t*****\t*****\t*****\t*****\t*****\t********\t************\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if (students[i, 8] == districtStudent)
                {
                    noOfStudentDistrict++;
                    int total = Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]) + Convert.ToInt32(students[i, 5]) + Convert.ToInt32(students[i, 6]) + Convert.ToInt32(students[i, 7]);
                    if (temp < total)
                    {
                        temp = total;
                        student = i;
                    }
                }
            }
            Console.WriteLine("{0} \t {1} \t {2} \t\t {3} \t {4} \t {5} \t {6} \t {7} \t {8} \t\t{9} \n", students[student, 0], students[student, 1], students[student, 2], students[student, 3], students[student, 4], students[student, 5], students[student, 6], students[student, 7], students[student, 8], temp);
            Console.WriteLine("\n The Number Of Student is : {0} \n", noOfStudentDistrict);
            Console.WriteLine();

        }

        public void FindOutHighestMarkOfEachDistrict()
        {
            string[] uniqueDistricts = new string[noOfStudentdAdded];

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                string tempDistrict = students[i, 8];
                bool districtNotFound = true;

                for (int j = 0; j < uniqueDistricts.Length; j++)
                {
                    if (tempDistrict == uniqueDistricts[j])
                    {
                        districtNotFound = false;
                        break;
                    }
                }

                if (districtNotFound)
                {
                    for (int k = 0; k < uniqueDistricts.Length; k++)
                    {
                        if (uniqueDistricts[k] == null)
                        {
                            uniqueDistricts[k] = tempDistrict;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("\n\t\t To Find Top Mark  By District");
            Console.WriteLine("\t\t ** **** *** **** ** ********\n");
            Console.WriteLine("\nId\tName\tLastName\tMark1\tMark2\tMark3\tMark4\tMark5\tDistrict\tHighestMark");
            Console.WriteLine("**\t****\t********\t*****\t*****\t*****\t*****\t*****\t********\t************\n");


            foreach (var num1 in uniqueDistricts)
            {

                FindTopStudentEachDistrict(num1);
            }
        }


        public void FindTopStudentEachDistrict(string studentDistrict)
        {
            int temp = 0;
            int student = 0;
            string districtStudent = studentDistrict;

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if (students[i, 8] == districtStudent)
                {
                    int total = Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]) + Convert.ToInt32(students[i, 5]) + Convert.ToInt32(students[i, 6]) + Convert.ToInt32(students[i, 7]);
                    if (temp < total)
                    {
                        temp = total;
                        student = i;
                    }
                }


            }
            Console.WriteLine("{0} \t {1} \t {2} \t\t {3} \t {4} \t {5} \t {6} \t {7} \t {8} \t\t{9} \n", students[student, 0], students[student, 1], students[student, 2], students[student, 3], students[student, 4], students[student, 5], students[student, 6], students[student, 7], students[student, 8], temp);
            Console.WriteLine();

        }


        public void FindStudentsGivenMarkRange()   // To Find  ( 80 - 100 ) having mark of the students
        {
            Console.WriteLine("\n\t These Students are Having above 80 Marks");
            Console.WriteLine("\t ***** ******** *** ****** ***** ** *****\n");

            Console.WriteLine("\n Id\tName\tLastName\tMark1\tMark2\tMark3\tMark4\tMark5\tDistrict\tTotal");
            Console.WriteLine(" **\t****\t********\t*****\t*****\t*****\t*****\t*****\t********\t*****\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);

                int total = mark1 + mark2 + mark3 + mark4 + mark5;

                if (((mark1 >= 80) && (mark1 <= 100)) || ((mark2 >= 80) && (mark2 <= 100)) || ((mark4 >= 80) && (mark4 <= 100)) || ((mark5 >= 80) && (mark5 <= 100)))
                {
                    Console.WriteLine(" {0}\t{1}\t{2}\t\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t\t{9}\n", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5],students[i, 6],students[i, 7],students[i, 8], total);
                }
            }
            Console.WriteLine();
        }


    }
}
