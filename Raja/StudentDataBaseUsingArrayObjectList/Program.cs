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
            StudentDb db= new StudentDb(10);
            db.AddStudent(1, "raja", 19, 67, 99, 67, 89, "salem");
            db.AddStudent(2, "raju", 67, 67, 40, 56, 77, "erode");
            db.AddStudent(3, "ramu", 69, 36, 78, 90, 67, "karur");
            db.AddStudent(4, "rani", 99, 67, 89, 56, 78, "salem");
            db.AddStudent(5, "rama", 89, 67, 90, 89, 78, "erode");
            //db.PrintAllStudentNames();
            //db.PrintAllStudentMark1();
            //db.PrintStudentWithMatchingMark1(99);
            //db.PrintStudentWithMatchingMark2AndMark3(99, 99);
            //db.AverageStudentMark();
            //db.StudentOfResult();
            //db.FindStudentGivenMarkRange();
            //db.MaximumMarkOfStudent();
            //db.MinimumMarkOfStudent();
            //db.PrintStudentInfoByMark(77);
            //db.PrintGradeForEachSubject();
            //db.PrintOfTopStudent();
            db.FindTopStudentGivenDistrict("salem");
        }
    }
}
