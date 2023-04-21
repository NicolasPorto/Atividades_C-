using System.Collections.Generic;
using Course.Exercicio1.Entities.Enum;

namespace Course.Exercicio1.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double baseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            this.baseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {

            Contracts.Add(contract);

        }

        public void RemoveContract(HourContract contract)
        {

            Contracts.Remove(contract);

        }

        public double Income(int year, int month)
        {

            double sum = baseSalary;

            foreach(HourContract contract in Contracts)
            {
                if(contract.date.Year == year && contract.date.Month == month)
                {
                    sum += contract.totalValue();

                }

            }

            return sum;
        }
    }
}
