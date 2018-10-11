using System;

namespace LoopTask3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee ensimmäisen numeron parittoman ja parillisen luvun summan.");
            int number = 0;
            int evenSum = 0;
            int oddSum = 0;
            do
            {
                Console.WriteLine("Syötä luku: ");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);
                //number = int.Parse(Console.Readline());
                if (number < 1)
                    Console.WriteLine("Väärä syöte!");

            }
            while (number < 1);

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
            }
            Console.WriteLine($"Luvun {number} parittomien summa on {oddSum}");
            Console.Write($"Luvun {number} parillisten summa on {evenSum}");


        }
    }
}
