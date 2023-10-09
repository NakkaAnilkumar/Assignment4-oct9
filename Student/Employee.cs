using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EmployeeLibrary;

namespace EmployeeLibrary
{
    public class Employee : StudentLibrary.Student // Employee inherits from Student
    {
        public int EmpId { get; set; }
        public string EName { get; set; }
        public double Sal { get; set; }

        public Employee(int studId, string studName, int age, int empId, string eName, double sal)
            : base(studId, studName, age)
        {
            EmpId = empId;
            EName = eName;
            Sal = sal;
        }

        public new void Calculate() // Use "new" to hide the base class method
        {
            double hra, da, specialAllowance;

            if (Sal > 10000 && Sal < 20000)
            {
                hra = Sal * 0.10;
                da = Sal * 0.05;
                specialAllowance = Sal * 0.10;
            }
            else if (Sal > 20000 && Sal < 30000)
            {
                hra = Sal * 0.12;
                da = Sal * 0.07;
                specialAllowance = Sal * 0.12;
            }
            else
            {
                hra = 0;
                da = 0;
                specialAllowance = 0;
            }

            double totalSalary = Sal + hra + da + specialAllowance;
            Console.WriteLine($"Employee ID: {EmpId}, Employee Name: {EName}, Total Salary: {totalSalary:C}");
        }
    }
}
