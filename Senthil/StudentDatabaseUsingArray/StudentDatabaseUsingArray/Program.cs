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
            StudentDatabase db = new StudentDatabase(5);
            db.AddStudent("1", "Noah", 90, 92, 90);
            db.AddStudent("2", "Saran", 90, 90, 90);
            db.PrintInfo("7");

            //Find all students matching Mark1
            //Find all students matching total mark
            //Print each students max mark
            //Print each students min mark
            //Student with highest total, First rank student

            string m1 = "59";
            string m2 = "-99";

            int integerM1 = Convert.ToInt32(m1);
            int integerM2 = Convert.ToInt32(m2);

            //if(m1 > m2) Error

            if (integerM1 > integerM2)
            {

            }

            
        }
    }
}
