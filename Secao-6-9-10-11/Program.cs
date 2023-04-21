using Secao_6_9_10_11;
using System;
using System.Globalization;

namespace Course
{
    internal class program
    {
        /*static void Main(string[] args)
        {

            Console.WriteLine("Quantos usuários serão cadastrado?");
            int N = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < N; i++)
            {

                Console.Write("ID:");
                int ID = int.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Salary:");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(ID, name, salario));

            }


            Employee obj = null;

            while (obj == null)
            {

                Console.WriteLine("Digite o ID do empregado que deverá ter aumento:");
                int id_Found = int.Parse(Console.ReadLine());
                obj = list.Find(x => x.id == id_Found);

                if (obj != null)
                {

                    Console.WriteLine("Digite a porcentagem:");
                    double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    obj.increaseSalary(porcentagem);

                }
                else
                {

                    Console.WriteLine("Não existe esse ID!");

                }

            }

            Console.WriteLine("Dados atualizados: ");

            foreach (Employee dados in list)
            {
                Console.WriteLine(dados);

            }
        }*/
    }
}


        /*int N = int.Parse(Console.ReadLine());

        Produto[] vect = new Produto[N];

        for (int i = 0; i < N; i++)
        {

            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            vect[i] = new Produto { Name = name, Price = price };

        }

        double sum = 0;

        for (int i = 0; i < N; i++)
        {

            sum += vect[i].Price;

        }

        double avg = sum / N;

        Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));*/