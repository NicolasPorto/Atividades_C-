using ExercicioFixacao.Entities.Enum;
using System.Text;
using System.Globalization;

namespace ExercicioFixacao.Entities
{
    internal class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }
        public Client cliente { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client cliente)
        {
            this.moment = moment;
            this.status = status;
            this.cliente = cliente;
        }

        public void AddItem(OrderItem item)
        {

            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {

            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;

            foreach(OrderItem item in Items)
            {

                sum += item.subTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + status);
            sb.AppendLine("Client: " + cliente);
            sb.AppendLine("Order items:");

            foreach(OrderItem item in Items)
            {

                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();

        }
    }
}
