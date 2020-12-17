using System;

namespace Filming
{
    class Program
    {
        static void Main(string[] args)
        {
            int filmingTime = int.Parse(Console.ReadLine());
            int scens = int.Parse(Console.ReadLine()); 
            int timePerScene = int.Parse(Console.ReadLine());
            double preparation = filmingTime * 0.15;
            double totalTime = scens * timePerScene + preparation;
            if (filmingTime >= totalTime)
            {
                Console.WriteLine("You managed to finish the movie on time! You have {0} minutes left!", Math.Ceiling(filmingTime-totalTime));
            }
            else
            {
                Console.WriteLine("Time is up! To complete the movie you need {0} minutes.", Math.Ceiling(totalTime - filmingTime));
            }
        }
    }
}
