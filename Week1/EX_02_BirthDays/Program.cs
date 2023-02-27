using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EX_02_BirthDays
{
    public class Program
    {

        static void Main(string[] args)
        {

            //DateTime now = DateTime.Now;
            DateTime now;

            DateTime.TryParse("01/02/2022", out now);


            Console.WriteLine($"Welcome! Today's date is: {now.ToString("dd/MM/yyyy")}");


            while(true)
            {
                DateTime date;

                Console.Write("Please enter a day of birth: ");
                if (DateTime.TryParse(Console.ReadLine(), out date) == false) { NotValid(); continue; }

                if (date > now)
                {
                    NotValid();
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"This person is born on {date.ToString("dddd MMMM dd, yyyy.")}");

                DateTime nextBirthday = date.AddYears(now.Year - date.Year);

                if (nextBirthday < now)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }

                Console.WriteLine($"{(nextBirthday - now).Days} days to go until your next birthday!");
                Console.ResetColor();

                Console.ReadLine();
            }

        }

        static public void NotValid()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not a valid date");
            Console.ResetColor();
        }
    }
}
