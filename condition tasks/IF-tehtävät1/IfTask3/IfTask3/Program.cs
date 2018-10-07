using System;

namespace IfTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku parillinen vai pariton ja negatiivinen, positiivinen vai nolla.");
            Console.Write("Syötä numero ");
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number);
            if (isNumber)
            {
                if (number == 0)
                    Console.WriteLine($"Numero {number} on nolla");
                else if (number < 0)
                    Console.WriteLine($"Numero {number} on negatiivinen");
                else
                    Console.WriteLine($"Numero {number} on positiivinen");
                if (number % 2 == 0)
                    Console.WriteLine($"Ja {number} on parillinen.");
                else
                    Console.WriteLine($"Ja {number} on pariton.");
            }
            else
                Console.WriteLine("Väärä syöte!");


        }
    }

}
