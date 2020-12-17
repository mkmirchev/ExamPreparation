using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            double shoes = input * 0.6;
            double sportsWear = shoes * 0.8;
            double ball = sportsWear * 0.25;
            double accessories = ball * 0.2;
            double total = input + shoes + sportsWear + ball + accessories;
            Console.WriteLine("{0:F2}",total);
        }
    }
}
