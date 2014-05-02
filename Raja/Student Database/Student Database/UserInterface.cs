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

        public void StudentMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("************************************");
            Console.WriteLine("Student Database-Application by Raja");
            Console.WriteLine("************************************");
            Console.WriteLine("Please select options below and Entry the student application");
            Console.WriteLine("a.Print Students Count");
            Console.WriteLine("c.Add the Student");
            Console.WriteLine("d.Delete the Student");
            Console.WriteLine("h.Students who scored hunderd marks");
            Console.WriteLine("q.Exit");
            Console.Write("Enter Your Choice");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
            if (key.Key == ConsoleKey.A)
            {
                PrintStudentcount();
            }
            if (key.Key == ConsoleKey.C)
            {
                AddStudent();
            }
            if(key.Key==ConsoleKey.H)
            {
                StudentWithHunderdMark();
            }
            if (key.Key == ConsoleKey.D)
            {
                DeleteStudent();
            }
            if (key.Key == ConsoleKey.Q)
            {
                Environment.Exit(0);
            }
        }

        public void StudentWithHunderdMark()
        {
            db.StudentWithTopMark();
        }

        public void AddStudent()
        {
            Console.WriteLine("Enter the Id:");
            string userInput = Console.ReadLine();
            int id;
            if (!Int32.TryParse(userInput, out id))
            {
                Console.WriteLine("Invalid id ,Please enter the valid id in positive Integer ");
                return;
            }
            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Mark1");
            userInput = Console.ReadLine();
            int mark1;
            if (!Int32.TryParse(userInput, out mark1) || mark1 < 0 || mark1 > 100)
            {
                Console.WriteLine("Invalid mark ,Please enter the valid mark between mark<0&&mark>100");
                return;
            }
            Student student = new Student(id, name, mark1);
            db.AddStudent(student);
        }

        public void DeleteStudent()
        {
            db.DeleteStudent(1);
        }

        public void PrintStudentcount()
        {
            Console.WriteLine("Total number of student from the Database{0}", db.Count);
        }

        public void Run()
        {
            while (true)
            {
                StudentMainMenu();
            }
        }
    }
}
