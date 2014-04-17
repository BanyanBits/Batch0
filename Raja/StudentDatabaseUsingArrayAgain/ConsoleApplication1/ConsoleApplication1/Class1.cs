using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StudentDatabase
    {
        string[,] students;
        int noOfStudentsAdded = 0;
        public StudentDatabase(int totalStudents)
        {
            students = new string[totalStudents, 9];
        }
        public void AddStudent(int id, string firstName, string lastName, int mark1, int mark2, int mark3, int mark4, int mark5, string district)
        {
            students[noOfStudentsAdded, 0] = id.ToString();
            students[noOfStudentsAdded, 1] = firstName;
            students[noOfStudentsAdded, 2] = lastName;
            students[noOfStudentsAdded, 3] = mark1.ToString();
            students[noOfStudentsAdded, 4] = mark2.ToString();
            students[noOfStudentsAdded, 5] = mark3.ToString();
            students[noOfStudentsAdded, 6] = mark4.ToString();
            students[noOfStudentsAdded, 7] = mark5.ToString();
            students[noOfStudentsAdded, 8] = district;
            noOfStudentsAdded++;
        }

        public void MinimumMarkOfStudent()
        {
            Console.WriteLine("Minimum Mark of Student");
            Console.WriteLine("***********************");
            Console.WriteLine("\nId  |FirstName|LastName|Mark1 |Mark2 |Mark3 |Mark4 |Mark5 |Maxmark");
            Console.WriteLine("*** |******** |******* |***** |***** |***** |****  |***** |*******");
            for (int i = 0; i < noOfStudentsAdded; i++)
            {
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);
                int[] marks = new int[] { mark1, mark2, mark3, mark4, mark5 };
                int temp = marks[0];
                foreach (var min in marks)
                {
                    if (temp > min)
                        temp = min;
                } Console.WriteLine("{0} \t{1} \t{2}  \t{3} \t{4} \t{5} \t{6} \t{7} \t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], temp);
            }

        }


        public void MaximumMarkOfStudent()
        {
            Console.WriteLine("Maximum Mark of Student");
            Console.WriteLine("***********************");
            Console.WriteLine("\nId  |FirstName|LastName|Mark1 |Mark2 |Mark3 |Mark4 |Mark5 |Maxmark");
            Console.WriteLine("*** |******** |******* |***** |***** |***** |****  |***** |*******");
            for (int i = 0; i < noOfStudentsAdded; i++)
            {
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);
                int[] marks = new int[] { mark1, mark2, mark3, mark4, mark5 };
                int temp = marks[0];
                foreach (var max in marks)
                {
                    if (temp < max)
                        temp = max;
                } Console.WriteLine("{0} \t{1} \t{2}  \t{3} \t{4} \t{5} \t{6} \t{7} \t{8}",students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], temp);
            } 
            
        }

        public void FindStudentGivenMarkRange()
        {
            Console.WriteLine("These students are having above 80 marks");
            Console.WriteLine("****************************************");
            Console.WriteLine("\nId  |FirstName|LastName|Mark1 |Mark2 |Mark3 |Mark4 |Mark5 |District");
            Console.WriteLine("*** |******** |******* |***** |***** |***** |****  |***** |*******");
            for (int i = 0; i < noOfStudentsAdded; i++)
            {
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);
                int total = mark1 + mark2 + mark3 + mark4 + mark5;
                if (((mark1 >= 80) && (mark1 <= 100)) || ((mark2 >= 80) && (mark2 <= 100)) || ((mark3 >= 80) && (mark3 <= 100)) || ((mark4 >= 80) && (mark4 <= 100)) || ((mark5 >= 80) && (mark5 <= 100)))
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8]);
                }
            }
            Console.WriteLine();
        }

        public void PrintAllStudentInfo()
        {
            Console.WriteLine("\tAll Student Infomatiom");
            Console.WriteLine("\t***********************");
            Console.WriteLine("\nId  |FirstName|LastName|Mark1 |Mark2 |Mark3 |Mark4 |Mark5 |District");
            Console.WriteLine("*** |******** |******* |***** |***** |***** |****  |***** |*******");
            for (int i = 0; i < noOfStudentsAdded; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8]);
            }
        }

        public void studentNameById()
        {
            string studentId;
            Console.WriteLine("Enter the Student Id:");
            studentId = Console.ReadLine();
            Console.WriteLine("*********************");
            Console.WriteLine("\nId  |FirstName|LastName|Mark1 |Mark2 |Mark3 |Mark4 |Mark5 |District");
            Console.WriteLine("*** |******** |******* |***** |***** |***** |****  |***** |*******");
            for (int i = 0; i < noOfStudentsAdded; i++)
            {
                if (students[i, 0] == studentId)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8]);
                    return;
                }
            }
            Console.WriteLine("Enter the Valid Number");
        }

        public void FindTopStudentGivenDistrict()
        {
            int HighestMark = 0;
            int student = 0;
            int noOfStudentDistrict = 0;
            Console.WriteLine("To Find to Mark By District");
            Console.WriteLine("****************************");
            Console.WriteLine("Enter the District");
            string district = Console.ReadLine();
            Console.WriteLine("****************");
            Console.WriteLine("Id|FirstName|LastNmae|HighestMark");
            Console.WriteLine("**|*********|********|**********");
            for (int i = 0; i < noOfStudentsAdded; i++)
            {
                if (students[i, 8] == district)
                {
                    noOfStudentDistrict++;
                    int total = Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]) + Convert.ToInt32(students[i, 5]) + Convert.ToInt32(students[i, 6]) + Convert.ToInt32(students[i, 7]);
                    if (HighestMark < total)
                        HighestMark = total;
                    student = i;
                }
            }
            Console.WriteLine("{0}\t{1}\t{2}\t{4}", students[student, 0], students[student, 1], students[student, 2], students[student, 3], HighestMark);
            Console.WriteLine(noOfStudentDistrict);
        }

        public void FindOutHighestMarkOfEachDistrict()
        {
            Console.WriteLine("\nHighestMarkOfEachDistrict");
            Console.WriteLine("*************************");
            Console.WriteLine("\n\tDistrict |TotalMarks");
            Console.WriteLine("\t*********|***********");
            int uniqueDistrictsCount = 0;
            string[] uniqueDistricts = new string[noOfStudentsAdded];

            for (int i = 0; i < noOfStudentsAdded; i++)
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
                            uniqueDistrictsCount++;
                            uniqueDistricts[k] = tempDistrict;
                            break;
                        }
                    }
                }
            }

            int[] totalmark = new int[uniqueDistrictsCount];

            foreach (var iDistrict in uniqueDistricts)
            {
                int index = 0;

                if (iDistrict == null)
                {
                    break;
                }
                else
                {
                    for (int p = 0; p < noOfStudentsAdded; p++)
                    {
                        if (iDistrict == students[p, 8])
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

                int hightMark = 0;
                foreach (int item in totalmark)
                {
                    if (hightMark < item)
                        hightMark = item;
                }
                Console.WriteLine("\n\t {0}   :   {1}", iDistrict, hightMark);
            }
        }
        public void averageStudentOfMark()
        {
            Console.WriteLine("Student Of Average Mark");
            Console.WriteLine("***********************");
            Console.WriteLine("Id |FirstName |LastName |Mark1 |Mark2 |Mark3 |Mark4|Mark5|District|Total|Average");
            Console.WriteLine("** |******* |******** |***** |***** |***** |****** |***** |****** |*****|*******");
            for (int i = 0; i < noOfStudentsAdded; i++)
            {
                int total = Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]) + Convert.ToInt32(students[i, 5]) + Convert.ToInt32(students[i, 6]) + Convert.ToInt32(students[i, 7]);
                int average = total / 5;
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9} {10}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8], total, average);
            }

        }

        public void studentOfResult()
        {
            Console.WriteLine("Student Of Result");
            Console.WriteLine("*****************");
            Console.WriteLine("Id |FirstName |LastName |Mark1 |Mark2 |Mark3 |Mark4|Mark5|Result");
            Console.WriteLine("** |******* |******** |***** |***** |***** |****** |*****|******");

            for (int i = 0; i < noOfStudentsAdded; i++)
            {
                string result;
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);
                if (mark1 >= 40 && mark2 >= 40 && mark3 >= 40 && mark4 >= 40 && mark5 >= 40)
                {
                    result = "pass";
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], result);
                }
                else
                {
                    result = "fail";
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], result);

                }

            }
        }
       
        public void PrintStudentInfoByMark()
        {
            int numberOfStudends = 0;
            string studentMark;
            Console.Write("Enter the Student marks:");
            studentMark = Console.ReadLine();
            Console.WriteLine("************************");
            Console.WriteLine("\n\tId |FirstName |LastName|Mark1 |Mark2 |Mark3 |Mark4| Mark5| Distict");
            Console.WriteLine("\t***|*********|********| *****| ***** |****|****** | ***** | *******");

            bool foundMatchingStudent = false;
            for (int i = 0; i < noOfStudentsAdded; i++)
            {
                numberOfStudends++;
                if ((students[i, 3] == studentMark) || (students[i, 4] == studentMark) || (students[i, 5] == studentMark) || (students[i, 6] == studentMark) || (students[i, 7] == studentMark))
                {
                    foundMatchingStudent = true;
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8]);
                }
            }

            if (foundMatchingStudent == false)
                Console.WriteLine("Enter the Valid Student Marks");
        }


        public void printTopStudentInfo()
        {
            Console.WriteLine("Highest Mark Of Students");
            Console.WriteLine("************************");
            Console.WriteLine("\n\tId|FirstName|LastName|HighestMarkOfStusent");
            Console.WriteLine("\t***|********|********|*******************");
            int highestMarkOfStudends = 0;
            int index = -1;
            for (int i = 0; i < noOfStudentsAdded; i++)
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

        public void studentNameByDistrict()
        {
            string district;
            Console.WriteLine("Enter the Student District:");
            district = Console.ReadLine();
            Console.WriteLine("***************************");
            Console.WriteLine("\nId  |FirstName|LastName|Mark1 |Mark2 |Mark3 |Mark4 |Mark5 |District");
            Console.WriteLine("*** |******** |******* |***** |***** |***** |****  |***** |*******");
            bool studentInDistrict = true;
            for (int i = 0; i < noOfStudentsAdded; i++)
            {
                if (students[i, 8] == district)
                {
                    studentInDistrict = false;
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8]);
                }
            }
            if (studentInDistrict)
            {
                Console.WriteLine("Enter the Valid Student District");
            }
        }
    }


}

