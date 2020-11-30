using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace FilesAndObjects
{
    class Program
    {
        class Movie
        {
            public string title;
            public string rating;
            public string year;

            public Movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }
        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"imdb.txt";

            List<string> movieList = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();
            List<Movie> listOfMovies = new List<Movie>();

            foreach (string moveItem in movieList)
            {
                string[] tempArray = moveItem.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie((tempArray[0], tempArray[1], tempArray[2]));

                listOfMovies.Add(newMovie);
            }

            foreach(Movie movie in listOfMovies)
            {
                Console.WriteLine("Title: " + movie.title);
                Console.WriteLine("Rating : " + movie.rating);
                Console.WriteLine("Release: " + movie.year);
            }
         }
    }
}
