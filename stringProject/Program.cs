using System;
using System.Text;

namespace stringProject
{
    class Program
    {
        static void Main()
        {
            string fname = "Teri ";
            string mname = "Michelle ";
            string lname = "Carris";
            string fullname = fname + mname + lname;
            Console.WriteLine(fullname.ToUpper());
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("Hello! ");
            sb.Append("This is my string builder paragraph. ");
            sb.Append("The end.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
