using System;

namespace NumberGuesser
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Wywołanie metody w c#. Dane o app.
             */
            GetAppInfo();
            /*
             *  Dane od użytkownika. Przypisanie zmiennej do wyniku działania metody.
             */
            
            string nameInput =  GetUserName();

            GreetUser(nameInput);

            Random r = new Random();
            int correctNumber = r.Next(1,11);
            bool correctAnswer = false;

            Console.WriteLine("Zgadnij jaka liczbę wylosował program. Liczby z przedziału 1 - 10.");

            while (!correctAnswer)
            {
                string numberInput = Console.ReadLine();
                int guess;
                bool isNumber = int.TryParse(numberInput, out guess);

                if (!isNumber)
                {
                    PrintColorMessage(ConsoleColor.Yellow, "Proszę wprowadzić liczbę");
                    continue;
                }
               
                if (guess < 1 || guess > 10)
                {
                    PrintColorMessage(ConsoleColor.Yellow, "Proszę wprowadzić liczbę od 1 do 10");
                    continue;
                }

                if (guess < correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Liczba jest większa!");
                }
                else if (guess > correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Liczba jest mniejsza!");
                }
                else
                {
                    correctAnswer = true;
                    PrintColorMessage(ConsoleColor.Green, $"Brawo! [{nameInput}]");
                }
            }
         
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
            PrintColorMessage(ConsoleColor.Green,greet);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}