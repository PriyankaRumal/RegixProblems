using System;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problems Statement Using REGEX");
            Console.WriteLine("enter your First Name:");
            string Fname=Console.ReadLine();
            UserValidation userValidation = new UserValidation();
            userValidation.ValidatateFirstName(Fname);
        }
    }
}
