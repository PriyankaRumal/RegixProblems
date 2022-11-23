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

            Console.WriteLine("enter your Last Name:");
            string Lname = Console.ReadLine();
            userValidation.ValidatateLastName(Lname);

            Console.WriteLine("Enter your Email: ");
            string email = Console.ReadLine();
            userValidation.ValidateEmail(email);

            Console.WriteLine("Enter PhoneNumber: ");
            string phonenumber = Console.ReadLine();
            userValidation.ValidatePhoneNumber(phonenumber);

            Console.WriteLine("Enter password 8 characters");
            string password = Console.ReadLine();
            userValidation.ValidatePassword(password);

            Console.WriteLine("Enter password 1 uppercase");
            string Uppercase = Console.ReadLine();
            userValidation.ValidateUppercase(Uppercase);
        }
    }
}
