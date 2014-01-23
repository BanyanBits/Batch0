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
        public void TotalNoOfStudentCount()
        {

        }

        public void PrintStudentNameById()
        {
            string StudentId;
            Console.Write("Enter the Student Id:");
            StudentId = (Console.ReadLine());
            Console.WriteLine("*********************");
            Console.WriteLine("\n\tId |FirstName|LastName| Mark1| Mark2 | Mark3 | Mark4| Mark5| Distict");
            Console.WriteLine("\t***|******** |********|******|******|******  |*****|  *****| ********");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if (students[i, 0] == StudentId)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", students[i, 0], students[i, 1], students[i, 2], students[i, 3], students[i, 4], students[i, 5], students[i, 6], students[i, 7], students[i, 8]);
                    return;
                }
            } Console.WriteLine("Enter Valid Id Number");

        }
        public void printStudentNameByDistrict()
        {
            string district;
            Console.Write("Enter the Student District:");
            district = Console.ReadLine();
            Console.WriteLine("***************************");
            Console.WriteLine("\n\tId|FirstName|LastName|Distict");
            Console.WriteLine("\t***|********|********|********");
            int addedStudentMark = 0;
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if (students[i, 8] == district)
                {
                    addedStudentMark++;
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[i, 0], students[i, 1], students[i, 2], students[i, 8]);
                }
            }
            Console.WriteLine("Enter the Valid Student District");
        }

        public void FindOutHighestMarkOfEachDistrict()
        {
            Console.WriteLine("FindOut The Highest marks Of Each District");
            Console.WriteLine("******************************************");
            string district;
            district = Console.ReadLine();
            int addedStudentMark = 0;
            int highestMark = 0;
            int index = 0;
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                if (students[i, 8] == district)
                {
                    int total = Convert.ToInt32(students[i, 3]) + Convert.ToInt32(students[i, 4]) + Convert.ToInt32(students[i, 5]) + Convert.ToInt32(students[i, 6]) + Convert.ToInt32(students[i, 7]);
                    addedStudentMark++;

                    if (total > highestMark)
                    {
                        highestMark = total;
                        index = i;
                    }

                }
                Console.WriteLine(highestMark);

            }

        }
        public void printStudentNameByMarks()
        {
            string studentMark;
            Console.Write("Enter the Student marks:");
            studentMark = Console.ReadLine();
            Console.WriteLine("************************");
            Console.WriteLine("\n\t Id|FirstName |LastName |Mark1 |Mark2 |Mark3 |Mark4| Mark5| Distict");
            Console.WriteLine("\t*** |********* |********| *****| ***** |****|****** | ***** | *******");
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
            Console.WriteLine("\n\tId|FirstName|LastName|Maximum Marks");
            Console.WriteLine("\t****|********|********|*************");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int temp;
                int temp1;
                int temp2;
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);

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
                    temp1 = temp;
                }
                else
                {
                    temp1 = mark3;
                }
                if (temp1 > mark4)
                {
                    temp2 = temp1;
                }
                else
                {
                    temp2 = mark4;
                }
                if (temp2 > mark5)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[i, 0], students[i, 1], students[i, 2], temp2);
                }
                else
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[i, 0], students[i, 1], students[i, 2], mark5);
                }
            }

        }

        public void MinimumOFMark()
        {
            Console.WriteLine("Minimum Marks Of Students");
            Console.WriteLine("**************************");
            Console.WriteLine("\n\tId|FirstName|LastName|Minimum Marks");
            Console.WriteLine("\t****|********|********|*************");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                int temp;
                int temp1;
                int temp2;
                int mark1 = Convert.ToInt32(students[i, 3]);
                int mark2 = Convert.ToInt32(students[i, 4]);
                int mark3 = Convert.ToInt32(students[i, 5]);
                int mark4 = Convert.ToInt32(students[i, 6]);
                int mark5 = Convert.ToInt32(students[i, 7]);

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
                    temp1 = temp;
                }
                else
                {
                    temp1 = mark3;
                }
                if (temp1 < mark4)
                {
                    temp2 = temp1;
                }
                else
                {
                    temp2 = mark4;
                }
                if (temp2 < mark5)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[i, 0], students[i, 1], students[i, 2], temp2);
                }
                else
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", students[i, 0], students[i, 1], students[i, 2], mark5);
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
            Console.WriteLine("\n\tId|FirstName|LastName|Result");
            Console.WriteLine("\t****|*********|*********|******");
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
                return "C Grade";
            else if (mark > 71 && mark <= 80)
                return "B Grade";
            else if (mark > 90)
                return "A Grade";
            else
                return "S Grade";
        }

        public void GradePriority()
        {
            Console.WriteLine("Grade of Student");
            Console.WriteLine("*****************");
            Console.WriteLine("\n\tId| FirstName| LastName |Grade");
            Console.WriteLine("\t****|*********|*********|******");

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
            int num = 0;
            Console.WriteLine("\n\t Total Student Count");
            Console.WriteLine("\t **** ** ******\n");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                num++;
                Console.WriteLine(students[i, 0]);

            }
            Console.Write("\n :Total count Student ");
            Console.WriteLine(num);
        }

        public void FindOutHighestMarkOfEachSubject()
        {
            Console.WriteLine("FindOut The Highest marks Of Each Marks");
            Console.WriteLine("******************************************");
            string[] mark1 = new string[100];
            mark1[0] = students[0, 3];
            int n = 0;
            int i;
            for (i = 1; i < noOfStudentdAdded; i++)
            {
                if (mark1[n] != students[i, 3])
                {
                    mark1[n] = students[i, 3];
                }
                n = i;
            }
            Console.WriteLine("List Of  Highest Mark1\n");
        }

        public void DisplayToMark1Only()
        {
            int num = 0;
            Console.WriteLine("\n\t List Of Mark1");
            Console.WriteLine("\t **** ** ******\n");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                num++;
                Console.WriteLine(students[i, 3]);

            }
            Console.Write("\n the list of Mark1 : ");
            Console.WriteLine(num);
        }

        public void Districtname()
        {
            int num = 0;
            Console.WriteLine("\n\t List Of district name");
            Console.WriteLine("\t **** ** ******** ****\n");
            for (int i = 0; i < noOfStudentdAdded; i++)
            {
                num++;
                Console.WriteLine(students[i, 8]);

            }
            Console.Write("\n the total number of district  : ");
            Console.WriteLine(num);
        }

        public void NumberOfDistrict()
        {
            Console.WriteLine("\t the number of district in the state\n\n");
            string[] district = new string[100];

            int n = 0;
            // district[0] = students[0, 8];
          //  int j = 0;
            district[n] = students[0, 8];

            for (int i = 0; i < noOfStudentdAdded; i++)
            {

                if (district[n] != students[i, 8])
                {
                    for (int j = 0; j < 100; j++)
                    {
                        if (district[j] != students[i, 8])
                            district[n + j] = students[i, 8];                        

                    }
                    district[n+1] = students[i, 8];
                    
                }

                else
                {
                    for (int k = 0; k < 100; k++)
                    {
                        if (district[k] != students[i, 8])
                            district[n+k] = students[i, 8];
                       // j++;

                    }

                }
                Console.WriteLine("List Of District in the State\n");
                foreach (var item in district)
                    Console.WriteLine(item);
            }
        }


    }
}



