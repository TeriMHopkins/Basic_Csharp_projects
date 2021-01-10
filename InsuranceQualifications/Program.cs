using System;


namespace InsuranceQualifications
{

        class Program
        {
            static void Main()
            {
                Console.WriteLine("What is your age?");
                String UserAnswer1 = Console.ReadLine();
                int Age = Convert.ToInt32(UserAnswer1);

                Console.WriteLine("Have you ever had a DUI? true or false");
                String UserAnswer2 = Console.ReadLine();
                bool Dui = Convert.ToBoolean(UserAnswer2);

                Console.WriteLine("How many speeding tickets do you have?");
                String UserAnswer3 = Console.ReadLine();
                int SpeedTicket = Convert.ToInt32(UserAnswer3);

                Console.WriteLine("Qualified?");
                bool isQualified = (Age >= 16 && Dui == false && SpeedTicket <= 3);
                Console.WriteLine(isQualified);
                Console.ReadLine();
            }
        }
    }

