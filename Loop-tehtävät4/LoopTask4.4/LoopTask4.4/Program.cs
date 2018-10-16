using System;

namespace LoopTask4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi rahan heittoa.");
            Console.Write("Kuinka monta kertaa kolikkoa heitetään? ");
            int counter = int.Parse(Console.ReadLine());
            int heads = 0;
            int tails = 0;
            Random rnd = new Random();

            for (int i = 0; i < counter; i++)
            {
                int rndNumber = rnd.Next(2);
                if (rndNumber == 0)
                    tails++;
                else
                    heads++;
            }
            Console.WriteLine($"Rahaa on heitetty {counter} kertaa");
            Console.WriteLine($"Klaavoja tuli {tails} ja kruunuja {heads}.");
        }   

    }
}
