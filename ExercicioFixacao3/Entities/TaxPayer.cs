using System;
using System.Globalization;

namespace ExercicioFixacao3.Entities
{
    abstract internal class TaxPayer
    {
        public string Name { get; set; }
        public double anualIncome { get; set; }

        public TaxPayer()
        {
        }
        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            this.anualIncome = anualIncome;
        }

        abstract public double Tax();
    }
}
