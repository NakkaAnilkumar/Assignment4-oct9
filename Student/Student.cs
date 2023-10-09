using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;


using EmployeeLibrary;

namespace StudentLibrary
{
    public class Student
    {
        public int StudId { get; set; }
        public string StudName { get; set; }
        public int Age { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int English { get; set; }

        public Student()
        {
        }

        public Student(int studId, string studName)
        {
            StudId = studId;
            StudName = studName;
        }

        // Constructor with 3 arguments
        public Student(int studId, string studName, int age)
        {
            StudId = studId;
            StudName = studName;
            Age = age;
        }

        public int Calculate()
        {
            return Maths + Science + English;
        }
    }
}