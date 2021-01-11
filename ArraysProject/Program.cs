using System;


namespace ArraysProject
{
    class Program
    {
        static void Main()
        {
            string[] genres;
            genres = new string[] { "Horror", "Comedy", "Drama", "SciFi", "Classic" };
            Console.WriteLine("Select an index: ");
            int usersChoice = Convert.ToInt32(Console.ReadLine());
                if (usersChoice > genres.Length)
                {
                    Console.WriteLine("Invalid index");
                    Console.ReadLine();

                }
            else
            {
                Console.WriteLine(genres[usersChoice]);
                Console.ReadLine();
            }

            int[] years = { 1, 2, 3, 4 };
            Console.WriteLine("Select an index: ");
            int usersChoice2 = Convert.ToInt32(Console.ReadLine());
            if (usersChoice2 >= years.Length)
            {
                Console.WriteLine("Invalid index");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine(years[usersChoice2]);
                Console.ReadLine();
            }

            string[,] movies = new string[,] { { "Alfred Hitchcock", "Psycho" }, { "Steven Spielberg", "E.T" }, { "Gary Ross", "Oceans Eleven" }, };
            Console.WriteLine("Select an index: ");
            int usersChoice3 = Convert.ToInt32(Console.ReadLine());
                if (usersChoice3 >= movies.Length)
                {
                    Console.WriteLine("Invalid index");
                    Console.ReadLine();
                }
            else
            {
                Console.WriteLine(movies[usersChoice3,1]);
                Console.ReadLine();
            }


        }
    }
}
