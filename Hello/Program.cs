using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ;)
            {
                Greeting();
                Age();
                Settings();
            }

            // foreach (var item in args) 
            // { 
            //     Console.WriteLine("Witaj " + item);
            // }
        }
        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Wypisuje komunikat zależny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Podaj swój wiek: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Możesz wypić browara.");
            }

            else if (result == false)
            {
                Console.Write("Wprowadziłeś niewłaściwy wiek.");
            }

            else
            {
                Console.Write("Jesteś niepełnoletni, dostaniesz mleko.");
            }
        }
        /// <summary>
        /// Wypisuje powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Podaj swoje imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj " + name);
        }
    }
}
