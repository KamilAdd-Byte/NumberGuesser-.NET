using System;

namespace NumberGuesser
{

 
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Guesser";
            int appVersion = 1;
            string appAuthor = "Kamil";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"[{appName}] Wersja: 0.0.{appVersion}, Author: {appAuthor} ");

            Console.ResetColor();

            Console.WriteLine("Jam masz na imię?");
            string nameInput = Console.ReadLine();
        }
    }
}
