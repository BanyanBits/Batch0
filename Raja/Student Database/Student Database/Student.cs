using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Database
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark1 { get; set; }

        public Student(int id, string name, int mark1)
        {
            this.Id = id;
            this.Name = name;
            this.Mark1 = mark1;
        }
    }
}
