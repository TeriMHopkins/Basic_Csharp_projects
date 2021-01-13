using System;
using System.Text;

namespace IterationProject
{
    class Program
    {
        static void Main()
        {
            string[] CoffeeBeans;

            CoffeeBeans = new string[] { "Arabic Roast: ", "Columbian Roast: ", "French Roast: " };
            Console.WriteLine("How would you like your coffee beans: ");
            Console.WriteLine("Ground or Whole Bean?");
            string userinput = Console.ReadLine();

            CoffeeBeans[0] = CoffeeBeans[0] + userinput;
            CoffeeBeans[1] = CoffeeBeans[1] + userinput;
            CoffeeBeans[2] = CoffeeBeans[2] + userinput;

            for (int i = 0; i < CoffeeBeans.Length; i++)
            {
                Console.WriteLine(CoffeeBeans[i] + "\n");
            }
            Console.ReadLine();
        }   

    }
}
