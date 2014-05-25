using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseTest1
{
    class UserInterface
    {
        SttudentDb db = new SttudentDb();

        private void DisplayMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Student Database Application- Raja");
            Console.WriteLine("***********************************");
            Console.WriteLine("please Select Option Given Below it is Proceed");
            Console.WriteLine("a.Print Students Count");
            Console.WriteLine("b.Add New Student");
            Console.WriteLine("c.Delete a Student");
            Console.WriteLine("d.Find Student with HighestScores");
            Console.WriteLine("b.Quit");
            Console.WriteLine("Enter your Choice ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
            switch (key.Key)
            {
                case ConsoleKey.A:
                    {
                        PrintStudentsCount();
                        break;
                    }
                case ConsoleKey.B:
                    {
                        AddNewStudent();
                        break;
                    }
                case ConsoleKey.C:
                    {
                        DeleteStudent();
                        break;
                    }
                case ConsoleKey.D:
                    {
                        FindStudentWithHighestScore();
                        break;
                    }
                case ConsoleKey.Q:
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }
            
        }

        private void PrintStudentsCount()
        {
            Console.WriteLine("Total Students Count in the DataBase:{0}", db.Count);
        }

        private void DeleteStudent()
        {
            Console.WriteLine("Enter Id");
            int id;
            string userInput = Console.ReadLine();
            if (!Int32.TryParse(userInput, out id))
            {
                Console.WriteLine("Invalid Id,please  enter valid positive Integer");
                return;
            }
            if(!db.IsStudentExist(id))
            {
                Console.WriteLine("Invalid Input{0}",id);
                return;
            }
            db.DeleteStudent(id);
            Console.WriteLine("Delete Student With Id{0}",id);          
        }

        private void FindStudentWithHighestScore()
        {
            Student studentWithHighScore = db.FindStudentWithHighestScore();
            if(studentWithHighScore==null)
            {
                Console.WriteLine("No Student Found");
                return;
            }
            Console.WriteLine("Id:{0} name:{1} Total:{2}",studentWithHighScore.Id,studentWithHighScore.Name,studentWithHighScore.Total);
        }

        private void AddNewStudent()
        {
            Console.WriteLine("Enter Id");
            int id;
            string userInput = Console.ReadLine();
            if (!Int32.TryParse(userInput, out id))
            {
                Console.WriteLine("Invalid Id,please  enter valid positive Integer");
                return;
            }
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Mark1");
            int mark1;
            userInput = Console.ReadLine();
            if ((!Int32.TryParse(userInput, out mark1)) || mark1 < 0 || mark1 > 100)
            {
                Console.WriteLine("Invalid Mark1,Please Enter Mark1 between mark1<0&&mark1>100");
                return;
            }
            Console.WriteLine("Enter Mark2");
            int mark2;
            userInput = Console.ReadLine();
            if ((!Int32.TryParse(userInput, out mark2)) || mark2 < 0 || mark2 > 100)
            {
                Console.WriteLine("Invalid Mark1,Please Enter Mark2 between mark2<0&&mark2>100");
                return;
            }
            Console.WriteLine("Enter Mark3");
            int mark3;
            userInput = Console.ReadLine();
            if ((!Int32.TryParse(userInput, out mark3)) || mark3 < 0 || mark3 > 100)
            {
                Console.WriteLine("Invalid Mark1,Please Enter Mark3 between mark3<0&&mark3>100");
                return;
            }
            Console.WriteLine("Enter SchoolName");
            string schoolName = Console.ReadLine();
            Console.WriteLine("Enter District");
            string district = Console.ReadLine();
            Student student = new Student(id, name, mark1, mark2, mark3, schoolName, district);
            db.AddStudent(student);
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
