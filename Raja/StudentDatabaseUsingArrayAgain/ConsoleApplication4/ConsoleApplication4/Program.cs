using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            progressrepoter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            Class1.hardwork(p);
        }
        static void WriteProgressToConsole(int percentcomplete)
        {
            Console.WriteLine(percentcomplete);
        }
        static void WriteProgressToFile(int percentcomplete)
        {
            System.IO.File.WriteAllText("progress.txt", percentcomplete.ToString());
        }
    }
}
