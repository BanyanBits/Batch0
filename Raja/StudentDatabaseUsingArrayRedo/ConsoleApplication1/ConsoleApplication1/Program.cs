using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDatabase db = new StudentDatabase(12);
            db.AddStudent(1, "Raja", "saran", 34, 67, 89, 56, 45, "salem");
            db.AddStudent(2, "mu", "saran", 34, 67, 8, 22, 45, "karur");
            db.AddStudent(3, "Raja", "sin", 34, 11, 9, 56, 45, "erode");
            db.AddStudent(4, "Raja", "raj", 10, 67, 89, 56, 45, "trichy");
            db.AddStudent(5, "Raja", "saran", 34, 100, 89, 56, 45, "salem");
            //db.PrintAllStudentInfo();
            //db.studentNameById();
            //db.studentNameByDistrict();
            //db.studentOfResult();
            //db.averageStudentOfMark();
            db.printTopStudentInfo();
            //db.PrintStudentInfoByMark();
            //db.FindStudentGivenMarkRange();
            //db.FindTopStudentGivenDistrict();
            //db.MaximumMarkOfStudent();
            //db.MinimumMarkOfStudent();
            //db.FindOutHighestMarkOfEachDistrict();
                       
        }
    }
}
