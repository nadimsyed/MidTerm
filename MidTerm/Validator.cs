using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MidTerm
{
    class Validator
    {
        public static bool CreditCardNumberChecker(string x)
        {
            return Regex.IsMatch(x, (@"^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$"));
        }

        public static bool CreditCardExpirationChecker(string x)
        {
            return Regex.IsMatch(x, @"(0[1-9]|1[12])[/](09|[1-9][9])");
        }

        public static bool VenmoUserNameChecker(string x)
        {
            return Regex.IsMatch(x, "^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");
        }

        public static bool CreditCardCVVChecker(string x)
        {
            return Regex.IsMatch(x, @"^\d{3}$");
        }

        public static bool DoubleChecker(string x)
        {
            return double.TryParse(x, out double work);
        }

        public static bool IntChecker(string x)
        {
            return int.TryParse(x, out int work);
        }

        public static bool SpaceEnterChecker(string input)
        {
            return (input == "" || Regex.IsMatch(input, @"\s"));
        }

        public static bool DateTimeChecker(string input)
        {
            bool dateTimeWorked = DateTime.TryParse(input, out DateTime dateTime);
            return dateTimeWorked;
        }
    }
}
