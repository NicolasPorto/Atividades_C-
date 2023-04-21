using ExercicioFixacao3.Entities;
using System.Globalization;

namespace ExercicioFixacao3
{
    class Program
    {
        public static void Main(String[] args)
        {

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                Console.Write("Tax payer #" + i + " data: ");

                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, income, health));
                }
                if(ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int emp = int.Parse(Console.ReadLine());
                    
                    list.Add(new Company(name, income, emp));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            foreach (TaxPayer Payer in list)
            {
                Console.WriteLine(Payer.Name
                    + ": $ "
                    + Payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }

            double sum = 0.0;

            foreach (TaxPayer Payer in list)
            {
                sum += Payer.Tax();
            }

            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}