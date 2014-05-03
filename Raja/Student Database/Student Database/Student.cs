using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Database
{
    class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Mark1 { get; private set; }
        public int Mark2 { get; private set; }
        public int Mark3 { get; private set; }
        public string SchoolName { get; private set; }
        public string District { get; private set; }

        public Student(int id, string name, int mark1, int mark2, int mark3, string schoolName, string district)
        {
            this.Id = id;
            this.Name = name;
            this.Mark1 = mark1;
            this.Mark2 = mark2;
            this.Mark3 = mark3;
            this.SchoolName = schoolName;
            this.District = district;
        }
    }
}
