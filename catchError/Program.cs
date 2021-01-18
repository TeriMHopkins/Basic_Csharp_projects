using System;
using System.Collections.Generic;

namespace catchError
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int> { 134, 252, 3513, 4435, 5134, 643, 74, 83, 91 };
            bool run = true;
            while (run == true)
            {
                try
                {
                    Console.WriteLine("Pick a number: ");
                    int userNumber = Convert.ToInt32(Console.ReadLine());

                    foreach (int location in numbers)
                    {
                        Console.WriteLine(location + " divided by " + userNumber + " equals " + location / userNumber);
                    }
                    Console.ReadLine();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                    
                }
                finally
                {
                    Console.WriteLine("Program has finished try/catch loop. Try again? Y/N ");
                    string UserAnswer = Console.ReadLine();
                    string Y = "Y";
                    if (UserAnswer == Y)
                    {
                        run = true;
                    }
                    else
                    {
                        run = false;
                    }

                }
            }

        }

    }
}
