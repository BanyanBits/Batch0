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
            Console.WriteLine("b.Add a new Student");
            Console.WriteLine("c.Delete a Student");
            Console.WriteLine("d.Add 10 Test Students ");
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
                case ConsoleKey.C:
                    {
                        DeleteStudent();
                        break;
                    }
                case ConsoleKey.D:
                    {
                        AddTestStudents();
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
            Console.WriteLine("Total Number Of Students in the Database{0}",db.Count);
        }

        private void AddStudent()
        {
            Console.WriteLine("Enter Id");
            int id;
            string userInput = Console.ReadLine();
            if(!Int32.TryParse(userInput,out id))
            {
                Console.WriteLine("Invalid Id,Please enter the id Positive Integer");
                return;
            }
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Mark1");
            int mark1;
            userInput = Console.ReadLine();
            if((!Int32.TryParse(userInput,out mark1))||mark1<0||mark1>100)
            {
                Console.WriteLine("InValid mark1,Please enter Mark1 Between mark1<0&&mark1>100");
                return;
            }
            Console.WriteLine("Enter Mark2");
            int mark2;
            userInput = Console.ReadLine();
            if ((!Int32.TryParse(userInput, out mark2)) || mark2 < 0 || mark2 > 100)
            {
                Console.WriteLine("InValid mark2,Please enter Mark2 Between mark2<0&&mark2>100");
                return;
            }
            Console.WriteLine("Enter Mark3");
            int mark3;
            userInput = Console.ReadLine();
            if ((!Int32.TryParse(userInput, out mark3)) || mark3 < 0 || mark3 > 100)
            {
                Console.WriteLine("InValid mark3,Please enter Mark1 Between mark3<0&&mark3>100");
                return;
            }
            Console.WriteLine("Enter SchoolName");
            string schoolName = Console.ReadLine();
            Console.WriteLine("Enter District");
            string district = Console.ReadLine();
            Student student = new Student(id, name, mark1, mark2, mark3, schoolName, district);
            db.AddStudent(student);
        }

        private void DeleteStudent()
        {
            Console.WriteLine("Enter Id");
            int id;
            string userInput = Console.ReadLine();
            if (!Int32.TryParse(userInput, out id))
            {
                Console.WriteLine("Invalid Id,Please enter the id Positive Integer");
                return;
            }
            if(!db.IsStudentExist(id))
            {
                Console.WriteLine("Invalid Id{0} ",id);
                return;
            }
            db.DeleteStudent(id);
            Console.WriteLine("Delete Student With Id{0}",id);
        }

        private void AddTestStudents()
        {
            Random random = new Random();
            int AddedTestStudentsCount = 10;
            int studentCount = db.Count;
            for (int i = 0; i < AddedTestStudentsCount; i++)
            {
                int studentId = studentCount + i;
                string name="Student"+studentId.ToString();
                int mark1 = random.Next(90, 100);
                int mark2 = random.Next(80, 90);
                int mark3 = random.Next(70, 80);
                string schoolName = "schoolname" + random.Next(10).ToString();
                string district = "district" + random.Next(20).ToString();
                Student student = new Student(id: studentId, name: name, mark1: mark1, mark2: mark2, mark3: mark3, schoolname: schoolName, district: district);
                db.AddStudent(student);
            }
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
