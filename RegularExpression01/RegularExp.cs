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
        public static string FirstName(string name)                   //declaring the static meythod to take user's first name as entry
        {
            string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";            //this regular exp shows that first letter must be capital, and minimum letter must be 3
            Regex regex = new Regex(firstName);
            if (regex.IsMatch(name))                               //calling the Regex class's functions
            {
                return "Valid";
            }
            else
                return "Invalid";
        }


        public static string LastName(string name)                 //declaring the static meythod to take user's Last name as entry
        {
            string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";          //this regular exp shows that first letter must be capital, and minimum letter must be 3
            Regex regex = new Regex(lastName);
            if (regex.IsMatch(name))                             //calling the Regex class's functions
            {
                return "Valid";
            }
            else
                return "Invalid";
        }


        //the following static method is to validate the user entered email id as per the genuine rules and test cases given
        //public static string EmailArr(string[] name) //to check the array of email id's if needed.
        //{
        //    string email = @"^[a-zA-Z0-9]+[+-._]?[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]+@[a-zA-Z0-9]+[.]{1}[a-zA-Z]{2,3}[.]?[a-zA-Z]{0,3}$"; 
        //    //the regular exp email sample.
        //    //+ means one or more. *- zero or more. ?- zero or 1 

        //    Regex regex = new Regex(email);            //creating a regex named obj with regular exp email.
        //    foreach (var word in name)
        //    {
        //        if (regex.IsMatch(word))
        //        {
        //            return "is Valid.";
        //        }
        //    }
        //    return "is Invalid";
        //}
        public static string Email(string name)
        {
            string email = @"^[a-zA-Z0-9]+[+-._]?[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]+@[a-zA-Z0-9]+[.]{1}[a-zA-Z]{2,3}[.]?[a-zA-Z]{0,3}$";
            //the regular exp email sample.
            //+ means one or more. *- zero or more. ?- zero or 1 

            Regex regex = new Regex(email);            //creating a regex named obj with regular exp email.                        
             if (regex.IsMatch(name))
             {
                return "Valid";
             }
             else
                return "Invalid";
        }

        public static string Mobile(string name)
        {
            string mobile = "^([0-9]{2}[ ][0-9]{10})|([0-9]{3}[ ][0-9]{10})$";         //here both country codes with 2 or 3 numbers will be valid. other than that invalid.
            Regex regex = new Regex(mobile);                                           //creating a regex named obj with regular exp mobile number.                        
            
            if (regex.IsMatch(name))
            {
                return "Valid";
            }
            else
                return "Invalid";
        }

        public static string PassWord(string name)
        {
            string pwd = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$";
            Regex regex = new Regex(pwd);                                           //creating a regex named obj with regular pwd.
            if (regex.IsMatch(name))
            {
                return "Valid";
            }
            else
                return "Invalid";
        }

    }
    
}
