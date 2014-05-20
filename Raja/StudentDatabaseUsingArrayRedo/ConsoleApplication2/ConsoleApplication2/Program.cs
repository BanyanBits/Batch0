using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    delegate int Transformer(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Transformer t = square;
            int result = t(3);
            Console.WriteLine(result);
        }
        static int square(int x)
        {
            return x * x;
        }
    }
}


            


     
