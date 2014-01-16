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
            int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] array1 = new int[,] { { -1, -2, -3 }, { -4,-5, -6 }, { -7, -8, -9 } };
            int[,] array2=new int[3,3];
            MatrixManipulation matrix = new MatrixManipulation();
            matrix.Addition(array);
            matrix.Addition1(array1);
            matrix.Addition2(array2);

            
        }
    }
}
