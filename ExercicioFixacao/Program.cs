using ExercicioFixacao.Entities;
using ExercicioFixacao.Entities.Enum;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter order data: ");
            Console.Write("Status (PendingPayment/Processing/Shapped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client cliente = new Client(name, email, birthDate);

            Order order = new Order(DateTime.Now, status, cliente);

            Console.WriteLine();
            Console.Write("How many items to this order? ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {

                Console.WriteLine("Enter #" + i + " item data:");

                Console.Write("Product name: ");
                string product = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());

                Product p1 = new Product(product, price);

                OrderItem item = new OrderItem(qtd, price, p1);

                order.AddItem(item);

            }

            Console.WriteLine();
            Console.WriteLine(order);

        }
    }
}