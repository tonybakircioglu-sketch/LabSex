using System;
using System.Collections.Generic;
using System.Text;

namespace LabSex
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public Employee(int id, int salary, string name, string gender)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }
}
