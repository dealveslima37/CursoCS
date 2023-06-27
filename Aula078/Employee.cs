﻿using System.Globalization;

namespace Aula078
{
    internal class Employee
    {

        private static readonly CultureInfo locale = CultureInfo.InvariantCulture;

        public int Id { get; private set; }
        public string? Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string? name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary = Salary + (Salary * percentage / 100.0);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, R$ {Salary.ToString("F2", locale)}";
        }

    }
}
