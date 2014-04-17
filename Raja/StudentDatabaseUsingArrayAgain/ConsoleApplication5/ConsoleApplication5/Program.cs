using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public delegate void progressrepoter(int percentcomplete);
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            progressrepoter p = c.InstanceProgress;
            p(99);
            Console.WriteLine(p.Target==c);
            Console.WriteLine(p.Method);
        }
    }
}
