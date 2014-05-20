using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public delegate void progressrepoter(int percentcomplete);
    class Class1
    {
        public static void hardwork(progressrepoter p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
