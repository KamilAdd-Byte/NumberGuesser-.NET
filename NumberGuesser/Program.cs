using System;

namespace NumberGuesser
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Wywołanie metody w c#
             */

            GetAppInfo();

            /*
             *  Dane od użytkownika. Przypisanie zmiennej do wyniku działania metody.
             */
            string nameInput =  GetUserName();

            GreetUser(nameInput);
         
        }

        static void GetAppInfo()
        {
            string appName = "Guesser";
            int appVersion = 1;
            string appAuthor = "Kamil";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[{appName}] Wersja: 0.0.{appVersion}, Author: {appAuthor} ");
            Console.ResetColor();
        }

        static string GetUserName()
        {
            Console.WriteLine("Jam masz na imię?");
            string nameInput = Console.ReadLine();
            return nameInput;
        }

        static void GreetUser(string nameInput)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"Powodzenia {nameInput}, odgadnij liczbę....");

            Console.ResetColor();
        }

    }
}