using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserValidation
    {
        public const string First_Name = "^[A-Z][a-zA-z]{2,}$";
        public const string Last_Name = "^[A-Z][a-zA-z]{2,}$";
        public void ValidatateFirstName(string firstName)
        {
            Regex regex = new Regex(First_Name);
            bool result=regex.IsMatch(firstName);
            Console.WriteLine(result);
        }

        public void ValidatateLastName(string lastName)
        {
            Regex regex = new Regex(Last_Name);
            bool result = regex.IsMatch(lastName);
            Console.WriteLine(result);
        }
    }
}
