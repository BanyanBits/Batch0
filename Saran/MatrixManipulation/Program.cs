using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixManipulation
{
    class Program
    {
        public int[,] AdditionMatrix(int[,] matrix1, int[,] matrix2)
        {
            int i, j;
            int[,] result = new int[3, 3];
            for (i = 0; i < matrix1.Length; i++)
            {
                for (j = 0; j < matrix2.Length; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            } return result;


        }
    }
}
