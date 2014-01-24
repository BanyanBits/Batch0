using System;
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
            students[noOfStudentdAdded, 2] = mark1.ToString();
            students[noOfStudentdAdded, 3] = mark2.ToString();
            students[noOfStudentdAdded, 4] = mark3.ToString();
            students[noOfStudentdAdded, 5] = district;
            noOfStudentdAdded++;
        }

        public void PrintAllStudentInfo()
        {
            Console.WriteLine("\t\nAll Student Infomatiom");
            Console.WriteLine("*** ******* **********\n");

            Console.WriteLine("\n Id\tName\tMark1\tMark2\tMark3\tDistrict");
            Console.WriteLine(" **\t****\t*****\t*****\t*****\t**********\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
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
            for (int i = 0; i < noOfStudentdAdded; i++)
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
            for (int i = 0; i < noOfStudentdAdded; i++)
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

            for (int i = 0; i < noOfStudentdAdded; i++)
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

            for (int i = 0; i < noOfStudentdAdded; i++)
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
            for (int i = 0; i < noOfStudentdAdded; i++)
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

            for (int i = 0; i < noOfStudentdAdded; i++)
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

            for (int i = 0; i < noOfStudentdAdded; i++)
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
            int student = 0;

            Console.WriteLine("\t\t The State First Rank");
            Console.WriteLine("\t\t *** ***** ***** ****\n\n");
            Console.WriteLine("\t Id \t Name \t Mark1 \t Mark2 \t Mark3 \t HighestMark \t Districk ");
            Console.WriteLine("\t ** \t **** \t ***** \t ***** \t ***** \t *********** \t ********\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int total = Convert.ToInt32(students[i, 2]) + Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]);

                if (temp < total)
                {
                    temp = total;
                    student = i;
                }
            }
            Console.WriteLine("\t {0} \t {1} \t {2} \t {3} \t {4} \t {5} \t\t {6}", students[student, 0], students[student, 1], students[student, 2], students[student, 3], students[student, 4], temp, students[student, 5]);
            Console.WriteLine("\n The Number Of Student is : {0} ", noOfStudentdAdded);
        }

        public void FindTopStudentGivenDistrict()
        {
            int temp = 0;
            int student = 0;
            int noOfStudentDistrict = 0;
            Console.WriteLine("\n\t\t To Find Top Mark  By District");
            Console.WriteLine("\t\t ** **** *** **** ** ********\n");

            Console.Write("Enter the District : ");
            string address = Console.ReadLine();

            Console.WriteLine("\n\t Id \t Name \t Mark1 \t Mark2 \t Mark3 \t HighestMark \t District ");
            Console.WriteLine("\t ** \t **** \t ***** \t ***** \t ***** \t ************ \t ******** ");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if (students[i, 5] == address)
                {
                    noOfStudentDistrict++;
                    int total = Convert.ToInt32(students[i, 2]) + Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]);
                    if (temp < total)
                    {
                        temp = total;
                        student = i;
                    }
                }
            }
            Console.WriteLine("\t {0} \t {1} \t {2} \t {3} \t {4} \t {5} \t\t {6}", students[student, 0], students[student, 1], students[student, 2], students[student, 3], students[student, 4], temp, students[student, 5]);
            Console.WriteLine("\n The Number Of Student is : {0} ", noOfStudentDistrict);

        }

        public void FindOutHighestMarkOfEachDistrict()
        {
            int count = 0;
            string[] uniqueDistricts = new string[noOfStudentdAdded];

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                string tempDistrict = students[i, 5];
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
                            count++;
                            uniqueDistricts[k] = tempDistrict;
                            break;
                        }
                    }
                }
            }

            int[] totalmark = new int[count];

            foreach (var num1 in uniqueDistricts)
            {
                int index = 0;
                int hightMark = 0;

                if (num1 == null)
                {
                    break;
                }

                else
                {
                    for (int p = 0; p < noOfStudentdAdded; p++)
                    {
                        if (num1 == students[p, 5])
                        {
                            int mark1 = Convert.ToInt32(students[p, 2]);
                            int mark2 = Convert.ToInt32(students[p, 3]);
                            int mark3 = Convert.ToInt32(students[p, 4]);

                            int total = mark1 + mark2 + mark3;
                            totalmark[index] = total;
                            index++;
                        }
                    }
                }

                foreach (int item in totalmark)
                {
                    if (hightMark < item)
                        hightMark = item;
                }
                Console.WriteLine("\n\t {0} : {1}", num1, hightMark);
                Console.WriteLine("\n The Total Student Of This district  : {0}", count);
            }
        }

        public void FindStudentsGivenMarkRange()   // To Find  ( 80 - 100 ) having mark of the students
        {
            Console.WriteLine("\n\t These Students are Having above 80 Marks");
            Console.WriteLine("\t ***** ******** *** ****** ***** ** *****\n");

            Console.WriteLine("\n Id\tName\tMark1\tMark2\tMark3\tDistrict\tTotal");
            Console.WriteLine(" **\t****\t*****\t*****\t*****\t********\t*****\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int mark1 = Convert.ToInt32(students[i, 2]);
                int mark2 = Convert.ToInt32(students[i, 3]);
                int mark3 = Convert.ToInt32(students[i, 4]);
                int total = mark1 + mark2 + mark3;

                if (((mark1 >= 80) && (mark1 <= 100)) || ((mark2 >= 80) && (mark2 <= 100)) || ((mark2 >= 80) && (mark2 <= 100)))
                {
                    Console.WriteLine(" {0}\t{1}\t{2}\t{3}\t{4}\t{5}\t\t{6}\n", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], total);
                }
            }
            Console.WriteLine();
        }

        public void AddedTwoSubjectAndLastName()
        {
            Console.WriteLine("\n\t Added Two Mark4,Mark5 And LastName Of The Student ");
            Console.WriteLine("\t ***** *** ***** ***** *** ******** ** *** *******\n");
            Console.WriteLine("\n Id\tName\tLastName\tMark1\tMark2\tMark3\tMark4\tMark5\tTotal\tAverage\tDistrict");
            Console.WriteLine(" **\t****\t********\t*****\t*****\t*****\t*****\t******\t*****\t*******\t********\n");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int total = Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]) + Convert.ToInt32(students[i, 5]) + Convert.ToInt32(students[i, 6]) + Convert.ToInt32(students[i, 7]);
                float average = total / 3;
                Console.WriteLine(" {0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], total, average, students[i, 8]);
            }
            Console.WriteLine();
        }


    }
}
