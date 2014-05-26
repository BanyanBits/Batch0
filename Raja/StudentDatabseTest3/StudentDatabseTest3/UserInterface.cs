using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabseTest3
{
    class UserInterface
    {
        StudentDB db = new StudentDB();

        delegate void PrintstudentInfoDelegate(Student student);

        private void PrintStudentsList(List<Student> students, PrintstudentInfoDelegate printStudentMethod, string header)
        {
            if (!students.Any())
            {
                Console.WriteLine("No Students Found");
                return;
            }
            Console.WriteLine(header);
            Console.WriteLine();
            foreach (var student in students)
            {
                printStudentMethod(student);
            }
        }

        private void DisplayMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Student DataBase Application By Raja");
            Console.WriteLine("************************************");
            Console.WriteLine("Select the option Given Below");
            Console.WriteLine("a.Print Student Count");
            Console.WriteLine("b.Add New Student");
            Console.WriteLine("c.Add Test Students");
            Console.WriteLine("d.Delete Student");
            Console.WriteLine("e.Find Student With Highest Scores");
            Console.WriteLine("f.Print All Students List");
            Console.WriteLine("g.Find Students With Hundred Marks");
            Console.WriteLine("h.Find Students With Matching Marks");
            Console.WriteLine("i.Find Students By Name");
            Console.WriteLine("j.Find Students By SchoolName");
            Console.WriteLine("k.Find Student By District");
            Console.WriteLine("l.Find Top Student Each Subjects");
            Console.WriteLine("m.Sort Students");
            Console.WriteLine("q.Quit");
            Console.WriteLine("Enter the Option");
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
                        Add10TestStudents();
                        break;
                    }
                case ConsoleKey.D:
                    {
                        DeleteStudent();
                        break;
                    }
                case ConsoleKey.E:
                    {
                        FindStudentWithHighestScores();
                        break;
                    }
                case ConsoleKey.F:
                    {
                        PrintAllStudentsList();
                        break;
                    }
                case ConsoleKey.G:
                    {
                        FindStudentsWithHundredMark();
                        break;
                    }
                case ConsoleKey.H:
                    {
                        FindStudentsWithMatchingMark();
                        break;
                    }
                case ConsoleKey.I:
                    {
                        FindStudentsWithName();
                        break;
                    }
                case ConsoleKey.J:
                    {
                        FindStudentsWithSchoolName();
                        break;
                    }
                case ConsoleKey.K:
                    {
                        FindStudentsWithDistrict();
                        break;
                    }
                case ConsoleKey.L:
                    {
                        FindTopStudentEachSubjects();
                        break;
                    }
                case ConsoleKey.M:
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
            Console.WriteLine("Total Students Count in the Student Database:{0}", db.Count);
        }

        private void AddStudent()
        {
            Console.WriteLine("Enter Id");
            int id;
            string userInput = Console.ReadLine();
            if (!Int32.TryParse(userInput, out id))
            {
                Console.WriteLine("Invalid Id ,Please enter id positive Integer");
                return;
            }
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Mark1");
            int mark1 = 0;
            userInput = Console.ReadLine();
            if ((!Int32.TryParse(userInput, out id)) || mark1 < 0 || mark1 > 100)
            {
                Console.WriteLine("Invalid Mark1 ,Please enter Mark1 between Mark1>=0 && Mark1<=100");
                return;
            }
            Console.WriteLine("Enter Mark2");
            int mark2 = 0;
            userInput = Console.ReadLine();
            if ((!Int32.TryParse(userInput, out id)) || mark2 < 0 || mark2 > 100)
            {
                Console.WriteLine("Invalid Mark2 ,Please enter Mark2 between Mark2>=0 && Mark2<=100");
                return;
            }
            Console.WriteLine("Enter Mark3");
            int mark3 = 0;
            userInput = Console.ReadLine();
            if ((!Int32.TryParse(userInput, out id)) || mark3 < 0 || mark3 > 100)
            {
                Console.WriteLine("Invalid Mark3 ,Please enter Mark3 between Mark3>=0 && Mark3<=100");
                return;
            }
            Console.WriteLine("Enter SchoolName");
            string schoolName = Console.ReadLine();
            Console.WriteLine("Enter District");
            string district = Console.ReadLine();
            Student student = new Student(id, name, mark1, mark2, mark3, schoolName, district);
            db.AddStudent(student);
        }

        private void Add10TestStudents()
        {
            Random random = new Random();
            int addStudents = 10;
            int studentCount = db.Count;
            for (int i = 1; i <= addStudents; i++)
            {
                int studentId = studentCount + i;
                string name = "Student" + studentId.ToString();
                int mark1 = random.Next(56, 78);
                int mark2 = random.Next(79, 86);
                int mark3 = random.Next(90, 100);
                string schoolName = "SchoolName" + random.Next(10).ToString();
                string district = "District" + random.Next(20).ToString();
                Student student = new Student(id: studentId, name: name, mark1: mark1, mark2: mark2, mark3: mark3, schoolName: schoolName, district: district);
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
                Console.WriteLine("Invalid Id ,Please enter id positive Integer");
                return;
            }
            if (!db.IsStudentExist(id))
            {
                Console.WriteLine("Invalid Input:{0}", id);
                return;
            }
            db.DeleteStudent(id);
            Console.WriteLine("Delete Student with Id:{0}", id);
        }

        private void FindStudentWithHighestScores()
        {
            Student highestScore = db.FindStudentHighestScore();
            if (highestScore == null)
            {
                Console.WriteLine("No Students Found");
                return;
            }
            Console.WriteLine("Id:{0} Name:{1} Total:{2}", highestScore.Id, highestScore.Name, highestScore.Total);
        }

        private void PrintAllStudentsList()
        {
            PrintstudentInfoDelegate printMethods = (Student s) =>
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", s.Id, s.Name, s.Mark1, s.Mark2, s.Mark3, s.SchoolName, s.District);
                };
            List<Student> highestScore = db.GetAllStudentsList();
            string header = "Id\tName\tMark1\tMark2\tMark3\tSchoolName\tDistrict";
            PrintStudentsList(highestScore, printMethods, header);
        }

        private void FindStudentsWithHundredMark()
        {
            PrintstudentInfoDelegate printMethods = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", s.Id, s.Name, s.Mark1, s.Mark2, s.Mark3);
            };
            StudentDatabseTest3.StudentDB.IsMatch has100Marks = (Student s) =>
                {
                    return s.Mark1 == 100 || s.Mark2 == 100 || s.Mark3 == 100;
                };
            List<Student> highestScore = db.FindStudent(has100Marks);
            string header = "Id\tName\tMark1\tMark2\tMark3";
            PrintStudentsList(highestScore, printMethods, header);
        }

        private void FindStudentsWithMatchingMark()
        {
            Console.WriteLine("Enter Marks");
            int marks = 0;
            string userInput = Console.ReadLine();
            if ((!Int32.TryParse(userInput, out marks)) || marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid Marks ,Please enter Marks between Marks>=0 && Marks<=100");
                return;
            }
            PrintstudentInfoDelegate printMethods = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", s.Id, s.Name, s.Mark1, s.Mark2, s.Mark3);
            };
            StudentDatabseTest3.StudentDB.IsMatch isMarksMatch = (Student s) =>
            {
                return s.Mark1 == marks || s.Mark2 == marks || s.Mark3 == marks;
            };
            List<Student> highestScore = db.FindStudent(isMarksMatch);
            string header = "Id\tName\tMark1\tMark2\tMark3";
            PrintStudentsList(highestScore, printMethods, header);
        }

        private void FindStudentsWithName()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            PrintstudentInfoDelegate printMethods = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}", s.Id, s.Name);
            };
            StudentDatabseTest3.StudentDB.IsMatch isNameMatchs = (Student s) =>
            {
                return s.Name == name;
            };
            List<Student> highestScore = db.FindStudent(isNameMatchs);
            string header = "Id\tName";
            PrintStudentsList(highestScore, printMethods, header);
        }

        private void FindStudentsWithSchoolName()
        {
            Console.WriteLine("Enter SchoolName");
            string schoolName = Console.ReadLine();
            PrintstudentInfoDelegate printMethods = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.Id, s.Name, s.SchoolName);
            };
            StudentDatabseTest3.StudentDB.IsMatch isSchoolNameMatchs = (Student s) =>
            {
                return s.SchoolName == schoolName;
            };
            List<Student> highestScore = db.FindStudent(isSchoolNameMatchs);
            string header = "Id\tName\tSchoolName";
            PrintStudentsList(highestScore, printMethods, header);
        }

        private void FindStudentsWithDistrict()
        {
            Console.WriteLine("Enter District");
            string district = Console.ReadLine();
            PrintstudentInfoDelegate printMethods = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.Id, s.Name, s.District);
            };
            StudentDatabseTest3.StudentDB.IsMatch isDistrictMatchs = (Student s) =>
            {
                return s.District == district;
            };
            List<Student> highestScore = db.FindStudent(isDistrictMatchs);
            string header = "Id\tName\tSchoolName";
            PrintStudentsList(highestScore, printMethods, header);
        }

        private void FindTopStudentEachSubjects()
        {
            Console.WriteLine("");
            Console.WriteLine("a.Find Top Student Mark1");
            Console.WriteLine("b.Find Top Student mark2");
            Console.WriteLine("c.Find Top Student Mark3");
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.A:
                    {
                        StudentDatabseTest3.StudentDB.GetMarksDelegate getMarks = (Student s) =>
                            {
                                return s.Mark1;
                            };
                        FindTopStudentMark(getMarks, "mark1");
                        break;
                    }
                case ConsoleKey.B:
                    {
                        StudentDatabseTest3.StudentDB.GetMarksDelegate getMarks = (Student s) =>
                        {
                            return s.Mark2;
                        };
                        FindTopStudentMark(getMarks, "mark2");
                        break;
                    }
                case ConsoleKey.C:
                    {
                        StudentDatabseTest3.StudentDB.GetMarksDelegate getMarks = (Student s) =>
                        {
                            return s.Mark3;
                        };
                        FindTopStudentMark(getMarks, "mark3");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }
        }

        private void FindTopStudentMark(StudentDatabseTest3.StudentDB.GetMarksDelegate getMarks, string subjectName)
        {
            Student topStudent = db.TopStudentByMarks(getMarks);
            if (topStudent == null)
            {
                Console.WriteLine("No Students found");
                return;
            }
            Console.WriteLine("Top Student: {0}", subjectName);
            int marks = getMarks(topStudent);
            Console.WriteLine("Id:{0} Name:{1} Marks:{2}", topStudent.Id, topStudent.Name, marks);
        }

        private void FindSortStudents()
        {
            Console.WriteLine("");
            Console.WriteLine("a.Print Sort Students By Id");
            Console.WriteLine("b.Print Sort Students By Name");
            Console.WriteLine("c.Print Sort Students By Mark1");
            Console.WriteLine("d.Print Sort Students By Mark2");
            Console.WriteLine("e.Print Sort Students By Mark3");
            Console.WriteLine("f.Print Sort Students By SchoolName");
            Console.WriteLine("g.Print Sort Students By District");
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.A:
                    {
                        PrintSortStudentsById();
                        break;
                    }
                case ConsoleKey.B:
                    {
                        PrintSortStudentsByName();
                        break;
                    }
                case ConsoleKey.C:
                    {
                        PrintSortStudentsByMark1();
                        break;

                    }
                case ConsoleKey.D:
                    {
                        PrintSortStudentsByMark2();
                        break;
                    }
                case ConsoleKey.E:
                    {
                        PrintSortStudentsByMark3();
                        break;
                    }
                case ConsoleKey.F:
                    {
                        PrintSortStudentsBySchoolName();
                        break;
                    }
                case ConsoleKey.G:
                    {
                        PrintSortStudentsByDistrict();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }
        }

        public void PrintSortStudentsById()
        {
            PrintstudentInfoDelegate printMethods = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}", s.Id, s.Name);
            };
            var sortStudents = db.FindSortStudents((a, b) => a.Id > b.Id);
            string header = "Id\tName";
            PrintStudentsList(sortStudents, printMethods, header);
        }

        public void PrintSortStudentsByName()
        {
            PrintstudentInfoDelegate printMethods = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}", s.Id, s.Name);
            };
            var sortStudents = db.FindSortStudents((a, b) => string.Compare(a.Name, b.Name) > 0);
            string header = "Id\tName\tMark1\tMark2\tMark3\tSchoolName\tDistrict";
            PrintStudentsList(sortStudents, printMethods, header);
        }

        public void PrintSortStudentsByMark1()
        {
            PrintstudentInfoDelegate printMethods = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.Id, s.Name, s.Mark1);
            };
            var sortStudents = db.FindSortStudents((a, b) => a.Mark1 > b.Mark1);
            string header = "Id\tName\tMark1";
            PrintStudentsList(sortStudents, printMethods, header);
        }

        public void PrintSortStudentsByMark2()
        {
            PrintstudentInfoDelegate printMethods = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.Id, s.Name, s.Mark2);
            };
            var sortStudents = db.FindSortStudents((a, b) => a.Mark2 > b.Mark2);
            string header = "Id\tName\tMark2";
            PrintStudentsList(sortStudents, printMethods, header);
        }

        public void PrintSortStudentsByMark3()
        {
            PrintstudentInfoDelegate printMethods = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.Id, s.Name, s.Mark3);
            };
            var sortStudents = db.FindSortStudents((a, b) => a.Mark3 > b.Mark3);
            string header = "Id\tName\tMark3";
            PrintStudentsList(sortStudents, printMethods, header);
        }

        public void PrintSortStudentsBySchoolName()
        {
            PrintstudentInfoDelegate printMethods = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.Id, s.Name, s.SchoolName);
            };
            var sortStudents = db.FindSortStudents((a, b) => string.Compare(a.SchoolName, b.SchoolName) > 0);
            string header = "Id\tName\tSchoolName";
            PrintStudentsList(sortStudents, printMethods, header);
        }

        public void PrintSortStudentsByDistrict()
        {
            PrintstudentInfoDelegate printMethods = (Student s) =>
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.Id, s.Name, s.District);
            };
            var sortStudents = db.FindSortStudents((a, b) => string.Compare(a.District, b.District) > 0);
            string header = "Id\tName\tDistrict";
            PrintStudentsList(sortStudents, printMethods, header);
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
