using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao_6_9_10_11
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void increaseSalary(double percentage)
        {

            salary = salary + ((percentage / 100) * salary);

        }

        public override string ToString()
        {
            return "Update list of employees: " +
                id + ", " + name + ", " + salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
