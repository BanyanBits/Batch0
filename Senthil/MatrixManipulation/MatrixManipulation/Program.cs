using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[3, 3]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            int[,] matrix2 = new int[3, 3]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            AddMatrix matrixAddition = new AddMatrix();
            int[,] total = matrixAddition.Add3By3(matrix1, matrix2);
            Print3By3Matrix(total);
        }

        static void Print3By3Matrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(matrix[i,j]);
                }
            }
        }
    }
}
