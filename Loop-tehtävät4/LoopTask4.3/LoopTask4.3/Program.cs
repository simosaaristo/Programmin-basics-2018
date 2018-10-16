using System;

namespace LoopTask4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä 0-50.");
            Random rnd = new Random();
            int rndNumber;
            for (int r = 1; r <= 4; r++)
            {
                Console.WriteLine($"Rivi {r}:");
                for (int i = 0; i < 5; i++)
                {
                    rndNumber = rnd.Next(0, 51);
                    Console.Write($"{rndNumber}\t");

                }
                Console.WriteLine();
            }
        }
    }
}
