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

        delegate void PrintStudentInfoDelegate(Student student);

        private void PrintStudentList(List<Student> students,PrintStudentInfoDelegate printStudentInfoMethod,string printMethod)
        {
            if(students.Any()==false)
            {
                Console.WriteLine("No Students Found");
                return;
            }
            Console.WriteLine(printMethod);
            Console.WriteLine();
            foreach (var student in students)
            {
                printStudentInfoMethod(student); 
            }
        }

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
            Console.WriteLine("e.Find Student with HighestScore");
            Console.WriteLine("f.Find Students Wiyh Hunderd Marks");
            Console.WriteLine("g.Find Students Given Matching Marks");
            Console.WriteLine("h.Print All Students List");
            Console.WriteLine("i.Find Students By Name");
            Console.WriteLine("j.Find Students By School Name");
            Console.WriteLine("k.Find Students By District");
            Console.WriteLine("l.Find Top Student In Subjects");
            Console.WriteLine("m.Find Sort Students");
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
                case ConsoleKey.E:
                    {
                        FindStudentWithHighestScore();
                        break;
                    }
                case ConsoleKey.F:
                    {
                        FindStudentsWithHunderdMarks();
                        break;
                    }
                case ConsoleKey.G:
                    {
                        FindStudentsGivenMarks();
                        break;
                    }
                case ConsoleKey .H:
                    {
                        PrintAllStudentsList();
                        break;
                    }
                case ConsoleKey.I:
                    {
                        FindStudentsByName();
                        break;
                    }
                case ConsoleKey.J:
                    {
                        FindStudentsBySchoolName();
                        break;
                    }
                case ConsoleKey.K:
                    {
                        FindStudentsByDistrict();
                        break;
                    }
                case ConsoleKey.L:
                    {
                        FindTopStudentInSubjects();
                        break;
                    }
                case ConsoleKey.Q:
                    {
                        Environment.Exit(0);
                        break;
                    }
                case ConsoleKey.M:
                        {
                            FindSortStudents();
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
            for (int i = 1; i <=AddedTestStudentsCount; i++)
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

        public void FindStudentWithHighestScore()
        {
            Student HighestScoreStudent = db.FindStudentWithHighestScore();
            if(HighestScoreStudent==null)
            {
                Console.WriteLine("No Students Found");
                return;
            }
            Console.WriteLine("Id:{0} Name:{1} TotalMark:{2}",HighestScoreStudent.Id,HighestScoreStudent.Name,HighestScoreStudent.Total);
        }

        private void FindStudentsWithHunderdMarks()
        {
                PrintStudentInfoDelegate printStudent = (Student student) =>
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}",student.Id,student.Name,student.Mark1,student.Mark2,student.Mark3);
                };
                List<Student> studentWith100Marks = db.FindStudentsWithGivenMarks(100);
                string header=("Id\t\tName\t\tMark1\t\tMark2\t\tMark3");
                PrintStudentList(studentWith100Marks,printStudent,header);
        }

        private void FindStudentsGivenMarks()
        {
            Console.WriteLine("Enter  the Marks");
            int marks;
            string userInput = Console.ReadLine();
            if ((!Int32.TryParse(userInput, out marks)) || marks < 0 || marks > 100)
            {
                Console.WriteLine("InValid mark1,Please enter Mark1 Between mark1<0&&mark1>100");
                return;
            }
            PrintStudentInfoDelegate printStudent = (Student student) =>
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",student.Id,student.Name,student.Mark1,student.Mark2,student.Mark3);
                };
            List<Student> studentsWithGivenMarks = db.FindStudentsWithGivenMarks(marks);
            string header = ("Id\tName\tMark1\tMark2\tMark3");
            PrintStudentList(studentsWithGivenMarks,printStudent,header);
        }

        private void PrintAllStudentsList()
        {
            PrintStudentInfoDelegate printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", student.Id, student.Name, student.Mark1, student.Mark2, student.Mark3,student.SchoolName,student.District);
            };
            List<Student> printAllStudents = db.AllstudentsList();
            string header = ("Id\tName\tMark1\tMark2\tMark3\tSchoolName\tDistrict");
            PrintStudentList(printAllStudents, printStudent, header);
        }

        private void FindStudentsByName()
        {
            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();
            PrintStudentInfoDelegate printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}", student.Id, student.Name);
            };
            List<Student> studentsByName = db.FindStudentsByName(name);
            string header = ("Id\tName");
            PrintStudentList(studentsByName, printStudent, header);
        }

        private void FindStudentsBySchoolName()
        {
            Console.WriteLine("Enter the SchoolName");
            string schoolName = Console.ReadLine();
            PrintStudentInfoDelegate printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}", student.Id, student.Name,student.SchoolName);
            };
            List<Student> studentsByName = db.FindStudentsByName(schoolName);
            string header = ("Id\tName\tSchoolName");
            PrintStudentList(studentsByName, printStudent, header);
        }

        private void FindStudentsByDistrict()
        {
            Console.WriteLine("Enter the District");
            string district = Console.ReadLine();
            PrintStudentInfoDelegate printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}", student.Id, student.Name, student.SchoolName);
            };
            List<Student> studentsByName = db.FindStudentsByName(district);
            string header = ("Id\tName\tSchoolName");
            PrintStudentList(studentsByName, printStudent, header);
        }

        private void FindTopStudentInSubjects()
        {
            Console.WriteLine("");
            Console.WriteLine("a.Find Top Student In Mark1");
            Console.WriteLine("b.Find Top Student In Mark2");
            Console.WriteLine("c.Find Top Student In Mark3");
            ConsoleKeyInfo key = Console.ReadKey();
            switch(key.Key)
            {
                case ConsoleKey.A:
                    {
                        //StudentDb.GetMarksDelegateMethod getMark1 = (Student s) =>
                        //{
                        //    return s.Mark1;
                        //};
                        //Console.WriteLine("Top Student In Mark1");
                        //FindTopStudent(getMark1);
                        FindTopStudent("mark1");
                        break;
                    }
                case ConsoleKey.B:
                    {
                        //StudentDb.GetMarksDelegateMethod getMark2 = (Student s) =>
                        //    {
                        //        return s.Mark2;
                        //    };
                        //Console.WriteLine("Top Student In Mark2");
                        //FindTopStudent(getMark2);
                        FindTopStudent("mark2");
                        break;
                    }
                case ConsoleKey.C:
                    {
                        //StudentDb.GetMarksDelegateMethod getMark3 = (Student s) =>
                        //{
                        //    return s.Mark3;
                        //};
                        //Console.WriteLine("Top Student In Mark3");
                        //FindTopStudent(getMark3);
                        FindTopStudent("mark3");
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }
        }

        //private void FindTopStudent(StudentDb.GetMarksDelegateMethod getMethod)
        //{
        //    Student topStudent = db.GetTopStudent(getMethod);
        //    if(topStudent==null)
        //    {
        //        Console.WriteLine("No Students Found");
        //        return;
        //    }
        //    int mark = getMethod(topStudent);
        //    Console.WriteLine("Id:{0} Name:{1} Mark:{2}",topStudent.Id,topStudent.Name,mark);
        //}
        private void FindTopStudent(string subjectName)
        {
            Student topStudent = db.GetTopStudent(subjectName);
            if(topStudent==null)
            {
                Console.WriteLine("No Student Found");
                return;
            }
            Console.WriteLine("Top student is{0}",subjectName);
            int mark = 0;
            if(subjectName=="mark1")
            {
                mark = topStudent.Mark1;
            }
            else if(subjectName=="mark2")
            {
                mark = topStudent.Mark2;
            }
            else if(subjectName=="mark3")
            {
                mark = topStudent.Mark3;
            }
            Console.WriteLine("Id:{0},Name:{1},Mark:{2}",topStudent.Id,topStudent.Name,mark);
        }

        private void FindSortStudents()
        {
            Console.WriteLine("");
            Console.WriteLine("a.Sort Students By Id");
            Console.WriteLine("b.Sort Students By Name");
            Console.WriteLine("c.Sort Students By Mark1");
            Console.WriteLine("d.Sort Students By Mark2");
            Console.WriteLine("e.Sort Students By Mark3");
            Console.WriteLine("f.Sort Students By SchoolName");
            Console.WriteLine("G.Sort Students By District");
            ConsoleKeyInfo key = Console.ReadKey();
            switch(key.Key)
            {
                case ConsoleKey.A:
                    {
                        FindSortStudentsById();
                        break;
                    }
                case ConsoleKey.B:
                    {
                        FindSortStudentsByName();
                        break;
                    }
                
                case ConsoleKey.C:
                    {
                        FindSortStudentsByMark1();
                        break;
                    }
                case ConsoleKey.D:
                    {
                        FindSortStudentsByMark2();
                        break;
                    }
                case ConsoleKey.E:
                    {
                        FindSortStudentsByMark3();
                        break;
                    }
                case ConsoleKey.F:
                    {
                        FindSortStudentsBySchoolName();
                        break;
                    }
                case ConsoleKey.G:
                    {
                        FindSortStudentsByDistrict();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }
        }

        private void FindSortStudentsById()
        {
            PrintStudentInfoDelegate printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}", student.Id, student.Name);
            };
            var sortStudents = db.SortStudents((a, b) => a.Id > b.Id);
            string header = ("Id\tName");
            PrintStudentList(sortStudents, printStudent, header);                  
        }

        private void FindSortStudentsByName()
        {
            PrintStudentInfoDelegate printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}", student.Id, student.Name);
            };
            var sortStudents = db.SortStudents((a, b) => string.Compare(a.Name,b.Name)>0);
            string header = ("Id\tName");
            PrintStudentList(sortStudents, printStudent, header);
        }

        private void FindSortStudentsByMark1()
        {
            PrintStudentInfoDelegate printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}",student.Id, student.Name,student.Mark1);
            };
            var sortStudents = db.SortStudents((a, b) => a.Mark1>b.Mark1);
            string header = ("Id\tName\tMark1");
            PrintStudentList(sortStudents, printStudent, header);
        }

        private void FindSortStudentsByMark2()
        {
            PrintStudentInfoDelegate printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}", student.Id, student.Name, student.Mark2);
            };
            var sortStudents = db.SortStudents((a, b) => a.Mark2 > b.Mark2);
            string header = ("Id\tName\tMark2");
            PrintStudentList(sortStudents, printStudent, header);
        }

        private void FindSortStudentsByMark3()
        {
            PrintStudentInfoDelegate printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}", student.Id, student.Name, student.Mark3);
            };
            var sortStudents = db.SortStudents((a, b) => a.Mark3 > b.Mark3);
            string header = ("Id\tName\tMark3");
            PrintStudentList(sortStudents, printStudent, header);
        }

        private void FindSortStudentsBySchoolName()
        {
            PrintStudentInfoDelegate printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}", student.Id, student.Name,student.SchoolName);
            };
            var sortStudents = db.SortStudents((a, b) => string.Compare(a.SchoolName, b.SchoolName) > 0);
            string header = ("Id\tName\tSchoolname");
            PrintStudentList(sortStudents, printStudent, header);
        }

        private void FindSortStudentsByDistrict()
        {
            PrintStudentInfoDelegate printStudent = (Student student) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}", student.Id, student.Name,student.District);
            };
            var sortStudents = db.SortStudents((a, b) => string.Compare(a.District, b.District) > 0);
            string header = ("Id\tName\tDistrict");
            PrintStudentList(sortStudents, printStudent, header);
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
