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
