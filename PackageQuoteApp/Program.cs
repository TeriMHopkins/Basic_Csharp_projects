using System;


namespace PackageQuoteApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.\n\n");
            Console.WriteLine("Please enter package weight: ");
            String weight = Console.ReadLine();
            int packageWeight = Convert.ToInt32(weight);
            if (packageWeight > 50)
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nPlease enter package width: ");
                String width = Console.ReadLine();
                int packageWidth = Convert.ToInt32(width);

                Console.WriteLine("\nPlease enter package height: ");
                String height = Console.ReadLine();
                int packageHeight = Convert.ToInt32(height);

                Console.WriteLine("\nPlease enter package length: ");
                String length = Console.ReadLine();
                int packageLength = Convert.ToInt32(length);

                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("\nPackage too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    int total = packageWidth * packageHeight * packageLength * packageWeight / 100;

                    Console.WriteLine("\nYour estimated total for shipping this package is: " + total);
                    Console.ReadLine();
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }   
        }
    }
}
