﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_244
{
    internal class FirstNameCapi
    {
        public static void FirstNameValidation(string FirstName)
        {
            string pattern = "^[A-Z][a-z]{2,}$"; // Creating REGEX pattern
            if (Regex.IsMatch(FirstName, pattern)) //For checking regex are valid or invalid
            {
                Console.WriteLine("The First name is : " + FirstName);
            }
            else
            {
                Console.WriteLine("Invalid Name ");
            }
        }
    }
}
