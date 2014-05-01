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
            if (key.Key == ConsoleKey.Q)
            {
                Environment.Exit(0);
            }
        }

        public void AddStudent()
        {
            Student student = new Student(1, "Raja", 19);
            db.AddStudent(student);
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
