using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacao3.Entities
{
    internal class Individual : TaxPayer
    {
        public double healthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            this.healthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double taxa = 0.0;

            if(anualIncome < 20000.00)
            {
                taxa = (anualIncome * 0.15) - (healthExpenditures * 0.5);
            }
            if(anualIncome >= 20000.00)
            {
                taxa = (anualIncome * 0.25) - (healthExpenditures * 0.5);
            }

            return taxa;
        }
    }
}
