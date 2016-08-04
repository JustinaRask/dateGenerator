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
            string yearInput = "";
            int Year = 1;

            string monthInput = "";
            int Month = 1;

            while (true == true)
            {
                Console.WriteLine("Please enter the year:");
                yearInput = Console.ReadLine();

                if (!int.TryParse(yearInput, out Year))
                {
                    Console.WriteLine("Invalid input. Please enter Year number");
                    break;
                }

                while (1 == 1)
                {
                    Console.WriteLine("Please enter month number (1-12):");
                    monthInput = Console.ReadLine();

                    if (!int.TryParse(monthInput, out Month))
                    {
                        Console.WriteLine("Invalid input. Please enter number");
                        continue;
                    }

                    else if (Month < 1 || Month > 12)
                    {
                        Console.WriteLine("There is only 12 months in a year. Please provide correct input");
                        continue;
                    }
                    break;
                }


                if (Month == 2)
                {
                    if (Year % 4 == 0)
                    {
                        Console.WriteLine(yearInput + monthInput + "has 29 days");
                    }
                    else
                    {
                        Console.WriteLine(yearInput + monthInput + "has 28 days");
                    }
                }

                else if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
                {
                    Console.WriteLine(yearInput + monthInput + "has 31."); //string formattedOutput = string.Format ("{0}-{1} has {2} days", year, month, day)
                }
                else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
                {
                    Console.WriteLine(yearInput + monthInput + "has 30 days.");
                }

                Console.WriteLine("Do you want to continue?");
                string closingInput = Console.ReadLine();

                if (closingInput != "y")
                {
                    break;
                }
            }
        }
    }
}
