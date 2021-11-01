using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression01
{
    public static class RegularExp                                  //creating a static regular exp class for easy method invoking in program.cs
    {
        public static void FirstName(string name)                   //declaring the static meythod to take user's first name as entry
        {
            string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";            //this regular exp shows that first letter must be capital, and minimum letter must be 3
            Regex regex = new Regex(firstName);
            if (regex.IsMatch(name))                               //calling the Regex class's functions
            {
                Console.WriteLine(name + " is valid. Proceed to entering the Last Name");
            }
            else
                Console.WriteLine(name + " is invalid. Please check your name and start with capital letter.");
        }


        public static void LastName(string name)                 //declaring the static meythod to take user's Last name as entry
        {
            string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";          //this regular exp shows that first letter must be capital, and minimum letter must be 3
            Regex regex = new Regex(lastName);
            if (regex.IsMatch(name))                             //calling the Regex class's functions
            {
                Console.WriteLine(name + " is valid.Proceed enterring your emailid.");
            }
            else
                Console.WriteLine(name + " is invalid. Please check your name and start with capital letter.");
        }


        //the following static method is to validate the user entered email id as per the genuine rules and test cases given
        public static void EmailArr(string[] name) //to check the array of email id's if needed.
        {
            string email = @"^[a-zA-Z0-9]+[+-._]?[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]+@[a-zA-Z0-9]+[.]{1}[a-zA-Z]{2,3}[.]?[a-zA-Z]{0,3}$"; 
            //the regular exp email sample.
            //+ means one or more. *- zero or more. ?- zero or 1 

            Regex regex = new Regex(email);            //creating a regex named obj with regular exp email.
            foreach (var word in name)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + " is valid.");
                }
                else
                    Console.WriteLine(word + " is invalid.");
            }
        
        }
        public static void Email(string name)
        {
            string email = @"^[a-zA-Z0-9]+[+-._]?[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]+@[a-zA-Z0-9]+[.]{1}[a-zA-Z]{2,3}[.]?[a-zA-Z]{0,3}$";
            //the regular exp email sample.
            //+ means one or more. *- zero or more. ?- zero or 1 

            Regex regex = new Regex(email);            //creating a regex named obj with regular exp email.                        
             if (regex.IsMatch(name))
             {
                Console.WriteLine(name + " is valid. Proceed to enterring your mobile number.");
             }
             else
                Console.WriteLine(name + " is invalid.");
        }

        public static void Mobile(string name)
        {
            string mobile = "^([0-9]{2}[ ][0-9]{10})|([0-9]{3}[ ][0-9]{10})$";         //here both country codes with 2 or 3 numbers will be valid. other than that invalid.
            Regex regex = new Regex(mobile);                                           //creating a regex named obj with regular exp mobile number.                        
            
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid. Proceed to enterring your password.");
            }
            else
                Console.WriteLine(name + " is invalid.");
        }

    }
    
}
