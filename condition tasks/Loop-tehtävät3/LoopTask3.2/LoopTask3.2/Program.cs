using System;

namespace LoopTask3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee ensimmäistä lukua yhteen.");
            int number = 0;
            int summa = 0;
            do
            {
                Console.WriteLine("Syötä luku: ");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);
                //number = int.Parse(Console.Readline());
                if (number <= 1)
                {
                    Console.WriteLine("Väärä syöte!");
                }

            }
            while (number <= 1);
            {
                for (int i = 1; i <= number; i++)
                {
                    summa += i;
                }
                Console.WriteLine($"Luvun {number} summa on {summa}");

            }
        }
    }
}
