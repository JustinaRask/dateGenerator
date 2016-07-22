using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            { 
            Console.WriteLine("Please enter the year:");
            string input = Console.ReadLine();
            int Year = 1;
            int.TryParse(input, out Year);

            if (!int.TryParse(input, out Year))
            {
              Console.WriteLine("Invalid input. Please enter number");
                    continue;
            }
            Console.WriteLine("Please enter month number (1-12):");
            string input1 = Console.ReadLine();
            int Month = 1;
            int.TryParse(input1, out Month);

            if (Month == 2)
                    if (Year % 4 == 0)
                    {
                        Console.WriteLine(input  +  input1  +  "has 29 days");
                    }
                    else
                    {
                        Console.WriteLine(input + input1 + "has 28 days");
                    }
          
            if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
            {
                Console.WriteLine(input + input1 + "has 31.");
            }
            else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
            {
                Console.WriteLine(input + input1 + "has 30 days.");
            }

            if (Month < 1 || Month > 12)
                {
                    Console.WriteLine("There is only 12 months in a year. Please provide correct input");
                    continue;
                }

            if (!int.TryParse(input1, out Month))
                {
                    Console.WriteLine("Invalid input. Please enter number");
                    continue;
                }
           
                Console.WriteLine("Do you want to continue?");
            string input3 = Console.ReadLine();

            if (input3 != "y")
            {
                break;
            }
            }
           

        }
    }
}
