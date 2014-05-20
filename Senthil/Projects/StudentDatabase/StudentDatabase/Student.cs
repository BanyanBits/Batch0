using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int  Mark1 { get; private set; }

        public Student(int id, string name, int mark1)
        {
            this.Id = id;
            this.Name = name;
            this.Mark1 = mark1;
        }
    }
}
