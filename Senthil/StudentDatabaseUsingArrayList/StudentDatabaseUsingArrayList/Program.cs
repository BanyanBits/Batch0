using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseUsingArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDb db = new StudentDb(10);
            db.AddStudent(1, "Raja", 99, 100, 95);
            db.AddStudent(2, "Saran", 91, 92, 93);
            db.AddStudent(3, "Rajini", 50, 51, 52);

            db.PrintAllStudentNames();

            db.PrintStudentsWithMatchingMark1(99);
        }
    }
}
