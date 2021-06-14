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
            string appLanguage = "c#";
            
            string info = $"[{ appName}] Wersja: 0.0.{appVersion} Author: {appAuthor} Leanguage: {appLanguage}";
            PrintColorMessage(ConsoleColor.Magenta, info);
        }

        static string GetUserName()
        {
            Console.WriteLine("Jam masz na imię?");
            string nameInput = Console.ReadLine();
            return nameInput;
        }

        static void GreetUser(string nameInput)
        {
            string greet = $"Powodzenia {nameInput}, odgadnij liczbę....";
            PrintColorMessage(ConsoleColor.Yellow,greet);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }



    }
}