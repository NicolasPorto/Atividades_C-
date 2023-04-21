using LearningException.Entities;
using LearningException.Entities.Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {

            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(number, checkin, checkout);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkout = DateTime.Parse(Console.ReadLine());

            reservation.updateDates(checkin, checkout);

            Console.WriteLine("Reservation: " + reservation);
        }
        catch(DomainException E)
        {

            Console.WriteLine("Error in reservation: " + E.Message);
        }
    }
}
