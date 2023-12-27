using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        // Creating an enum for the days of the week
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            bool isvalid = false;
            while (!isvalid)
            {
                try
                {
                    // Prompting the user to enter the current day of the week
                    Console.WriteLine("Please enter the current day of the week:");
                    string dayinput = Console.ReadLine();
                    // Assigning the value to a variable of that enum data type that was created
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayinput);
                    Console.WriteLine("Have a nice " + day + "!");
                    Console.ReadLine();
                    isvalid = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }
        }
    }
}
