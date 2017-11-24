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
            diary.AddRating(5);
            diary.AddRating(3.5f);
            diary.AddRating(1.5f);

            float avg = diary.CalculateAverage();
            float min = diary.GiveMinRating();
            float max = diary.GiveMaxRating();

            for ( ; ; )
            {
                Console.WriteLine("Podaj ocenę w zakresie 1 - 10");
                float rating = Console.ReadLine();
            }
        }
    }
}
