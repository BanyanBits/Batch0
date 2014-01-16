using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MatrixManipulation
    {
        public int[,] Addition(int[,] Matrix)
        {
           foreach(int i in Matrix)
           {
               Console.WriteLine(i);
           }
           return Matrix;
        }

        public int[,] Addition1(int[,] Matrix1)
        {
            foreach (int i in Matrix1)
            {
                Console.WriteLine(i);
            }
            return Matrix1;
        }

        public int[,] Addition2(int[,] Add)
        {
            foreach (int i in Add)
            {
                Console.WriteLine(i);
            }
            return Add;
        }
    }
}