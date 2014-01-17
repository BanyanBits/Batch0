using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatrix
{
    class MatrixManipulation
    {
        public void AdditionMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write(result[i, j]);
                }
                Console.WriteLine();
            } Console.WriteLine("\n");
        }


        public void MultiplyMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(result[i, j] = matrix1[i, j] * matrix2[i, j]);

                }
                Console.WriteLine();
            } Console.WriteLine("\n");
        }


        public void StudentDetails(string[,] student)
        {

            Console.Write("Enter the Student Number   : ");

            string name = Console.ReadLine();

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                if (i == n)
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine(student[i, j]);
                    }
                Console.WriteLine();
            }

        }


        public void StudentNameDetails(string[,] student)
        {
            string name = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    if (string.Equals(student[i, j], name))
                    {

                        Console.WriteLine(student[i, j]);

                    }
            }
        }


        public void AddMultiplicationJaggedArray(int[][] jaggedarray1, int[][] jaggedarray2)
        {
            int[][] result = new int[3][];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    result[i][j] = jaggedarray1[i][j] + jaggedarray2[i][j];
                    Console.WriteLine(result[i][j]);                   


                }




        }



    }
}
