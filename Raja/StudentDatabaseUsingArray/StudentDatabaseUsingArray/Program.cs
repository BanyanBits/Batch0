using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseUsingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store Student Info
            StudentDatabase db = new StudentDatabase(4);
            db.AddStudent(1, "Saran",43, 76, 98);
            db.AddStudent(2, "Rajan", 54, 79, 32);
            db.AddStudent(3, "Balan",54, 60, 45);
            db.AddStudent(4, "mania", 67, 80, 95);
            // Retrive Student Info
            db.PrintAllStudentInfo();           
            db.MaximumOfMark();
            db.MinimumOFMark();
            db.AverageStudentOfMark();           
            db.StudentOfResult();
            db.PrintStudentNameById();
            db.GradesOfStudent();


        }
    }
}
