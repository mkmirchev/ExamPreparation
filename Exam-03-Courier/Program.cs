using System;

namespace Exam_03_Courier
{
    class Program
    {
        static void Main(string[] args)
        {

            //gathering input data
            double shippingWeight = double.Parse(Console.ReadLine());
            string shippingType = Console.ReadLine();
            int shippingLenght = int.Parse(Console.ReadLine());

            //processing data
            double pricePerKm = 0;
            double additionalCost = 0;
            if (shippingWeight < 1)
            {
                pricePerKm = 0.03;
            }
            else if (shippingWeight >=1 && shippingWeight < 10)
            {
                pricePerKm = 0.05;
            }
            else if (shippingWeight >= 10 && shippingWeight < 40)
            {
                pricePerKm = 0.10;
            }
            else if (shippingWeight >= 40 && shippingWeight < 90)
            {
                pricePerKm = 0.15;
            }
            else if (shippingWeight >= 90 && shippingWeight <= 150)
            {
                pricePerKm = 0.20;
            }
            if (shippingType == "express")
            {
                if (shippingWeight < 1)
                {
                    additionalCost = 0.03 * 0.8 * shippingWeight * shippingLenght;
                }
                else if (shippingWeight >= 1 && shippingWeight < 10)
                {
                    additionalCost = 0.05 * 0.4 * shippingWeight * shippingLenght;
                }
                else if (shippingWeight >= 10 && shippingWeight < 40)
                {
                    additionalCost = 0.1 * 0.05 * shippingWeight * shippingLenght;
                }
                else if (shippingWeight >= 40 && shippingWeight < 90)
                {
                    additionalCost = 0.15 * 0.02 * shippingWeight * shippingLenght;
                }
                else if (shippingWeight >= 90 && shippingWeight <= 150)
                {
                    additionalCost = 0.2 * 0.01 * shippingWeight * shippingLenght;
                }
            }
                double shippingPrice = pricePerKm * shippingLenght * 1.0 + additionalCost;
          
            //Generating output
            Console.WriteLine("The delivery of your shipment with weight of {0:F3} kg. would cost {1:F2} lv.", shippingWeight , shippingPrice);
        }
    }
}
