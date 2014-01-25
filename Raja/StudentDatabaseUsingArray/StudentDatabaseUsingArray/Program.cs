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
            StudentDatabase db = new StudentDatabase(32);
            db.AddStudent(1, "Saran", "Raj", 34, 65, 76, 67, 98, "salem");
            db.AddStudent(2, "Rajathi", "Raja", 2, 9, 8, 0, 3, "erode");
            db.AddStudent(3, "Balan", "murugan", 9, 5, 3, 23, 65, "karur");
            db.AddStudent(4, "mani", "Kandan", 63, 48, 31, 59, 78, "Osur");
            db.AddStudent(5, "Balan", "murugan", 23, 40, 93, 15, 19, "karur");
            db.AddStudent(6, "mani", "Kandan", 67, 80, 73, 89, 42, "Osur");
            db.AddStudent(7, "Saran", "Raj", 72, 54, 99, 67, 83, "salem");
            db.AddStudent(8, "Rajathi", "Raja", 12, 89, 78, 65, 40, "erode");

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
            db.HighestMarkOfStudent();
            db.Districtname();
            db.DisplayToMark1Only();
            db.TotalCountStudent();
            db.FindOutHighestMarkOfEachDistrict();



        }

    }
}

