using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixManipulation
{
    class MainClass
    {
        public static void main(string[] args)
        {
			//Adding test command.
            int[,] matrix1 = new int[3, 3]
            {
                {3,5,6},
                {2,5,7},
                {1,7,9},
            };
            int[,] matrix2 = new int[3, 3]
            {
                {3,5,6},
                {2,5,7},
                {1,7,9},
            };
            Program obj = new Program();
            int[,] result = obj.AdditionMatrix(matrix1, matrix2);
            Console.WriteLine(result);
        }
    }
}
