using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {

            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(3.5f);
            //diary.AddRating(1.5f);

            //float avg = diary.CalculateAverage();
            //float min = diary.GiveMinRating();
            //float max = diary.GiveMaxRating();

            for ( ; ; )
            {
                Console.WriteLine("Podaj ocenę w zakresie 1 - 10");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);

                

                if (rating == 11)
                {
                    break;
                }

                if (result == true)
                {
                    if (rating > 0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna ocena !");
                    }
                                                             
                }
            }
            Console.WriteLine("Średnia ocena to : " + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to : " + diary.GiveMaxRating());
            Console.WriteLine("Najniższa ocena to : " + diary.GiveMinRating());
            Console.ReadKey();
        }
    }
}
