using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            ui.Run();
            Console.ReadLine();
        }
    }
}
