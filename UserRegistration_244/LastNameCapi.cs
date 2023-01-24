using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_244
{
    internal class LastNameCapi
    {
        public static bool LastNameValidation(string LName)
        {
            string pattern = "^[A-Z][a-z]{2,}$"; // Last name validation
            // name entered  is match with regex then it is valid otherwise not
            if (Regex.IsMatch(LName, pattern))
            {
                Console.WriteLine($"\nYour Last name  valid=" + LName);
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour Last name  not valid=" + LName);
                return false;
            }
        }
    }
}
