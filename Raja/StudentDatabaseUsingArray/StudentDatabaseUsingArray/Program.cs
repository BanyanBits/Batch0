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
            StudentDatabase db = new StudentDatabase(8);
            db.AddStudent(1, "Saran",99, 98, 99,"salem");
            db.AddStudent(2, "Rajan", 54, 79, 79,"Erode");
            db.AddStudent(3, "Balan",54, 60, 89,"Karur");
            db.AddStudent(4, "mania", 67, 80, 95,"Osur");
            db.AddStudent(5, "Raju", 76, 79, 98, "salem");
            db.AddStudent(6, "kalai", 58, 68, 60, "Erode");
            db.AddStudent(7, "kavi", 89, 60, 67, "Karur");
            db.AddStudent(8, "Balu", 67, 80, 95, "Osur");
           
            // Retrive Student Info
            db.PrintAllStudentInfo();           
            db.MaximumOfMark();
            db.MinimumOFMark();
            db.AverageStudentOfMark();           
            db.StudentOfResult();
            db.PrintStudentNameById();
            db.printStudentNameByDistrict();
            db.GradePriority();
            db.printStudentNameByMarks();
           


        }
    }
}
