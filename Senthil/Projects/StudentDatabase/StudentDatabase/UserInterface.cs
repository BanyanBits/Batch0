using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    class UserInterface
    {
        StudentDb db = new StudentDb();

        private void DisplayMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("=======================================");
            Console.WriteLine("Students Database - Application By Raja");
            Console.WriteLine("=======================================");
            Console.WriteLine("Please select the options below to proceed");
            Console.WriteLine(" c.Print Students Count");
            Console.WriteLine(" a.Add a new student");
            Console.WriteLine(" q.Exit");
            Console.Write("Enter your choice:");
            ConsoleKeyInfo key =  Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
            if(key.Key == ConsoleKey.C)
            {
                PrintStudentsCount();
            }
            if (key.Key == ConsoleKey.A)
            {
                AddStudent();
            }
            if(key.Key == ConsoleKey.Q)
            {
                Environment.Exit(0);
            }
        }

        private void AddStudent()
        {
            Console.WriteLine("Enter Student Id:");
            string id = Console.ReadLine();

            Student student = new Student(1, "Raja", 100);
            db.AddStudent(student);
        }

        private void PrintStudentsCount()
        {
            Console.WriteLine("Total Number Of Students in the database:{0}", db.Count);
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
