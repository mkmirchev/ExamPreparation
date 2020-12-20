using System;

namespace Exam_01_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            // setting prices
            double roomPrice = 20.00;
            double transportPrice = 1.60;
            double ticketPrice = 6.00;

            // reading input
            int people = int.Parse(Console.ReadLine());
            int overNight = int.Parse(Console.ReadLine());
            int transportCards = int.Parse(Console.ReadLine());
            int ticketsNumber = int.Parse(Console.ReadLine());

            //Processing data
            double pricePerPerson = roomPrice * overNight + transportPrice * transportCards + ticketPrice * ticketsNumber;
            double priceForGroup = pricePerPerson * people;
            double totalTripPrice = priceForGroup * 1.25;

            //Generation console output
            Console.WriteLine("{0:F2}",totalTripPrice);
        }
    }
}
