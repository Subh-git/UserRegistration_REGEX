using System;
using System.Collections.Generic;

namespace RegularExpression01
{
    class Program
    {
        /// <summary>
        /// The user registration form that takes user's entry
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome to User Registration Program----------");
            Console.WriteLine("\n Please enter user's First Name--");
            string firstName = Console.ReadLine();
            Console.WriteLine(RegularExp.FirstName(firstName));                                 //taking user input and passing it in first name method of regular exp class
            Console.WriteLine("\n Please enter user's Last Name--");
            string lastName = Console.ReadLine();
            Console.WriteLine(RegularExp.LastName(lastName));                                   //taking user input and passing it in last name method of regular exp class
            Console.WriteLine("\n Please enter your Email--");
            string email = Console.ReadLine();
            Console.WriteLine(RegularExp.Email(email));                                         //email entry
            Console.WriteLine("\n Please enter your Mobile Number--");
            string mobile = Console.ReadLine();
            Console.WriteLine(RegularExp.Mobile(mobile));                                       //mobile number with country code
            Console.WriteLine("\n Please enter your Password--");
            string pwd = Console.ReadLine();                                                    //password
            Console.WriteLine(RegularExp.PassWord(pwd));
        }
    }
}






