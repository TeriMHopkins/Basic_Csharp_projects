using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main()
        {
            //one dimensional array of strings
            string[] orders = new string[] {"one.", "two.", "three." };

            //user input
            Console.WriteLine("Enter a file type (examples css, txt, pdf): ");
            string userinput = Console.ReadLine();

            //loop appending userinput to strings in array
            for (int i = 0; i < orders.Length; i++)
            {
                orders[i] = orders[i] + userinput;
            }
            //loop to print off each string
            for (int x = 0; x < orders.Length; x++)
            {
                Console.WriteLine(orders[x]);   
            }
            Console.ReadLine();
            //infinite loop
            //while     //switched while to if, fixed loop
            if (orders.Length < 10)
            {
                Console.WriteLine("this was an infinite loop of \"infine loops\"");
            }
            Console.ReadLine();

            //comparison loop using <
            Console.WriteLine(orders[0] + " has less characters than " + orders[2]);
            if (orders[0].Length < orders[2].Length)
            {
                Console.WriteLine(true);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(false);
            }

            //comparison loop using <=

            foreach (string s in orders)
            {

                if (s.Length <= 7)
                {
                    Console.WriteLine(s + "(" + s.Length + ")" + " contains less than 10 characters");
                    Console.ReadLine();
                }
                if (s.Length >= 8)
                {
                    Console.WriteLine(s + "(" + s.Length + ")" + " contains more than 10 characters");
                    Console.ReadLine();
                }
            }
            //unique string list
            List<string> FlavorList = new List<string>
            {
                "VANILLA",
                "CARAMEL",
                "IRISH CREAM",
                "ENGLISH TOFFEE"
            };

            //user input to search for text
            Console.WriteLine("Enter a Flavor: ");
            string search = (Console.ReadLine());
            //loop to display the search text
            string searchUpper = (search.ToUpper());

            bool res = FlavorList.Contains(searchUpper);
            
            if (res == true)
            {
                Console.WriteLine(searchUpper + " found!");
            }
            Console.ReadLine();
            if (res == false)
            {
                Console.WriteLine("Couldn't find " + searchUpper);
            }
            Console.ReadLine();

            //list with two identical string user search

            List<string> People = new List<string>
            {
                "GEORGE",
                "SALLY",
                "SALLY",
                "DONOVAN",
                "MARY",
                "JOE",
                "MARY"
            };

            Console.WriteLine("Search for: ");
            string search2 = (Console.ReadLine());
            Console.WriteLine("\n");
            //loop to display the search text
            string searchUpper2 = (search2.ToUpper());
            var count = 0;
            foreach (string a in People)
            {
                Console.WriteLine(a);
                if (a == searchUpper2)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                Console.WriteLine("\n\n" + searchUpper2 + " has already appeared in list.");
            }
            Console.ReadLine();
            //diplays match
        }
    }
}
