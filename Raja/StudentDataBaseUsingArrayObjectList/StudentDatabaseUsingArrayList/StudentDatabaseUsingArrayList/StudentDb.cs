using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseUsingArrayList
{
    class StudentDb
    {
        Student[] students;
        int numberOfAddedStudents = 0;
        public StudentDb(int numberOfStudents)
        {
            students = new Student[numberOfStudents];
        }
        public void AddStudent(int id,string name,int mark1,int mark2,int mark3,int mark4,int mark5,string district)
        {
            Student studentObject = new Student();
            studentObject.id = id;
            studentObject.name = name;
            studentObject.mark1 = mark1;
            studentObject.mark2 = mark2;
            studentObject.mark3 = mark3;
            studentObject.mark4 = mark4;
            studentObject.mark5 = mark5;
            studentObject.district = district;
            students[numberOfAddedStudents] = studentObject;
            numberOfAddedStudents++;            
        }
        public void PrintStudentInfoByMark(int studentmark)
        {          
            Console.WriteLine(" The Student mark:{0}",studentmark);         
            Console.WriteLine("Id  | Name");
            Console.WriteLine("****|*****");
            bool foundMatchingStudent = false;
            for (int i = 0; i <numberOfAddedStudents; i++)
            {
                if (students[i].mark1 == studentmark || students[i].mark2 == studentmark || students[i].mark3 == studentmark || students[i].mark4 == studentmark || students[i].mark5 == studentmark)
                {
                    foundMatchingStudent = true;
                    Console.WriteLine("{0}    {1}",students[i].id,students[i].name);
                }
                
            }
            if(foundMatchingStudent==false)
                Console.WriteLine("Enter Valid Student Mark:");
        }
        public void FindTopStudentGivenDistrict(string district)
        {
            int HighestMark = 0;
            int student = 0;
            int noOfStudentDistrict = 0;
            Console.WriteLine("To Find to Mark By District:{0}",district);
            Console.WriteLine("****************************");
            Console.WriteLine("Id|FirstName|HighestMark");
            Console.WriteLine("**|*********|**********");
            for (int i = 0; i < numberOfAddedStudents; i++)
            {
                if (students[i].district== district)
                {
                    noOfStudentDistrict++;
                    int total = students[i].mark1 + students[i].mark2 + students[i].mark3 + students[i].mark4 + students[i].mark5;
                    if (HighestMark < total)
                        HighestMark = total;
                    student = i;
                }
            }
            Console.WriteLine("{0}        {1}     {2} ", students[student].id, students[student].name,HighestMark);
            Console.WriteLine("Number Of Student Same District:{0}",noOfStudentDistrict);
        }
        public void FindOutHighestMarkOfEachDistrict()
        {
            Console.WriteLine("\nHighestMarkOfEachDistrict");
            Console.WriteLine("*************************");
            Console.WriteLine("Id|District |TotalMarks");
            Console.WriteLine("**|*********|***********");
            int uniqueDistrictsCount = 0;
            string[] uniqueDistricts = new string[numberOfAddedStudents];

            for (int i = 0; i < numberOfAddedStudents; i++)
            {
                string tempDistrict = students[i].district;
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
                    for (int p = 0; p < uniqueDistricts.Length; p++)
                    {
                        if (iDistrict == students[p].district)
                        {
                            int mark1 = students[p].mark1;
                            int mark2 = students[p].mark2;
                            int mark3 = students[p].mark3;
                            int mark4 = students[p].mark4;
                            int mark5 = students[p].mark5;

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
                Console.WriteLine(" {0}    {1}     {2}",students[index].id ,iDistrict, hightMark);
            }
        }
        public void PrintOfTopStudent()
        {
            Console.WriteLine("Highest Mark Of Students");
            Console.WriteLine("************************");
            Console.WriteLine("Id|FirstName|HighestMarkOfStudent");
            Console.WriteLine("***|********|*******************");
            int highestMarkOfStudends = 0;
            int index = -1;
            for (int i = 0; i < numberOfAddedStudents; i++)
            {
                int total = students[i].mark1 + students[i].mark2 + students[i].mark3 + students[i].mark4 + students[i].mark5;
                if (total > highestMarkOfStudends)
                {
                    highestMarkOfStudends = total;
                    index = i;
                }
            }
            Console.WriteLine("{0}     {1}     {2}", students[index].id, students[index].name,highestMarkOfStudends);
        }
        
        private string GradeOfSubject(int marks)
        {
            if (marks < 40)
                return "U";
            else if (marks >= 50 && marks <= 60)
                return " D";
            else if (marks > 71 && marks <= 80)
                return "C";
            else if (marks > 81 && marks <= 90)
                return "B";
            else if (marks > 90)
                return "A";
            else
                return "S";
        }
        public void PrintGradeForEachSubject()
        {
            Console.WriteLine("Grade Of Student Marks");
            Console.WriteLine("**********************");
            Console.WriteLine("Id | Name| Grade");
            Console.WriteLine("***|*****|******");
            for (int i = 0; i < numberOfAddedStudents; i++)
            {
                int mark1 = students[i].mark1;
                int mark2 = students[i].mark2;
                int mark3 = students[i].mark3;
                int mark4 = students[i].mark4;
                int mark5 = students[i].mark5;
                Console.WriteLine("{0} {1} Mark1:{2} Mark2:{3} Mark3:{4}  Mark4:{5} Mark5:{6}", students[i].id, students[i].name, GradeOfSubject(mark1), GradeOfSubject(mark2), GradeOfSubject(mark3), GradeOfSubject(mark4), GradeOfSubject(mark5));

            }
        }

        public void PrintAllStudentNames()
        {
            Console.WriteLine(" Student Names");
            Console.WriteLine("***************");
            for (int i = 0; i < numberOfAddedStudents; i++)
            {
                Console.WriteLine(students[i].name);
            }
        }

        public void PrintAllStudentMark1()
        {
            Console.WriteLine("Students Mark1");
            Console.WriteLine("**************");
            for (int i = 0; i < numberOfAddedStudents; i++)
            {
                Console.WriteLine(students[i].mark1);   
            }
        }

        public void MinimumMarkOfStudent()
        {
            Console.WriteLine("Minimum Mark Of Student");
            Console.WriteLine("***********************");
            Console.WriteLine("Id | Name |MinimumMark");
            Console.WriteLine("***| *****|***********");

            for (int i = 0; i < numberOfAddedStudents; i++)
            {
                int mark1 = students[i].mark1;
                int mark2 = students[i].mark2;
                int mark3 = students[i].mark3;
                int mark4 = students[i].mark4;
                int mark5 = students[i].mark5;
                int[] marks = { mark1, mark2, mark3, mark4, mark5 };
                int MinimumMark = marks[0];
                foreach (int max in marks)
                {
                    if (MinimumMark > max)
                        MinimumMark = max;
                }
                Console.WriteLine("{0}    {1}    {2} ", students[i].id, students[i].name, MinimumMark);
            }
        }
        
        public void MaximumMarkOfStudent()
        {
            Console.WriteLine("Maximum Mark Of Student");
            Console.WriteLine("***********************");
            Console.WriteLine("Id | Name |MaximumMark");
            Console.WriteLine("***| *****|***********");
            
            for (int i = 0; i <numberOfAddedStudents; i++)
            {
                int mark1 = students[i].mark1;
                int mark2 = students[i].mark2;
                int mark3 = students[i].mark3;
                int mark4 = students[i].mark4;
                int mark5 = students[i].mark5;
                int[] marks={mark1,mark2,mark3,mark4,mark5};
                int MaximumMark = marks[0];
                foreach (int max in marks)
                {
                    if (MaximumMark < max)
                        MaximumMark = max;
                } 
                Console.WriteLine("{0}    {1}    {2} ",students[i].id,students[i].name,MaximumMark);
            }
        }
        public void FindStudentGivenMarkRange()
        {
            Console.WriteLine("These Student Having Above 90 Marks");
            Console.WriteLine("***********************************");
            Console.WriteLine("Id | Name ");
            Console.WriteLine("***|*****");
            for (int i = 0; i < numberOfAddedStudents ; i++)
            {
                if (((students[i].mark1 > 90) && (students[i].mark1 < 100)) || (students[i].mark2 > 90) && (students[i].mark2 < 100) || (students[i].mark3 > 90) && (students[i].mark3 < 100) || (students[i].mark4 > 90) && (students[i].mark4 < 100) || (students[i].mark5 > 90) && (students[i].mark5 < 100))
               {
                   Console.WriteLine("{0}    {1}",students[i].id,students[i].name);
               }
            }
        }
        public void StudentOfResult()
        {
            Console.WriteLine("Student Of Result");
            Console.WriteLine("*****************");
            Console.WriteLine("Name | Result");
            Console.WriteLine("*****|********");
            for (int i = 0; i < numberOfAddedStudents ; i++)
            {
                string result;
                if (students[i].mark1 >= 40 && students[i].mark2 >= 40 && students[i].mark3 >= 40 && students[i].mark4 >= 40 && students[i].mark5 >= 40)
                    {
                 result ="pass";
                 Console.WriteLine("{0}    {1}",students[i].name,result);
                }
                else
                {
                  result = "fail";
                  Console.WriteLine("{0}    {1}",students[i].name, result);
                }
 
            }
        }
        public void AverageStudentMark()
        {
            Console.WriteLine("Average Student Mark");
            Console.WriteLine("********************");
            Console.WriteLine("Name | Total |Average");
            Console.WriteLine("**** | ***** |*******");
            for (int i = 0; i <numberOfAddedStudents; i++)
            {
                int total = students[i].mark1 + students[i].mark2 + students[i].mark3+ students[i].mark4+students[i].mark5;
                int average = total / 5;
                Console.WriteLine("{0}   {1}    {2}",students[i].name,total,average );
            }
        }

        public void PrintStudentWithMatchingMark2AndMark3(int inputMark,int inputMark1)
        {
            Console.WriteLine("Student Mark2&Mark3={0},{1}", inputMark,inputMark1);
            Console.WriteLine("****************************");
            for (int i = 0; i < numberOfAddedStudents; i++)
            {
                Student currentStudent = students[i];
                if (currentStudent.mark2 == inputMark||currentStudent.mark3==inputMark1)
                {
                    Console.WriteLine(currentStudent.name);
                }
            }
        }

        public void PrintStudentWithMatchingMark1(int inputMark)
        {
            Console.WriteLine("Student Mark1={0}",inputMark);
            Console.WriteLine("******************");
            for (int i = 0; i < numberOfAddedStudents; i++)
            {
                Student currentStudent = students[i];
                if(currentStudent.mark1 ==inputMark)
                {
                    Console.WriteLine(currentStudent.name);
                }
            }
        }
    }
}
