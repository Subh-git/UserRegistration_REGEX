using System;
using System.Collections.Generic;

namespace RegularExpression01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome to User Registration Program----------");
            Console.WriteLine("\n Please enter user's First Name--");
            string firstName = Console.ReadLine();
            RegularExp.FirstName(firstName);                                 //taking user input and passing it in first name method of regular exp class
            string lastName = Console.ReadLine();
            RegularExp.LastName(lastName);                                  //taking user input and passing it in last name method of regular exp class
            string email = Console.ReadLine();
            RegularExp.Email(email);

            //string[] emailEntries = {"abc@gmail.com", "1.abc@yahoo.com", "2.abc-100@yahoo.com", "3.abc.100@yahoo.com", "2.abc111@abc.com", "4.abc-100@abc.net", "5.abc.100@abc.com.au", "6.abc@1.com", "7.abc@gmail.com.com", "8.abc+100@gmail.com" };            
            //string[] testInvalidEmail = { "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };

        }
    }
}






