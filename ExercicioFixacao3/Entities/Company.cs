using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao3.Entities
{
    internal class Company : TaxPayer
    {
        public int numberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            this.numberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double taxa = 0.0;

            if(numberOfEmployees <= 10)
            {
                taxa = (anualIncome * 0.16);
            }
            if(numberOfEmployees > 10)
            {
                taxa = (anualIncome * 0.14);
            }

            return taxa;
        }
    }
}
