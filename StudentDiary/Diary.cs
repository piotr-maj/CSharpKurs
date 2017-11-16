using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {

        // stan klasy
        // ratings - zmienna oceny

        List<float> ratings;

        // achowania klasy, metody
        // rating - zemianna ocena

        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum = sum + rating;
                // zapis równoznaczny sum +=rating;
                                            }
            avg = sum / ratings.Count();
            //Count - daje ilość elementów w kolekcji

            return avg;
        }
        
        public float GiveMaxRating()
        {

            return ratings.Max();
        }

        public float GiveMinRating()
        {
            return ratings.Min();
        }


    }
}
