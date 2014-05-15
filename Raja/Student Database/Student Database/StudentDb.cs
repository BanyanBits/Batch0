using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Database
{
    class StudentDb
    {
        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public Student FindStudentWithHighestScores()
        {
            Student highScoreStudents = null;
            int highScore = 0;
            foreach (var iStudent in students)
            {
                if (iStudent.Total > highScore)
                {
                    highScore = iStudent.Total;
                    highScoreStudents = iStudent;
                }
            }
            return highScoreStudents;
        }

        public bool IsStudentExsit(int id)
        {
            foreach (var iStudent in students)
            {
                if (iStudent.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public void DeleteStudents(int id)
        {
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    students.Remove(student);
                    return;
                }
            }
        }

        public List<Student> FindStudentsWithGivenMarks(int marks)
        {
            List<Student> studentWithGivenMarks = new List<Student>();
            foreach (var iStudent in students)
            {
                if (iStudent.Mark1 == marks || iStudent.Mark2 == marks || iStudent.Mark3 == marks)
                {
                    studentWithGivenMarks.Add(iStudent);
                }
            }
            return studentWithGivenMarks;
        }

        public List<Student> FindStudentsByName(String name)
        {
            List<Student> studentByName = new List<Student>();
            foreach (var iStudent in students)
            {
                if (iStudent.Name == name)
                {
                    studentByName.Add(iStudent);
                }
            }
            return studentByName;
        }

        public List<Student> FindStudentsByDistrict(String district)
        {
            List<Student> studentByDistrict = new List<Student>();
            foreach (var iStudent in students)
            {
                if (iStudent.District == district)
                {
                    studentByDistrict.Add(iStudent);
                }
            }
            return studentByDistrict;
        }

        public List<Student> FindStudentsBySchoolName(String schoolName)
        {
            List<Student> studentBySchoolName = new List<Student>();
            foreach (var iStudent in students)
            {
                if (iStudent.SchoolName == schoolName)
                {
                    studentBySchoolName.Add(iStudent);
                }
            }
            return studentBySchoolName;
        }

        public List<Student> PrintToalMarksInSorting()
        {
            List<Student> ascendingOrder = null;
            foreach (var iStudent in students)
            {
                ascendingOrder.Add(iStudent);
            }
            return ascendingOrder;
            //foreach (var iStudent in students)
            //{
            //    int student1InTotalMarks = iStudent.Total;
            //    int student2InTotalMarks = iStudent.Total;
            //    int student3InTotalMarks = iStudent.Total;
            //    int[] ascendingOrder = new int[] { student1InTotalMarks, student2InTotalMarks, student3InTotalMarks };
            //    Array.Sort(ascendingOrder);
            //    foreach (var totalMarks in ascendingOrder)
            //    {
            //        return totalMarks;
            //    }
            //}
        }
            
        public List<Student> GetAllStudentsList()
        {
            return students;
        }

        public int Count
        {
            get
            {
                return students.Count;
            }
        }
    }
}
