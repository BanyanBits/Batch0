using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatrix
{
    class Program
    {
        static void Main(string[] args)
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

            int[][] jaggedarray1 = new int[3][]
            {
            
              new int[]{2,3,5},
              new int[]{4,7},
              new int[]{6,7,2,9},
            };

            int[][] jaggedarray2 = new int[3][]
            {
            
                new int[]{6,1,8},
                new int[]{3,7},
                new int[]{5,2,2,0},
            };


            MatrixManipulation obj = new MatrixManipulation();

            obj.AddMultiplicationJaggedArray(jaggedarray1, jaggedarray2);
            obj.StudentNameDetails(student);
            obj.StudentDetails(student);
            obj.AdditionMatrix(matrix1, matrix2);
            obj.MultiplyMatrix(matrix1, matrix2);
            
             



        }
    }
}
