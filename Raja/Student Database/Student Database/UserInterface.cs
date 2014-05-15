﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Database
{
    class UserInterface
    {
        StudentDb db = new StudentDb();
        public delegate void PrintStudentsInfoDelegate(Student student);

        public void PrintStudentList(List<Student> students, PrintStudentsInfoDelegate PrintStudentsInfoMethod)
        {
            if (students.Any() == false)
            {
                Console.WriteLine("No Students Method");
                return;
            }

            foreach (var student in students)
            {
                PrintStudentsInfoMethod(student);
            }
        }

        private void DisplayMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("**************************************");
            Console.WriteLine("Students Database-Application By Raja");
            Console.WriteLine("**************************************");
            Console.WriteLine("Please select the options below to proceed");
            Console.WriteLine("w.Print All Students List");
            Console.WriteLine("c.Print Students Count");
            Console.WriteLine("a.Add a New Student");
            Console.WriteLine("d.Delete a Student");
            Console.WriteLine("h.Print Student with Hunderd Marks");
            Console.WriteLine("f.Find Students With Matching Marks");
            Console.WriteLine("s.Find Students with Highest scores");
            Console.WriteLine("n.Find Students by School Name");
            Console.WriteLine("b.Find Students By District");
            Console.WriteLine("p.Find Students By Name");
            Console.WriteLine("o.Print Total Marks In Sorting Method");
            Console.WriteLine("t.Add 10 Test Students");
            Console.WriteLine("q.Exit");
            Console.Write("Enter Your Choice:");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
            switch (key.Key)
            {
                case ConsoleKey.W:
                    {
                        PrintAllStudentsList();
                        break;
                    }
                case ConsoleKey.T:
                    {
                        AddTestStudents();
                        break;
                    }

                case ConsoleKey.C:
                    {
                        PrintStudentsCount();
                        break;
                    }
                case ConsoleKey.A:
                    {
                        AddStudent();
                        break;
                    }
                case ConsoleKey.D:
                    {
                        DeleteStudent();
                        break;
                    }
                case ConsoleKey.P:
                    {
                        FindStudentsByName();
                        break;
                    }

                case ConsoleKey.H:
                    {
                        FindStudentWithHundredMarks();
                        break;
                    }
                case ConsoleKey.F:
                    {
                        FindStudentsWithGivenMarks();
                        break;
                    }
                case ConsoleKey.S:
                    {
                        FindStudentWithHighestScores();
                        break;
                    }
                case ConsoleKey.N:
                    {
                        FindStudentsBySchoolName();
                        break;
                    }
                case ConsoleKey.B:
                    {
                        FindStudentsByDistrict();
                        break;
                    }
                case ConsoleKey.Q:
                    {
                        Environment.Exit(0);
                        break;
                    }
                case ConsoleKey.O:
                    {
                        PrintTotalMarksInSortingMethod();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Enter the correct options ");
                        break;
                    }
            }
        }

        private void PrintStudentsCount()
        {
            Console.WriteLine("Total Number Of Students in the Database:{0}", db.Count);
        }

        private void AddTestStudents()
        {
            Random random = new Random();
            int count = 10;
            int studentCount = db.Count;
            for (int i = 1; i <=count; i++)
            {
                int studentId = studentCount + i;
                string name = "Student" + studentId.ToString();
                int mark1 = random.Next(100);
                string schoolName = "School" + random.Next(10).ToString();
                string district = "District" + random.Next(20).ToString();
                Student student = new Student(id: studentId, name: name, mark1: random.Next(100), mark2: random.Next(100), mark3: random.Next(100),schoolName:schoolName,district:district);
            }
        }

        public void FindStudentsByDistrict()
        {
            Console.WriteLine("Enter the District");
            string district = Console.ReadLine();
            List<Student> studentsByDistrict = db.FindStudentsByDistrict(district);
            PrintStudentList(studentsByDistrict, PrintStudentsByIdNameDistrict);
        }

        private void PrintStudentsByIdNameDistrict(Student student)
        {
            Console.WriteLine("Id:{0} Name:{1}", student.Id, student.Name, student.District);
        }

        public void FindStudentsBySchoolName()
        {
            Console.WriteLine("Enter School Name");
            String schoolName = Console.ReadLine();
            List<Student> studentsBySchoolName = db.FindStudentsBySchoolName(schoolName);
            PrintStudentList(studentsBySchoolName, PrintStudentsByIdNameSchoolName);
        }

        private void PrintStudentsByIdNameSchoolName(Student student)
        {
            Console.WriteLine("Id:{0} Name:{1}", student.Id, student.Name, student.SchoolName);
        }

        public void FindStudentsByName()
        {
            Console.WriteLine("Enter Name");
            String name = Console.ReadLine();
            List<Student> studentsByName = db.FindStudentsByName(name);
            PrintStudentList(studentsByName, PrintStudentsByName);
        }

        private void PrintStudentsByName(Student student)
        {
            Console.WriteLine("Id:{0} Name:{1}", student.Id, student.Name);
        }

        private void AddStudent()
        {
            Console.WriteLine("Enter Id");
            string userInput = Console.ReadLine();
            int id;
            if (!Int32.TryParse(userInput, out id))
            {
                Console.WriteLine("Invalid id ,Please enter the valid id in positive integer");
                return;
            }
            Console.WriteLine("Enter  Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Mark1");
            userInput = Console.ReadLine();
            int mark1;
            if (!Int32.TryParse(userInput, out mark1) || mark1 < 0 || mark1 > 100)
            {
                Console.WriteLine("Invalid Mark,Please enter the valid mark between mark<0&&mark>100");
                return;
            }
            Console.WriteLine("Enter Mark2");
            userInput = Console.ReadLine();
            int mark2;
            if (!Int32.TryParse(userInput, out mark2) || mark2 < 0 || mark2 > 100)
            {
                Console.WriteLine("Invalid Mark,Please enter the valid mark between mark<0&&mark>100");
                return;
            }
            Console.WriteLine("Enter Mark3");
            userInput = Console.ReadLine();
            int mark3;
            if (!Int32.TryParse(userInput, out mark3) || mark3 < 0 || mark3 > 100)
            {
                Console.WriteLine("Invalid Mark,Please enter the valid mark between mark<0&&mark>100");
                return;
            }
            Console.WriteLine("Enter School Name");
            string schoolName = Console.ReadLine();
            Console.WriteLine("Enter District");
            string district = Console.ReadLine();
            Student student = new Student(id, name, mark1, mark2, mark3, schoolName, district);
            db.AddStudent(student);
        }

        private void DeleteStudent()
        {
            Console.WriteLine("Enter Student Id:");
            string userInput = Console.ReadLine();
            int id;
            if (!Int32.TryParse(userInput, out id))
            {
                Console.WriteLine("Invalid id ,Please enter the valid id in positive integer");
                return;
            }
            if (!db.IsStudentExsit(id))
            {
                Console.WriteLine("No Students Exsit With Id:{0}", id);
                return;
            }
            db.DeleteStudents(id);
            Console.WriteLine("Delete Student with Id:{0}", id);
        }

        public void FindStudentWithHighestScores()
        {
            Student highScoreStudents = db.FindStudentWithHighestScores();
            if (highScoreStudents == null)
            {
                Console.WriteLine("No Student Exist");
                return;
            }
            Console.WriteLine("Student with Highest score");
            Console.WriteLine("Id:{0}Name:{1}Total Mark:{2}", highScoreStudents.Id, highScoreStudents.Name, highScoreStudents.Total);
        }

        private void FindStudentWithHundredMarks()
        {
            List<Student> studentWith100Marks = db.FindStudentsWithGivenMarks(100);
            PrintStudentList(studentWith100Marks, PrintStudentsList);
        }

        private void PrintStudentsList(Student student)
        {
            Console.WriteLine("Id:{0}Name:{1}Mark1:{2}Mark2:{3}Mark3:{4}", student.Id, student.Name, student.Mark1, student.Mark2, student.Mark3);
        }

        private void FindStudentsWithGivenMarks()
        {
            Console.WriteLine("Enter  Marks");
            string userInput = Console.ReadLine();
            int marks;
            if (!Int32.TryParse(userInput, out marks))
            {
                Console.WriteLine("Invalid Marks,Marks Should be 1=>0 && <=100");
                return;
            }
            List<Student> studentWithGivenMarks = db.FindStudentsWithGivenMarks(marks);
            PrintStudentList(studentWithGivenMarks, PrintStudentsList);
        }

        public void PrintTotalMarksInSortingMethod()
        {
            List<Student> ascendingOrder = db.PrintToalMarksInSorting();
            foreach (var iStudent in ascendingOrder)
            {
                Console.WriteLine("Id:{0}Name:{1}Total Mark:{2}", iStudent.Id, iStudent.Name, iStudent.Total);
            }
        }

        public void PrintAllStudentsList()
        {
            List<Student> allStudents= db.GetAllStudentsList();
            PrintStudentList(allStudents, PrintStudentInfo);
        }

        private void PrintStudentInfo(Student student)
        {
            Console.WriteLine("Id:{0}\t\tName:{1}\t\tMark1:{2}\t\tMark2:{3}\t\tMark3:{4}\t\tSchoolName:{5}\t\tDistrict:{6}",student.Id,student.Name,
                student.Mark1,student.Mark2,student.Mark3,student.SchoolName,student.District);
        }

        public void Run()
        {
            while (true)
            {
                DisplayMainMenu();
            }
        }
    }
}
