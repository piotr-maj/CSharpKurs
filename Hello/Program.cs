using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ;)
            {

                
                Console.Write("Podaj swoje imie: ");
                string name = Console.ReadLine();
                Console.WriteLine("Witaj " + name);

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

                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();
            }

            // foreach (var item in args)
            // {
            //     Console.WriteLine("Witaj " + item);
            // }
        }
    }
}
