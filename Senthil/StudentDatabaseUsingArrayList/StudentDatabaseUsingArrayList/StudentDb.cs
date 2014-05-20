using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseUsingArrayList
{
    class StudentDb
    {
        Student[] students;
        int numberOfAddedStudents = 0;

        public StudentDb(int numberOfStudents)
        {
            students = new Student[numberOfStudents];
        }

        public void AddStudent(int id, string name, int mark1, int mark2, int mark3)
        {
            Student studentObject = new Student();
            studentObject.id = id;
            studentObject.name = name;
            studentObject.mark1 = mark1;
            studentObject.mark2 = mark2;
            studentObject.mark3 = mark3;

            students[numberOfAddedStudents] = studentObject;
            numberOfAddedStudents++;
        }

        public void PrintAllStudentNames()
        {
            Console.WriteLine("Student Names");
            Console.WriteLine("=============");
            for (int i = 0; i < numberOfAddedStudents; i++)
            {
                Console.WriteLine(students[i].name);
            }
        }



        public void PrintStudentsWithMatchingMark1(int inputMark)
        {
            Console.WriteLine("Students with Mark1={0}", inputMark);
            Console.WriteLine("===================================");

            for (int i = 0; i < numberOfAddedStudents; i++)
            {
                Student currentStudent = students[i];
                if (currentStudent.mark1 == inputMark)
                {
                    Console.WriteLine(currentStudent.name);
                }
            }
        }
    }
}
