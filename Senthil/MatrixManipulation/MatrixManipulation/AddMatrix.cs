using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixManipulation
{
    class AddMatrix
    {
        public int[,] Add3By3(int[,] matrix1, int[,] matrix2)
        {            
            int[,] total = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    total[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return total;

        }
    }
}
