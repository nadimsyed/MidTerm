using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    class Cash
    {
		public static void PayCash()
		{
			Console.WriteLine("Great you are paying with cash!");

			while (true)
			{
				Console.WriteLine("How much cash are you inserting?");
				string CashInserted = Console.ReadLine();
				//int CashInsertedNum = Int32.Parse(CashInserted);

				if (Validator.IntChecker(CashInserted))
				{
					Console.WriteLine($"Thanks, you inserted {CashInserted}.");
					break;
				}
				else if (!Validator.IntChecker(CashInserted))
				{
					Console.WriteLine("Sorry that was not a number.");
					Console.WriteLine("Please try again");
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
