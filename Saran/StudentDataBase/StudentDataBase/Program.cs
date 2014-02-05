using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBase
{
    class Program
    {
        static StudentDatabaseFunction db = new StudentDatabaseFunction(6);

        static void Main(string[] args)
        {

            // Store Student Info

            AddStudentsInfo();

            // Retrive Student Info

            //DisplayAllStudent();
            //FindStudentById();
            //FindStudentsWithMatchingMark();
            //StudentTotalMarkAndAverage();
            //MaxMarkOfStudent();
            //MinimumMarkOfStudent();
            //PassOrFail();
            //FindStudentByDistrict();
            //FindStudentFirstMark();
            //FindTopStudentGivenDistrict();
            //FindOutHighestMarkOfEachDistrict();
            FindStudentsGivenMarkRange();


        }



        static void AddStudentsInfo()
        {
            db.AddStudent(1, "Saran", "Ram", 54, 76, 98, 78, 65, "Salem");
            db.AddStudent(2, "Raja", "Subra", 90, 73, 45, 79, 32, "Tirchy");
            db.AddStudent(3, "Raj", "Raju", 56, 79, 87, 60, 45, "Chennai");
            db.AddStudent(4, "Ram", "Saran", 92, 85, 43, 76, 98, "Salem");
            db.AddStudent(5, "Muthu", "Raj", 74, 86, 90, 79, 32, "Tirchy");
            db.AddStudent(6, "Mani", "Selva", 91, 80, 54, 60, 45, "Chennai");
        }

        static void DisplayAllStudent()
        {
            db.PrintAllStudentInfo();
        }


        static void FindStudentById()
        {
            String studentId;
            Console.Write("\n Enter the Student Id : ");
            studentId = (Console.ReadLine());
            db.PrintStudentNameById(studentId);
        }

        static void FindStudentsWithMatchingMark()
        {
            Console.Write("\n\n Enter mark  :  ");
            string mark = Console.ReadLine();
            db.FindStudentByMark(mark);
        }


        static void StudentTotalMarkAndAverage()
        {
            db.StudentTotalMarkAndAverage();
        }


        static void MaxMarkOfStudent()
        {
            db.MaxMarkOfStudent();
        }

        static void MinimumMarkOfStudent()
        {
            db.MinimumMarkOfStudent();
        }


        static void PassOrFail()
        {
            db.PassOrFail();
        }


        static void FindStudentByDistrict()
        {
            Console.Write("Enter the Student District : ");
            string district = Console.ReadLine();
            db.FindStudentByDistrict(district);
        }

        static void FindStudentFirstMark()
        {
            db.FindStudentFirstMark();
        }


        static void FindTopStudentGivenDistrict()
        {
            Console.Write("Enter the District : ");
            string district = Console.ReadLine();

            db.FindTopStudentGivenDistrict(district);
        }
        
        
    
        static void FindOutHighestMarkOfEachDistrict()
        {
            db.FindOutHighestMarkOfEachDistrict();
        }



        static void FindStudentsGivenMarkRange()
        {
            db.FindStudentsGivenMarkRange();
        }

    }
}

