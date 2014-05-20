using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public delegate int Transformer(int x);
    class util
    {
        public static void Tranform(int[] values,Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
		    values[i]=t(values[i]);
        }
    }
}
