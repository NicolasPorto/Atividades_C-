using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double additionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {

            this.additionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * additionalCharge;
        }

    }
}
