using System;


namespace booleanProject
{
    class Program
    {
        static void Main()
        {
            bool program = true;
            do
            {

                Console.WriteLine("enter what day it is 1 - 7");
                string intput = Console.ReadLine();
                int day = Convert.ToInt32(intput);

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        while (day == 1)
                        {
                            Console.WriteLine("todays lunch is spaghetti");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                }


                Console.ReadLine();
            }
            while (program == false);
        }      
        
    }

}



