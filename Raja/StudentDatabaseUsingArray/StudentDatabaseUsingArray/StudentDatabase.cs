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
            students = new string[totalStudents, 9];
        }

        public void AddStudent(int id, string firstname, string lastname, int mark1, int mark2, int mark3, int mark4, int mark5, string district)
        {
            students[noOfStudentdAdded, 0] = id.ToString();
            students[noOfStudentdAdded, 1] = firstname;
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
            Console.WriteLine("All Student Infomatiom");
            Console.WriteLine("***********************");
            Console.WriteLine("\tId |FirstName|LastName| Mark1| Mark2| Mark3| Mark4| Mark5 | District");
            Console.WriteLine("\t***|********|********|*******|******|*******|*****|*******|********");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8]);
            }
        }

        public void PrintStudentNameById()
        {
            string studentId;
            Console.Write("Enter the Student Id:");
            studentId = (Console.ReadLine());
            Console.WriteLine("*********************");
            Console.WriteLine("\n\tId |FirstName|LastName| Mark1| Mark2 | Mark3 | Mark4| Mark5| Distict");
            Console.WriteLine("\t***|******** |********|******|******|******  |*****|  *****| ********");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if (students[i, 0] == studentId)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8]);
                    return;
                }
            }
            Console.WriteLine("Enter the Valid Number:");            
        }        

        public void printStudentNameByDistrict()
        {
            string district;
            Console.Write("Enter the Student District:");
            district = Console.ReadLine();
            Console.WriteLine("***************************");
            Console.WriteLine("\n\tId|FirstName|LastName|Distict");
            Console.WriteLine("\t***|********|********|********");
         
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if (students[i, 8] == district)
                {
                   
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[i, 0], students[i, 1], students[i, 2], students[i, 8]);
                }
            }            
                Console.WriteLine("Enter the Valid Student District:");            
        }

        public void printStudentNameByMarks()
        {
            string studentMark;
            Console.Write("Enter the Student marks:");
            studentMark = Console.ReadLine();
            Console.WriteLine("************************");
            Console.WriteLine("\n\tId |FirstName |LastName|Mark1 |Mark2 |Mark3 |Mark4| Mark5| Distict");
            Console.WriteLine("\t***|*********|********| *****| ***** |****|****** | ***** | *******");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if ((students[i, 3] == studentMark) || (students[i, 4] == studentMark) || (students[i, 5] == studentMark) || (students[i, 6] == studentMark) || (students[i, 7] == studentMark))
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8]);

                }
            }            
            Console.WriteLine("Enter the Valid Student Marks");
        }

        public void MaximumOfMark()
        {
            Console.WriteLine("Maximum Marks Of Students");
            Console.WriteLine("**************************");
            Console.WriteLine("\nId| FirstName | LastName| Mark1| Mark2| Mark3| Mark4| Mark5| District| MaxMarks ");
            Console.WriteLine("****|**********|********|******|*****| ***** |***** |*******|*********|*********  ");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int maxmumMark;
                int maxmumMark1;
                int maxmumMark2;
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);

                if (mark1 > mark2)
                {
                    maxmumMark = mark1;
                }
                else
                {
                    maxmumMark = mark2;

                }
                if (maxmumMark > mark3)
                {
                    maxmumMark1 = maxmumMark;
                }
                else
                {
                    maxmumMark1 = mark3;
                }
                if (maxmumMark1 > mark4)
                {
                    maxmumMark2 = maxmumMark1;
                }
                else
                {
                    maxmumMark2 = mark4;
                }
                if (maxmumMark2 > mark5)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8], maxmumMark2);
                }
                else
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8], mark5);
                }
            }
        }

        public void MinimumOFMark()
        {
            Console.WriteLine("Minimum Marks Of Students");
            Console.WriteLine("**************************");
            Console.WriteLine("\nId| FirstName | LastName| Mark1| Mark2| Mark3| Mark4| Mark5| District| MiniMarks ");
            Console.WriteLine("****|**********|********|******|*****| ***** |***** |*******|*********|*********  ");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int minimumMark;
                int minimumMark1;
                int minimumMark2;
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);

                if (mark1 < mark2)
                {
                    minimumMark = mark1;
                }
                else
                {
                    minimumMark = mark2;

                }
                if (minimumMark < mark3)
                {
                    minimumMark1 = minimumMark;
                }
                else
                {
                    minimumMark1 = mark3;
                }
                if (minimumMark1 < mark4)
                {
                    minimumMark2= minimumMark1;
                }
                else
                {
                    minimumMark2 = mark4;
                }
                if (minimumMark2 < mark5)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8], minimumMark2);
                }
                else
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8], mark5);
                }
            }
        }

        public void AverageStudentOfMark()
        {
            Console.WriteLine("Average Marks Of Students");
            Console.WriteLine("*************************");
            Console.WriteLine("\n\tId|FirstName|LastName| Total| Average");
            Console.WriteLine("\t****|*********|*********|******|*******");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int total = Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]) + Convert.ToInt32(students[i, 5]) + Convert.ToInt32(students[i, 6]) + Convert.ToInt32(students[i, 7]);
                int average = total / 5;
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}", students[i, 0], students[i, 1], students[i, 2], total, average);
            }
        }

        public void StudentOfResult()
        {

            Console.WriteLine("Student Of Result");
            Console.WriteLine("*****************");
            Console.WriteLine("\n\tId| FirstName |LastName|Result");
            Console.WriteLine("\t***|******** |******** |******");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                string Result;
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);
                if (mark1 >= 40 && mark2 >= 40 && mark3 >= 40 && mark4 >= 40 && mark5 >= 40)
                {
                    Result = "Pass";
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[i, 0], students[i, 1], students[i, 2], Result);
                }
                else
                {
                    Result = "Fail";
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[i, 0], students[i, 1], students[i, 2], Result);
                }
            }
        }

        private string GradeOfStudent(int mark)
        {
            if (mark >= 50 && mark <= 70)
                return "IV -Grade";
            else if (mark > 71 && mark <= 80)
                return "III-Grade";
            else if (mark > 90)
                return "II -Grade";
            else
                return "I  -Grade";
        }

        public void GradePriority()
        {
            Console.WriteLine("Grade of Student");
            Console.WriteLine("*****************");
            Console.WriteLine("\n\tId| FirstName| LastName | Grade ");
            Console.WriteLine("\t****|*********|*********|********");

            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[i, 0], students[i, 1], students[i, 2], GradeOfStudent(mark1));
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[i, 0], students[i, 1], students[i, 2], GradeOfStudent(mark2));
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[i, 0], students[i, 1], students[i, 2], GradeOfStudent(mark3));
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[i, 0], students[i, 1], students[i, 2], GradeOfStudent(mark4));
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[i, 0], students[i, 1], students[i, 2], GradeOfStudent(mark3));
            }
        }

        public void HighestMarkOfStudent()
        {
            Console.WriteLine("Highest Mark Of Students");
            Console.WriteLine("************************");
            Console.WriteLine("\n\tId|FirstName|LastName|HighestMarkOfStusent");
            Console.WriteLine("\t***|********|********|*******************");
            int highestMarkOfStudends = 0;
            int index = -1;
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int total = Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]) + Convert.ToInt32(students[i, 5]) + Convert.ToInt32(students[i, 6]) + Convert.ToInt32(students[i, 7]);
                if (total > highestMarkOfStudends)
                {
                    highestMarkOfStudends = total;
                    index = i;
                }
            }
            Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[index, 0], students[index, 1], students[index, 2], highestMarkOfStudends);
        }

        public void TotalCountStudent()
        {
            int numberOfStudent = 0;
            Console.WriteLine("\nTotal Student Count");
            Console.WriteLine("***** ******* *****");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                numberOfStudent++;
            }
            Console.Write("\nTotal count Student :");
            Console.WriteLine(numberOfStudent);
        }

        public void Districtname()
        {
            int numberOfDistrict = 0;
            Console.WriteLine("List Of District Name");
            Console.WriteLine("**** ** ******** ****\n");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                numberOfDistrict++;
                Console.WriteLine(students[i, 8]);

            }
            Console.Write("The Total Number Of District  : ");
            Console.WriteLine(numberOfDistrict);
        }

        public void FindOutHighestMarkOfEachDistrict()
        {
            Console.WriteLine("\nHighestMarkOfEachDistrict");
            Console.WriteLine("*************************");
            Console.WriteLine("\n\tDistrict |TotalMarks");
            Console.WriteLine("\t*********|***********");
            int count = 0;
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
                        if (num1 == students[p, 8])
                        {
                            int mark1 = Convert.ToInt32(students[p, 3]);
                            int mark2 = Convert.ToInt32(students[p, 4]);
                            int mark3 = Convert.ToInt32(students[p, 5]);
                            int mark4 = Convert.ToInt32(students[p, 6]);
                            int mark5 = Convert.ToInt32(students[p, 7]);

                            int total = mark1 + mark2 + mark3 + mark4 + mark5;
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
                Console.WriteLine("\n\t {0}   :   {1}", num1, hightMark);
            }
        }
    }
}









