using System;

namespace EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string startingDate = Console.ReadLine();
            int duration = int.Parse(Console.ReadLine());
            int pricePerDay = 0;
            if (destination == "France")
            {
                if (startingDate == "21-23")
                {
                    pricePerDay = 30;
                }
                else if (startingDate == "24-27")
                {
                    pricePerDay = 35;
                }
                else if (startingDate == "28-31")
                {
                    pricePerDay = 40;
                }
            }
            else if (destination == "Italy")
            {
                if (startingDate == "21-23")
                {
                    pricePerDay = 28;
                }
                else if (startingDate == "24-27")
                {
                    pricePerDay = 32;
                }
                else if (startingDate == "28-31")
                {
                    pricePerDay = 39;
                }
            }
            else if (destination == "Germany")
            {
                if (startingDate == "21-23")
                {
                    pricePerDay = 32;
                }
                else if (startingDate == "24-27")
                {
                    pricePerDay = 37;
                }
                else if (startingDate == "28-31")
                {
                    pricePerDay = 43;
                }
            }
            Console.WriteLine("Easter trip to {0} : {1:F2} leva.",destination, pricePerDay*duration);
        }
    }
}
