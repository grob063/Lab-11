using System;
using System.Collections.Generic;

namespace CinematicFilms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 100 movies in this list\n");

            while (true)
            {
                Console.Write("\nWhat category are you interested in? (Animated, Drama, Horror, Scifi): ");
                var input = Console.ReadLine().ToLower();

                if (input == "animated" || input == "drama" || input == "horror" || input == "scifi")
                {
                    List<Movie> movielist = new List<Movie>();
                    movielist.Add(new Movie("Finding Nemo", "animated"));
                    movielist.Add(new Movie("Toy Story", "animated"));
                    movielist.Add(new Movie("Lion King", "animated"));
                    movielist.Add(new Movie("How to Train Your Dragon", "animated"));
                    movielist.Add(new Movie("Shrek", "animated"));
                    movielist.Add(new Movie("Spiderman: Into the Spider-verse", "animated"));
                    movielist.Add(new Movie("Incredibles", "animated"));
                    movielist.Add(new Movie("Aladdin", "animated"));
                    movielist.Add(new Movie("Frozen", "animated"));
                    movielist.Add(new Movie("The Lego Batman Movie", "animated"));
                    movielist.Add(new Movie("Conjuring", "horror"));
                    movielist.Add(new Movie("It", "horror"));
                    movielist.Add(new Movie("Halloween", "horror"));
                    movielist.Add(new Movie("Get Out", "horror"));
                    movielist.Add(new Movie("A Quiet Place", "horror"));
                    movielist.Add(new Movie("Annabelle", "horror"));
                    movielist.Add(new Movie("Sinister", "horror"));
                    movielist.Add(new Movie("Insidious", "horror"));
                    movielist.Add(new Movie("A Cabin in the Woods", "horror"));
                    movielist.Add(new Movie("The Exorcist", "horror"));
                    movielist.Add(new Movie("Shar Wars", "scifi"));
                    movielist.Add(new Movie("Alien", "scifi"));
                    movielist.Add(new Movie("Predator", "scifi"));
                    movielist.Add(new Movie("Star Trek", "scifi"));
                    movielist.Add(new Movie("Interstellar", "scifi"));
                    movielist.Add(new Movie("Arrival", "scifi"));
                    movielist.Add(new Movie("Avenger: End Game", "scifi"));
                    movielist.Add(new Movie("Guardians of the Galaxy", "scifi"));
                    movielist.Add(new Movie("The Martian", "scifi"));
                    movielist.Add(new Movie("Gravity", "scifi"));
                    movielist.Add(new Movie("True Story", "drama"));
                    movielist.Add(new Movie("Bohemian Phapsody", "drama"));
                    movielist.Add(new Movie("First Man", "drama"));
                    movielist.Add(new Movie("12 Years of Slave", "drama"));
                    movielist.Add(new Movie("Room", "drama"));
                    movielist.Add(new Movie("Gravity", "drama"));
                    movielist.Add(new Movie("The Blind Side", "drama"));
                    movielist.Add(new Movie("Schindler's List", "drama"));
                    movielist.Add(new Movie("Prisoners", "drama"));
                    movielist.Add(new Movie("The Wrestler", "drama"));


                    foreach (Movie movie in movielist)
                    {
                        if (movie.category == input)
                        {
                            Console.WriteLine(movie.title);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nYou entered the wrong selection. Please enter correct selection");
                    continue;
                }

                while (true)
                {
                    Console.WriteLine();
                    Console.Write("Continue? (y/n): ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "yes")
                        break;
                    if (answer == "n")
                        return;
                }
            }
        }
    }
}
