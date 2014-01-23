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
            db.AddStudent(1, "Saran", "Raj", 99, 98, 99, 67, 98, "salem");            
            db.AddStudent(2, "Rajathi", "Raja", 99, 89, 78, 69, 99, "erode");
            db.AddStudent(3, "Balan", "murugan", 99, 99, 99, 99, 99, "salem");
            db.AddStudent(4, "mani", "Kandan", 67, 80, 95, 89, 78, "Osur");

            db.AddStudent(5, "Ram", "Saran", 99, 98, 99, 67, 98, "salem");
            db.AddStudent(6, "Selva", "Mani", 99, 89, 78, 69, 99, "erode");
            db.AddStudent(7, "Siva", "Raman", 99, 99, 99, 99, 99, "Karur");
            db.AddStudent(8, "Subra", "Mani", 67, 80, 95, 89, 78, "Osur");
            db.AddStudent(1, "Saran", "Raj", 99, 98, 99, 67, 98, "kumari");
            db.AddStudent(2, "Rajathi", "Raja", 99, 89, 78, 69, 99, "erode");
            db.AddStudent(3, "Balan", "murugan", 99, 99, 99, 99, 99, "Karur");
            db.AddStudent(4, "mani", "Kandan", 67, 80, 95, 89, 78, "Osur");

            db.AddStudent(5, "Ram", "Saran", 99, 98, 99, 67, 98, "puri");
            db.AddStudent(6, "Selva", "Mani", 99, 89, 78, 69, 99, "erode");
            db.AddStudent(7, "Siva", "Raman", 99, 99, 99, 99, 99, "salem");
            db.AddStudent(8, "Subra", "Mani", 67, 80, 95, 89, 78, "salem");
            db.AddStudent(1, "Saran", "Raj", 99, 98, 99, 67, 98, "salem");
            db.AddStudent(2, "Rajathi", "Raja", 99, 89, 78, 69, 99, "erode");
            db.AddStudent(3, "Balan", "murugan", 99, 99, 99, 99, 99, "salem");
            db.AddStudent(4, "mani", "Kandan", 67, 80, 95, 89, 78, "Osur");

            db.AddStudent(5, "Ram", "Saran", 99, 98, 99, 67, 98, "salem");
            db.AddStudent(6, "Selva", "Mani", 99, 89, 78, 69, 99, "erode");
            db.AddStudent(7, "Siva", "Raman", 99, 99, 99, 99, 99, "Karur");
            db.AddStudent(8, "Subra", "Mani", 67, 80, 95, 89, 78, "Osur");
            db.AddStudent(1, "Saran", "Raj", 99, 98, 99, 67, 98, "kumari");
            db.AddStudent(2, "Rajathi", "Raja", 99, 89, 78, 69, 99, "erode");
            db.AddStudent(3, "Balan", "murugan", 99, 99, 99, 99, 99, "Karur");
            db.AddStudent(4, "mani", "Kandan", 67, 80, 95, 89, 78, "Osur");

            db.AddStudent(5, "Ram", "Saran", 99, 98, 99, 67, 98, "puri");
            db.AddStudent(6, "Selva", "Mani", 99, 89, 78, 69, 99, "erode");
            db.AddStudent(7, "Siva", "Raman", 99, 99, 99, 99, 99, "salem");
            db.AddStudent(8, "Subra", "Mani", 67, 80, 95, 89, 78, "salem");

           // db.AddStudent(8, "Subra", "Mani", 67, 80, 95, 89, 78, "salem");
            
            // Retrive Student Info
            //db.PrintAllStudentInfo();
            //db.MaximumOfMark();
            //db.MinimumOFMark();
            //db.AverageStudentOfMark();
            //db.StudentOfResult();
            //db.PrintStudentNameById();
            //db.printStudentNameByDistrict();
            //db.GradePriority();
            //db.printStudentNameByMarks();

            //db.HighestMarkOfStudent();
            //db.TotalNoOfStudentCount();
            //db.FindOutHighestMarkOfEachDistrict();
            //db.FindOutHighestMarkOfEachSubject();
            //db.Districtname();            
            //db.DisplayToMark1Only();
            //db.TotalCountStudent();
            db.NumberOfDistrict();


        }

    }
}

