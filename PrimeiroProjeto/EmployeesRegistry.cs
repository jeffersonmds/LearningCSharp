using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class EmployeesRegistry
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public void IncreaseSalary(double percentage) {
            Salary += Salary * (percentage / 100);
        }

        public EmployeesRegistry(string id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
