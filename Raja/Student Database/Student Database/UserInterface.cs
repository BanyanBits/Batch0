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
            Console.WriteLine("h.Print Student with Hunderd Marks");
            Console.WriteLine("f.Find Students With Given Marks");
            Console.WriteLine("s.Find Students with Highest scores");
            Console.WriteLine("n.Find Students by School Name");
            Console.WriteLine("b.Find Students By District");
            Console.WriteLine("p.Find Students By Name");
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
                case ConsoleKey.P:
                    {
                        FindStudentsByName();
                        break;
                    }

                case ConsoleKey.H:
                    {
                        FindStudentWithHunderdMarks();
                        break;
                    }
                case ConsoleKey.F:
                    {
                        FindStudentsWithGivenMarks();
                        break;
                    }
                case ConsoleKey.S:
                    {
                        StudentWithHighestScores();
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

        public void FindStudentsByDistrict()
        {
            Console.WriteLine("Enter the District");
            string district = Console.ReadLine();
            List<Student> studentsByDistrict = db.FindStudentsByDistrict(district);
            foreach (var iStudent in studentsByDistrict)
            {
               Console.WriteLine("Id:{0} Name:{1} District:{2}", iStudent.Id, iStudent.Name, iStudent.District); 
            }
        }

        public void FindStudentsBySchoolName()
        {
            Console.WriteLine("Enter School Name");
            String schoolName = Console.ReadLine();
            List<Student> studentsBySchoolName = db.FindStudentsBySchoolName(schoolName);
            foreach (var student in studentsBySchoolName)
            {
                Console.WriteLine("Id:{0} Name:{1} SchoolNmae:{2}", student.Id, student.Name, student.SchoolName);
            }
        }

        public void FindStudentsByName()
        {
            Console.WriteLine("Enter Name");
            String name = Console.ReadLine();
            List<Student> studentsByName = db.FindStudentsByName(name);
            foreach (var student in studentsByName)
            {
                Console.WriteLine("Id:{0} Name:{1}", student.Id, student.Name);
            }
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

        public void StudentWithHighestScores()
        {
            Console.WriteLine("Enter Id");
            string userInput = Console.ReadLine();
            int id;
            if (!Int32.TryParse(userInput, out id))
            {
                Console.WriteLine("Invalid id ,Please enter the valid id in positive integer");
                return;
            }
            Student highScoreStudents = db.FindStudentsWithHighestScores();
        }

        private void FindStudentWithHunderdMarks()
        {
            List<Student> studentWith100Marks = db.FindStudentsWithGivenMarks(100);
            PrintStudentsList(studentWith100Marks);
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
            PrintStudentsList(studentWithGivenMarks);
        }

        private void PrintStudentsList(List<Student> students)
        {
            if (students.Any() == false)
            {
                Console.WriteLine("No Student Found");
                return;
            }
            foreach (var student in students)
            {
                Console.WriteLine("Id:{0}Name:{1}Mark1:{2}Mark2:{3}Mark3:{4}", student.Id, student.Name, student.Mark1, student.Mark2, student.Mark3);
            }
            Console.WriteLine("Total Students:{0}", students.Count);
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
