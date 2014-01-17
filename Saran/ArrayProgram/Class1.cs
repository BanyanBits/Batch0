using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    class Class1
    {
        public static void Main(String[] args)
        {
            int[,] matrix1 = new int[3, 3]
            {
                {2,4,1},
                {3,6,2},
                {4,7,9},
           
            };

            int[,] matrix2 = new int[3, 3]
            {
                {2,4,1},
                {3,6,2},
                {4,7,9},
           
            };


            string[,] student = new string[3, 3]
            {
                {"1","saran","67"},
                {"2","raj","90"},
                {"3","ram","87"},

            };
    
            MatrixManipulation obj = new MatrixManipulation();
            obj.StudentNameDetails(student);
            obj.StudentDetails(student);
            obj.AdditionMatrix(matrix1, matrix2);
            obj.MultiplyMatrix(matrix1, matrix2);
            
             


        }
    }
}
