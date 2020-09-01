using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;


namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            //var randomNum = new Random();
            
            var getNum = MyLinq.Random().Where(n => n < .3).OrderBy(n => n).Take(10);
            foreach (var item in getNum)
            {
                Console.WriteLine(item);
            }

            var movies = new List<Movies>()
            {
                new Movies { Title = "Airbender",       Rating = 1.9f, Year = 1999},
                new Movies { Title = "Transformers",    Rating = 4.8f, Year = 2007},
                new Movies { Title = "Patton",          Rating = 4.9f, Year = 1970},
                new Movies { Title = "Trolls",          Rating = 4.6f, Year = 2018},
                new Movies { Title = "Batman",          Rating = 3.8f, Year = 1998}
            };
            var query = movies.Where(m => m.Year > 2000).OrderBy(m => m.Title);
            var ennumerator = query.GetEnumerator();
            while(ennumerator.MoveNext())
            {
                Console.WriteLine(ennumerator.Current.Title);
            }
            Console.WriteLine("-----------------");
            foreach (var movie in query)
            {
                Console.WriteLine(movie.Title);
            }
        }
    }
    public class Movies
    {
        public string Title { get; set; }
        public float Rating { get; set; }
        int _year;
        public int Year
        {
            get
            {
                Console.WriteLine($"LINQ : {_year} {Title}");
                return _year;

            }
            set
            { _year = value; }
        }
    }
    public static class MyLinq
    {
        public static IEnumerable<double> Random()
        {
            var random = new Random();
            while (true)
            { yield return random.NextDouble(); }
        }

        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,
                                               Func<T, bool> predicate)
        {
            var result = new List<T>();

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
            //return result;
        }
    }

}

