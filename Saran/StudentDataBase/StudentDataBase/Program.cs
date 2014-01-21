using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store Student Info

            StudentDatabaseFunction db = new StudentDatabaseFunction(6);
            db.AddStudent(1, "Saran", 54, 76, 98,"Salem");
            db.AddStudent(2, "Raja", 45, 79, 32,"Thrchy");
            db.AddStudent(3, "Raj", 87, 60, 45,"Chennai");
            db.AddStudent(1, "Ram", 43, 76, 98, "Salem");
            db.AddStudent(2, "Muthu", 90, 79, 32, "Thrchy");
            db.AddStudent(3, "Mani", 54, 60, 45, "Chennai");

            // Retrive Student Info

            //db.PrintAllStudentInfo();
            //db.StudentTotalMarkAndAverage();
            //db.MaxMarkOfStudent();
            //db.MinimumMarkOfStudent();
            //db.PrintStudentNameById();
            //db.PassOrFail();
            db.FindStudentByMark();

        }
    }
}

