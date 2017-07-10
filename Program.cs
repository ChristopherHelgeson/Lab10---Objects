using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            Movie a = new Movie("Toy Story", "animated");
            movies.Add(a);
            Movie b = new Movie("Beauty and the Beast", "animated");
            movies.Add(b);
            Movie c = new Movie("2001: A Space Odyssey", "scifi");
            movies.Add(c);
            Movie d = new Movie("Dune", "scifi");
            movies.Add(d);
            Movie e = new Movie("Star Wars", "scifi");
            movies.Add(e);
            Movie f = new Movie("Hacksaw Ridge", "drama");
            movies.Add(f);
            Movie g = new Movie("Schindler's List", "drama");
            movies.Add(g);
            Movie h = new Movie("No Country for Old Men", "drama");
            movies.Add(h);
            Movie j = new Movie("Silence of the Lambs", "horror");
            movies.Add(j);
            Movie k = new Movie("Saw", "horror");
            movies.Add(k);
            Movie l = new Movie("Moana", "animated");
            movies.Add(l);
            Movie m = new Movie("IT", "horror");
            movies.Add(m);
            Movie n = new Movie("Dumb and Dumber", "comedy");
            movies.Add(n);

            Console.Clear();
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("\nThere are " + movies.Count() + " movies in this database.");

            Console.WriteLine("\nThe movies are in the following categories:\n");

            List<string> catList = new List<string>();

            foreach (Movie s in movies)
            {
                string dc = s.getCategory();
                catList.Add(dc);
            }

            List<string> distinctCats = catList.Distinct().ToList();

            for (int i = 0; i < distinctCats.Count; i++)
            {
                Console.WriteLine(i + ") " + distinctCats[i]);
            }

            Console.WriteLine();

            Console.Write("Make a selection to see the movies in that category: ");
            int userInput = -1;
            while (userInput < 0 || userInput > distinctCats.Count)
            {
                userInput = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nIn the category of " + distinctCats[userInput] + " our database contains these titles:\n");

            foreach (Movie cj in movies)
            {
                string cat = cj.getCategory();
                if (cat == distinctCats[userInput])
                {
                    Console.WriteLine(cj.getTitle());
                }
            }
            Console.WriteLine();
        }
    }
}
