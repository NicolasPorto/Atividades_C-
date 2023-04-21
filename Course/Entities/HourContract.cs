
namespace Course.Exercicio1.Entities
{
    internal class HourContract
    {
        public DateTime date { get; set; }
        public double valuePerHour { get; set; }
        public int hours { get; set; }

        public HourContract()
        {
        }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.date = date;
            this.valuePerHour = valuePerHour;
            this.hours = hours;
        }

        public double totalValue()
        {

            return valuePerHour * hours;

        }
    }
}
