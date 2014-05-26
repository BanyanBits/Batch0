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

        delegate void PrintStudentInfo(Student student);
        private void PrintStudentList(List<Student> students, PrintStudentInfo printstudent, string header)
        {
            if (!students.Any())
            {
                Console.WriteLine("No Student Found");
                return;
            }
            Console.WriteLine(header);
            Console.WriteLine();
            foreach (var student in students)
            {
                printstudent(student);
            }
        }

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
            Console.WriteLine("e.Find Students With Hundred Marks");
            Console.WriteLine("f.Find Students with Matching marks");
            Console.WriteLine("g.Add Test Students");
            Console.WriteLine("h.Print All Students List");
            Console.WriteLine("m.Find Students By Name");
            Console.WriteLine("n.Find Students By SchoolName"); 
            Console.WriteLine("o.Find Students By District");
            Console.WriteLine("p.Find Top Student For Each Subjects");
            Console.WriteLine("w.Sort Students");
            Console.WriteLine("Q.Quit");
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
                case ConsoleKey.E:
                    {
                        FindStudentWithHundredMarks();
                        break;
                    }
                case ConsoleKey.F:
                    {
                        FindStudentWithGivenMarks();
                        break;
                    }
                case ConsoleKey.G:
                    {
                        AddTestStudents();
                        break;
                    }
                case ConsoleKey.H:
                    {
                        PrintAllStudentsList();
                        break;
                    }
                case ConsoleKey.M:
                    {
                        FindStudentsByName();
                        break;
                    }
                case ConsoleKey.N:
                    {
                        FindStudentsBySchoolName();
                        break;
                    }
                case ConsoleKey.P:
                    {
                        FindTopStudentsEachSubjects();
                        break;
                    }
                case ConsoleKey.O:
                    {
                        FindStudentsByDistrict();
                        break;
                    }
                case ConsoleKey.W:
                    {
                        FindSortStudents();
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

        private void FindTopStudentsEachSubjects()
        {
            Console.WriteLine("");
            Console.WriteLine("a.Top Student For Mark1");
            Console.WriteLine("b.Top Student For Mark2");
            Console.WriteLine("c.Top Student For Mark3");
            Console.WriteLine("Enter Your Choice");
            ConsoleKeyInfo key = Console.ReadKey();
            switch(key.Key)
            {
                case ConsoleKey.A:
                    {
                        TopStudentMark("mark1");
                        break;
                    }
                case ConsoleKey.B:
                    {
                        TopStudentMark("mark2");
                        break;
                    }
                case ConsoleKey.C:
                    {
                        TopStudentMark("mark3");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }
        }
        
        private void FindSortStudents()
        {
            Console.WriteLine("");
            Console.WriteLine("a.Sort Student By Id");
            Console.WriteLine("b.Sort Student By Name");
            Console.WriteLine("c.Sort Student By Mark1");
            Console.WriteLine("d.Sort Student By Mark2");
            Console.WriteLine("e.Sort Student By Mark3");
            Console.WriteLine("f.Sort Student By SchoolName");
            Console.WriteLine("g.Sort Student By District");
            Console.WriteLine("Enter Your Choice");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.A:
                    {
                        SortStudentById();
                        break;
                    }
                case ConsoleKey.B:
                    {
                        SortStudentByName();
                        break;
                    }
                case ConsoleKey.C:
                    {
                        SortStudentByMark1();
                        break;
                    }
                case ConsoleKey.D:
                    {
                        SortStudentByMark2();
                        break;
                    }
                case ConsoleKey.E:
                    {
                        SortStudentByMark3();
                        break;
                    }
                case ConsoleKey.F:
                    {
                        SortStudentBySchoolName();
                        break;
                    }
                case ConsoleKey.G:
                    {
                        SortStudentByDistrict();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }

        }

        private void SortStudentById()
        {
            PrintStudentInfo printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}", student.Id, student.Name);
            };
            var sortStudents = db.SortStudents((a, b) => a.Id > b.Id);
            string header = ("Id\tName");
            PrintStudentList(sortStudents, printStudent, header);                          
        }

        private void  SortStudentByName()
        {
            PrintStudentInfo printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}", student.Id, student.Name);
            };
            var sortStudents = db.SortStudents((a, b) => string.Compare(a.Name,b.Name)>0);
            string header = ("Id\tName");
            PrintStudentList(sortStudents, printStudent, header);                          
        }

        private void SortStudentByMark1()
        {
            PrintStudentInfo printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}", student.Id, student.Mark1);
            };
            var sortStudents = db.SortStudents((a, b) => a.Mark1> b.Mark1);
            string header = ("Id\tMark1");
            PrintStudentList(sortStudents, printStudent, header);
        }

        private void SortStudentByMark2()
        {
            PrintStudentInfo printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}", student.Id, student.Mark2);
            };
            var sortStudents = db.SortStudents((a, b) => a.Mark2 > b.Mark2);
            string header = ("Id\tMark2");
            PrintStudentList(sortStudents, printStudent, header);
        }

        private void SortStudentByMark3()
        {
            PrintStudentInfo printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}", student.Id, student.Mark3);
            };
            var sortStudents = db.SortStudents((a, b) => a.Mark3 > b.Mark3);
            string header = ("Id\tMark3");
            PrintStudentList(sortStudents, printStudent, header);
        }

        private void SortStudentBySchoolName()
        {
            PrintStudentInfo printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}", student.Id, student.SchoolName);
            };
            var sortStudents = db.SortStudents((a, b) => string.Compare(a.SchoolName,b.SchoolName)>0);
            string header = ("Id\tSchoolName");
            PrintStudentList(sortStudents, printStudent, header);
        }

        private void SortStudentByDistrict()
        {
            PrintStudentInfo printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}", student.Id, student.District);
            };
            var sortStudents = db.SortStudents((a, b) => string.Compare(a.District, b.District) > 0);
            string header = ("Id\tDistrict");
            PrintStudentList(sortStudents, printStudent, header);
        }
        public void TopStudentMark(string subjectName)
        {
            Student topStudent = db.TopStudentByMarks(subjectName);
            if(topStudent==null)
            {
                Console.WriteLine("No Students Found");
                return;
            }
            Console.WriteLine("Top Student is:{0}",subjectName);
            int marks = 0;
            if(subjectName=="mark1")
            {
                marks = topStudent.Mark1;
            }
            if (subjectName == "mark2")
            {
                marks = topStudent.Mark2;
            }
            if (subjectName == "mark3")
            {
                marks = topStudent.Mark3;
            }
            Console.WriteLine("Id:{0} Name:{1} TopMark:{2}",topStudent.Id,topStudent.Name,marks);
        }

        private void AddTestStudents()
        {
            Random random = new Random();
            int addedTestStudents = 10;
            int studentCount = db.Count;
            for (int i = 1; i <=addedTestStudents; i++)
            {
                int studentId=studentCount+i;
                string name="student"+ random.Next(10).ToString();
                int mark1=random.Next(90,100);
                int mark2=random.Next(80,100);
                int mark3=random.Next(100);
                string schoolName="schoolName"+random.Next(10).ToString();
                string district="district"+random.Next(10).ToString();
                Student student =new Student(id:studentId,name:name,mark1:mark1,mark2:mark2,mark3:mark2,schoolName:schoolName,district:district);
                db.AddStudent(student);
            }
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
            if (!db.IsStudentExist(id))
            {
                Console.WriteLine("Invalid Input{0}", id);
                return;
            }
            db.DeleteStudent(id);
            Console.WriteLine("Delete Student With Id{0}", id);
        }

        private void FindStudentWithHighestScore()
        {
            Student studentWithHighScore = db.FindStudentWithHighestScore();
            if (studentWithHighScore == null)
            {
                Console.WriteLine("No Student Found");
                return;
            }
            Console.WriteLine("Id:{0} name:{1} Total:{2}", studentWithHighScore.Id, studentWithHighScore.Name, studentWithHighScore.Total);
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

        private void FindStudentWithHundredMarks()
        {

            PrintStudentInfo printmethod = (Student s) =>
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", s.Id, s.Name, s.Mark1, s.Mark2, s.Mark3);
                };
            List<Student> studentWith100Marks = db.FindStudentWithMarks(100);
            string header = ("Id\t\tName\t\tMark1\t\tMark2\t\tMark3");
            PrintStudentList(studentWith100Marks, printmethod, header);
        }

        private void PrintAllStudentsList()
        {
            PrintStudentInfo printmethod = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", s.Id, s.Name, s.Mark1, s.Mark2, s.Mark3,s.SchoolName,s.District);
            };
            List<Student> studentsList = db.PrintStudentList();
            string header = ("Id\tName\tMark1\tMark2\tMark3\tSchoolName\tDistrict");
            PrintStudentList(studentsList, printmethod, header);
        }
       
        private void FindStudentsByName()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            PrintStudentInfo printmethod = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}", s.Id, s.Name);
            };
            List<Student> studentsByName = db.FindStudentsByName(name);
            string header = ("Id\tName");
            PrintStudentList(studentsByName, printmethod, header);
        }
         
        private void FindStudentsBySchoolName()
        {
            Console.WriteLine("Enter SchoolName");
            string schoolName = Console.ReadLine();
            PrintStudentInfo printmethod = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}", s.Id, s.SchoolName);
            };
            List<Student> studentsBySchoolName = db.FindStudentsBySchoolName(schoolName);
            string header = ("Id\tSchoolName");
            PrintStudentList(studentsBySchoolName, printmethod, header);
        }

        private void FindStudentsByDistrict()
        {
            Console.WriteLine("Enter District");
            string district = Console.ReadLine();
            PrintStudentInfo printmethod = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}", s.Id, s.District);
            };
            List<Student> studentsByDistrict = db.FindStudentsByName(district);
            string header = ("Id\tDistrict");
            PrintStudentList(studentsByDistrict, printmethod, header);
        }

        private void FindStudentWithGivenMarks()
        {
            Console.WriteLine("Enter Marks");
            int marks;
            string userInput = Console.ReadLine();
            if ((!Int32.TryParse(userInput, out marks)) || marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid Marks,Please Enter Marks between mark<0&&marks>100");
                return;
            }
            PrintStudentInfo printmethod = (Student s) =>
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", s.Id, s.Name, s.Mark1, s.Mark2, s.Mark3);
                };
            List<Student> studentWithGivenMarks = db.FindStudentWithMarks(marks);
            string header = ("Id\t\tName\t\tMark1\t\tMark2\t\tMark3");
            PrintStudentList(studentWithGivenMarks, printmethod, header);
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
