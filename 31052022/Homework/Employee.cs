using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Employee:Human
    {
        public Employee(string name,string surname):base(name,surname)
        {

        }
        public double Salary;
        public string Position;

        public void ShowInfo()
        {
            Console.WriteLine($"FullName: {Name} {Surname} - Position: {Position} - Salary: {Salary}");
        }
    }
}
