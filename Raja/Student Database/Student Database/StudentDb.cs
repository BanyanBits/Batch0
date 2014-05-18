﻿using System;
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

        public Student PrintTopStudentInMark3()
        {
            Student topStudentOfMark3 = null;
            int temp = 0;
            foreach (var iStudent in students)
                if (iStudent.Mark3 > temp)
                {
                    temp = iStudent.Mark3;
                    topStudentOfMark3 = iStudent;
                }
            return topStudentOfMark3;
        }

        public Student PrintTopStudentInMark1()
        {
            Student topStudentOfMark1 = null;
            int temp = 0;
            foreach (var iStudent in students)
                if (iStudent.Mark1 > temp)
                {
                    temp = iStudent.Mark1;
                    topStudentOfMark1 = iStudent;
                }
            return topStudentOfMark1;
        }

        public Student PrintTopStudentInMark2()
        {
            Student topStudentOfMark2 = null;
            int temp = 0;
            foreach (var iStudent in students)
            {
                if (iStudent.Mark2 > temp)
                {
                    temp = iStudent.Mark2;
                    topStudentOfMark2 = iStudent;
                }
            }
            return topStudentOfMark2;
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
