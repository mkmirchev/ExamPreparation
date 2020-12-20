using System;

namespace Exam_04_GrandfatherStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            // gathering input data
            int days = int.Parse(Console.ReadLine());
            double volumeOfRakia = 0;
            double rakiaDegrees = 0;
            double totalVolume = 0;
            double totalDegrees = 0;

            // collecting data for baked rakia per day
            for (int i = 1; i <= days; i++)
            {
                volumeOfRakia = double.Parse(Console.ReadLine());
                rakiaDegrees = double.Parse(Console.ReadLine());
                totalVolume += volumeOfRakia;
                totalDegrees += (volumeOfRakia * rakiaDegrees);
            }
            totalDegrees /= totalVolume;
            // generating output
            Console.WriteLine("Liter: {0:F2}",totalVolume);
            Console.WriteLine("Degrees: {0:F2}",(totalDegrees));
            if (totalDegrees <38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (totalDegrees >= 38 && totalDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
