using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Database
{
    class UserInterface
    {
        StudentDb db = new StudentDb();

        private void DisplayMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("**************************************");
            Console.WriteLine("Students Database-Application By Raja");
            Console.WriteLine("**************************************");
            Console.WriteLine("Please select the options below to proceed");
            Console.WriteLine("c.Print Students Count");
            Console.WriteLine("a.Add a New Student");
            Console.WriteLine("d.Delete a Student");
            Console.WriteLine("h.Student with Hunderd Marks");
            Console.WriteLine("f.Student With Given Marks");
            Console.WriteLine("s.Student with Highest scores");
            Console.WriteLine("q.Exit");
            Console.Write("Enter Your Choice:");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
            switch (key.Key)
            {
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

                case ConsoleKey.H:
                    {
                        StudentWithHunderdMark();
                        break;
                    }
                case ConsoleKey.F:
                    {
                        StudentWithGivenMarks();
                        break;
                    }
                case ConsoleKey.S:
                    {
                        //StudentWithHighestScores();
                        break;
                    }
                case ConsoleKey.Q:
                    {
                        Environment.Exit(0);
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
            db.AddStudents(student);
        }

        private void DeleteStudent()
        {
            Console.WriteLine("Enter Id");
            string userInput = Console.ReadLine();
            int id;
            if (!Int32.TryParse(userInput, out id))
            {
                Console.WriteLine("Invalid id ,Please enter the valid id in positive integer");
                return;
            }

        }

        //public void StudentWithHighestScores()
        //{
        //    Console.WriteLine("Enter Id");
        //    string userInput = Console.ReadLine();

        //    db.PrintStudentsWithHighestScores(userInput);
        //}

        private void StudentWithHunderdMark()
        {
            List<Student> studentWith100Marks = db.PrintStudentWithHunderdMarks();
            bool foundMatchingStudent = false;
            foreach (var student in studentWith100Marks)
            {
                foundMatchingStudent = true;
                Console.WriteLine("Id:{0} Name:{1}", student.Id, student.Name);
            }
            if (foundMatchingStudent == false)
                Console.WriteLine("No one there get 100 marks  in Students ");
        }

        private void StudentWithGivenMarks()
        {
            Console.WriteLine("Enter  Mark1");
            string userInput = Console.ReadLine();
            int mark1;
            if (!Int32.TryParse(userInput, out mark1))
            {
                Console.WriteLine("Invalid Mark1, Please enter the correct mark1 between mark1=>0 && mark1<=100");
                return;
            }
            List<Student> studentWithGivenMarks = db.FindStudentWithGivenMarks(mark1);
            foreach (var student in studentWithGivenMarks)
            {
                Console.WriteLine("Id{0} Name{0}", student.Id, student.Name);
            }
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
