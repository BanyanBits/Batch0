using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseTest
{
    class UserInterFace
    {
        StudentDb db = new StudentDb();

        private void DisplayMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("************************************");
            Console.WriteLine("Student DataBase Application By Raja");
            Console.WriteLine("************************************");
            Console.WriteLine("Please Select The Option Given Below");
            Console.WriteLine("a.Print Students Count");
            Console.WriteLine("b.Add Student");
            Console.WriteLine("q.quit");
            Console.WriteLine("Enter Your Choice");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
            switch (keyInfo.Key)
            {
                case ConsoleKey.A:
                    {
                        PrintStudentsCount();
                        break;
                    }
                case ConsoleKey.B:
                    {
                        AddStudent();
                        break;
                    }
                case ConsoleKey.Q:
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input,Please Select Correct Option");
                        break;
                    }
            }
        }

        public void PrintStudentsCount()
        {
            Console.WriteLine("Total Number Of Students in the Database",db.Count);
        }

        public void Run()
        {
            while(true)
            {
                DisplayMainMenu();
            }
        }
    }
}
