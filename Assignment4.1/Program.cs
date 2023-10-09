using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;
using EmployeeLibrary;


namespace Assignment4._1
{
    class Program
    {
        static void Main()
        {
            // Create a Student object from the StudentLibrary
            Student student = new Student(1, "John", 20);
            student.Maths = 90;
            student.Science = 85;
            student.English = 92;

            // Calculate and display total marks for the student
            int totalMarks = student.Calculate();
            Console.WriteLine($"Student ID: {student.StudId}, Student Name: {student.StudName}, Total Marks: {totalMarks}");

            // Create an Employee object from the EmployeeLibrary
            Employee employee = new Employee(1, "Alice", 25, 101, "Employee1", 15000);

            // Calculate and display salary for the employee
            employee.Calculate();

            Console.ReadLine();
        }
    }
}
