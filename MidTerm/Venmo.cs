using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MidTerm
{
    class Venmo
    {
		public static void PayCash()
        {
            Console.WriteLine("Great you are paying with Venmo!");

            while (true)
			{
				Console.WriteLine("What is your venmo username?");
				string VenmoUsername = Console.ReadLine();


				if (Regex.IsMatch(VenmoUsername, "^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"))
				{
					Console.WriteLine($"Thanks, your Venmo account {VenmoUsername} has been charged!");
					break;
				}
				else
				{
					Console.WriteLine("Sorry I didn't get that.");
					Console.WriteLine("Please try again");
				}
            }
        }
    }
}
