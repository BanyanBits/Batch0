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
        delegate void PrintStudentInfoDelegate(Student student);

        private void PrintStudentList(List<Student> students, PrintStudentInfoDelegate printStudentsInfoMethod, string InStudents)
        {
            if (students.Any() == false)
            {
                Console.WriteLine("No Students Found");
                return;
            }
            Console.WriteLine(InStudents);
            Console.WriteLine();
            foreach (var student in students)
            {
                printStudentsInfoMethod(student);
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
            Console.WriteLine("t.Add 10 Test Students");
            Console.WriteLine("j.Find Top Student In Subjects ");
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
                case ConsoleKey.J:
                    {
                        FindTopStudentInSubjects();
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
                default:
                    {
                        Console.WriteLine("Enter the correct options ");
                        break;
                    }
            }
            Console.WriteLine("Enter any press key to contiune");
            Console.ReadKey();
        }

        private void PrintStudentsCount()
        {
            Console.WriteLine("Total Number Of Students in the Database:{0}", db.Count);
        }

        private void FindTopStudentInSubjects()
        {
            Console.WriteLine("a.Find TopStudent In Mark1");
            Console.WriteLine("b.Find TopStudent In Mark2");
            Console.WriteLine("c.Find TopStudent In Mark3");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.A:            
                    {
                        StudentDb.GetMarksDelegateMethod GetMark1 = (Student s) =>
                            {
                                return s.Mark1;
                            };
                        Console.WriteLine("Top Student in Mark1");
                        FindTopStudent(GetMark1);
                        break;
                    }
                case ConsoleKey.B:
                    {
                        StudentDb.GetMarksDelegateMethod GetMark2 = (Student s) =>
                        {
                            return s.Mark2;
                        };
                        Console.WriteLine("Top Student in Mark2");
                        FindTopStudent(GetMark2);
                        break;
                    }
                case ConsoleKey.C:
                    {
                        StudentDb.GetMarksDelegateMethod GetMark3 = (Student s) =>
                        {
                            return s.Mark3;
                        };
                        Console.WriteLine("Top Student in Mark3");
                        FindTopStudent(GetMark3);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }
        }

        private void AddTestStudents()
        {
            Random random = new Random();
            int AddedNoOfStudentsCount = 10;
            int studentCount = db.Count;
            for (int i = 1; i <= AddedNoOfStudentsCount; i++)
            {
                int studentId = studentCount + i;
                string name = "Student" + studentId.ToString();
                int mark1 = random.Next(90, 100);
                int mark2 = random.Next(80, 90);
                int mark3 = random.Next(70, 90);
                string schoolName = "School" + random.Next(10).ToString();
                string district = "District" + random.Next(20).ToString();
                Student student = new Student(id: studentId, name: name, mark1: mark1, mark2: mark2, mark3: mark3, schoolName: schoolName, district: district);
                db.AddStudent(student);
            }
        }

        public void FindStudentsByDistrict()
        {
            Console.WriteLine("Enter the District");
            string district = Console.ReadLine();
            PrintStudentInfoDelegate printStudentsByIdNameDistrict = (Student student) =>
                {
                    Console.WriteLine("{0}\t{1}\t{2}", student.Id, student.Name, student.District);
                };
            List<Student> studentsByDistrict = db.FindStudentsByDistrict(district);
            string headerInStudents = ("Id\t\tName\t\tDistrict");
            PrintStudentList(studentsByDistrict, printStudentsByIdNameDistrict, headerInStudents);
        }

        public void FindStudentsBySchoolName()
        {
            Console.WriteLine("Enter School Name");
            String schoolName = Console.ReadLine();
            PrintStudentInfoDelegate printStudentsByIdNameSchoolName = (Student student) =>
                {
                    Console.WriteLine("{0}\t{1}\t{2}", student.Id, student.Name, student.SchoolName);
                };
            List<Student> studentsBySchoolName = db.FindStudentsBySchoolName(schoolName);
            string headerInStudents = ("Id\t\tName\t\tSchoolName");
            PrintStudentList(studentsBySchoolName, printStudentsByIdNameSchoolName, headerInStudents);
        }

        public void FindStudentsByName()
        {
            Console.WriteLine("Enter Name");
            String name = Console.ReadLine();
            PrintStudentInfoDelegate printStudentsByName = (Student student) =>
                {
                    Console.WriteLine("{0}\t{1}", student.Id, student.Name);
                };
            List<Student> studentsByName = db.FindStudentsByName(name);
            string headerInStudents = ("Id\t\tName");
            PrintStudentList(studentsByName, printStudentsByName, headerInStudents);
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

        private void FindTopStudent(StudentDb.GetMarksDelegateMethod getMethod)
        {
            Student topStudent = db.GetTopStudent(getMethod);
            if (topStudent == null)
            {
                Console.WriteLine("No Student Found");
                return;
            }           
            int mark = getMethod(topStudent);
            Console.WriteLine("Id:{0} Name:{1} Mark:{3)", topStudent.Id, topStudent.Name, mark);
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
            PrintStudentInfoDelegate printStudentsList = (Student student) =>
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", student.Id, student.Name, student.Mark1, student.Mark2, student.Mark3);
            };
            List<Student> studentWith100Marks = db.FindStudentsWithGivenMarks(100);
            string headerInStudents = ("Id\t\tName\t\tMark1\t\tMark2\t\tMark3");
            PrintStudentList(studentWith100Marks, printStudentsList, headerInStudents);
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
            PrintStudentInfoDelegate printStudentsList = (Student student) =>
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", student.Id, student.Name, student.Mark1, student.Mark2, student.Mark3);
                };
            List<Student> studentWithGivenMarks = db.FindStudentsWithGivenMarks(marks);
            string headerInStudents = ("Id\t\tName\t\tMark1\t\tMark2\t\tMark3");
            PrintStudentList(studentWithGivenMarks, printStudentsList, headerInStudents);
        }

        public void PrintAllStudentsList()
        {
            PrintStudentInfoDelegate printMethod = (Student student) =>
             {
                 Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5} \t{6}", student.Id, student.Name,
                student.Mark1, student.Mark2, student.Mark3, student.SchoolName, student.District);
             };
            List<Student> allStudents = db.GetAllStudentsList();
            string headerInStudents = ("Id\tName    \tMark1 \tMark2\tMark3\tSchoolName \tDistrict");
            PrintStudentList(allStudents, printMethod, headerInStudents);
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
