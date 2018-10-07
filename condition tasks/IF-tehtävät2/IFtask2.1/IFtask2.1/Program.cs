using System;

namespace IFtask2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo lipun hinnan");
            int ticketPrice = 16;
            double discount = 0 ; //15% ale MTK
            int number = 0;

            Console.WriteLine("Oletko varusmies K tai E");
            string userInput = Console.ReadLine();

            if (userInput == "K")
                discount = 0.50;
            else
            {
                Console.WriteLine("Oletko opiskelija K tai E");
                userInput = Console.ReadLine();
                if (userInput == "K")
                {
                    Console.WriteLine("Oletko MTK jäsen K tai E");
                    userInput = Console.ReadLine();
                    if (userInput == "K")
                        discount = 0.60;
                    else
                        discount = 0.45;
                }
                else
                {
                    Console.WriteLine("Syötä ikä ");
                    string userInput1 = Console.ReadLine();
                    number = int.Parse(userInput1);

                    if (number < 7)
                        discount = 1;
                    else if (number <= 7 && number <= 15 || number >= 65)
                        discount = 0.5;
                    else
                    {
                        Console.WriteLine("Oletko MTK jäsen K tai E");
                        userInput = Console.ReadLine();

                        if (userInput == "K")
                            discount = 0.15;
                    }
                }

            }
            Console.WriteLine($"Lipun hinta on {ticketPrice - ticketPrice * discount}");




        }
    }
}
