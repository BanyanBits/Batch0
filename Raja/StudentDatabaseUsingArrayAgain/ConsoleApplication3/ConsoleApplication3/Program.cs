using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 3,6,9 };
            util.Tranform(values, square);
            foreach (int i in values)
                Console.Write(i + "");
        }
        static int square(int x)
        {
            return x * x;
        }
    }
}
