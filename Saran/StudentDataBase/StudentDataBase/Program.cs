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
            StudentDatabaseFunction db = new StudentDatabaseFunction(4);
            db.AddStudent(1, "Saran", 99, 76, 98);
            db.AddStudent(2, "Raja", 54, 79, 32);
            db.AddStudent(3, "Raj", 54, 60, 75);

            // Retrive Student Info
            db.PrintAllStudentInfo();
            db.StudentTotalMarkAndAverage();
            db.MaxMarkOfStudent();
            db.MinimumMarkOfStudent();
            db.PrintStudentNameById();
            db.PassOrFail();
        }
    }
}

