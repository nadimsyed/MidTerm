using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MidTerm
{
    class Credit
    {
        public static void GetCredit()
        {
            Regex ValidateFullCardNumber = new Regex(@"^[0 - 9]{ 16}$");
            Regex ValidateExpiration = new Regex(@"(0[1-9]|1[12])[/](09|[1-9][9])");
            Regex ValidateCardBack = new Regex(@"^\d{3}$");

            Console.Write("Please enter a valid card number: ");
            string CardNumber = Console.ReadLine();

            //int num;
            //int.TryParse(input, out num);

            if (ValidateFullCardNumber.IsMatch(CardNumber))
            {
                Console.Write("Please enter the expiration date on the card: ");
                string ExpDate = Console.ReadLine();

                if (ValidateExpiration.IsMatch(ExpDate))
                {
                    Console.Write("Please enter the CVV on the back of the card: ");
                    string CVV = Console.ReadLine();

                    if (ValidateCardBack.IsMatch(CVV))
                    {
                        Console.WriteLine("Thanks!");
                    }
                    else
                    {
                        Console.WriteLine("Not a valid CVV");
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid card number");
                }
            }
            else
            {
                Console.WriteLine("Not a valid expiration date");
            }
        }
    }
}
