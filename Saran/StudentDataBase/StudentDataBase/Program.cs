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
            db.AddStudent(1, "Saran","Ram", 54, 76, 98,78,65,"Salem");
            db.AddStudent(2, "Raja","Subra",90,73, 45, 79, 32,"Tirchy");
            db.AddStudent(3, "Raj","Raju",56,79, 87, 60, 45,"Chennai");
            db.AddStudent(4, "Ram","Saran",92,85, 43, 76, 98, "Salem");
            db.AddStudent(5, "Muthu","Raj",74,86, 90, 79, 32, "Tirchy");
            db.AddStudent(6, "Mani","Selva",91,80, 54, 60, 45, "Chennai");

            // Retrive Student Info

            //  db.PrintAllStudentInfo();
            //db.PrintStudentNameById();
           // db.StudentTotalMarkAndAverage();
           // db.MaxMarkOfStudent();
           // db.MinimumMarkOfStudent();
            
          //  db.PassOrFail();

            // db.FindStudentByMark();            
          // db.FindStudentByDistrict();
          //  db.FindStudentFirstMark();
            db.FindTopStudentGivenDistrict();
            //db.FindTopStudentEachDistrict();
           // db.FindOutHighestMarkOfEachDistrict();
            //db.FindStudentsGivenMarkRange();

            //  db.AddedTwoSubjectAndLastName();
        
        }

    }
}

