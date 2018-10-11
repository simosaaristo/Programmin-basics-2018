using System;

namespace LoopTask3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa annetun luvun kertoman.");
            int number = 0;
            int i = 1;
            int fact = 1;
            do
            {
                Console.WriteLine("Syötä luku: ");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);
                //number = int.Parse(Console.Readline());
                if (number <= 0)
                {
                    Console.WriteLine("Väärä syöte!");
                }
            } while (number <= 0);

            while (i <= number)
            {
                fact = fact * i; //fact=*i
                i = i + 1;      //i++;
            }
            Console.WriteLine($"Luvun {number}! = {fact}");

        }
    }
}
