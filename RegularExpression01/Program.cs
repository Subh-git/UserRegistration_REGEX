using System;

namespace RegularExpression01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome to User Registration Program----------");
            Console.WriteLine("\n Please enter user's First Name--");
            string firstName = Console.ReadLine();
            RegularExp.FirstName(firstName);                                          //taking user input and passing it in first name method of regular exp class
            
        }
    }
}
