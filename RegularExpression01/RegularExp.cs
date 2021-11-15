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
            string firstRegName = "^[A-Z]{1}[a-zA-Z]{2,}$";            //this regular exp shows that first letter must be capital, and minimum letter must be 3    
            try
            {
                bool TestFirstName(string firstName) => (Regex.IsMatch(firstName, firstRegName));           //declaration of a method inside another method
                bool output = TestFirstName(name);
                if (output)                                //it true, then proceed
                {
                    return "Valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "Invalid");         //throwing custom exceptions for handling invalid
                }
            }
            catch(CustomException e)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_VALUE, "Entry cannot be null");     //throwing custom exceptions for handling null entry
            }           
          
        }
        public static string LastName(string name)                 //declaring the static meythod to take user's Last name as entry
        {
            string lastRegName = "^[A-Z]{1}[a-zA-Z]{2,}$";          //this regular exp shows that first letter must be capital, and minimum letter must be 3
            try
            {
                bool TestLastName(string lastName) => (Regex.IsMatch(lastName, lastRegName));           //declaration of a method inside another method
                bool output = TestLastName(name);
                if (output)                                //it true, then proceed
                {
                    return "Valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "Invalid");         //throwing custom exceptions for handling invalid
                }
            }
            catch (CustomException e)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_VALUE, "Entry cannot be null");     //throwing custom exceptions for handling null entry
            }

        }
        public static string Email(string name)
        {
            string emailReg = @"^[a-zA-Z0-9]+[+-._]?[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]+@[a-zA-Z0-9]+[.]{1}[a-zA-Z]{2,3}[.]?[a-zA-Z]{0,3}$";
            //the regular exp email sample.
            //+ means one or more. *- zero or more. ?- zero or 1 
            try
            {
                bool TestEmail(string email) => (Regex.IsMatch(email, emailReg));           //declaration of a method inside another method
                bool output = TestEmail(name);
                if (output)                                //it true, then proceed
                {
                    return "Valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "Invalid");         //throwing custom exceptions for handling invalid
                }
            }
            catch (CustomException e)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_VALUE, "Entry cannot be null");     //throwing custom exceptions for handling null entry
            }

        }

        public static string Mobile(string name)
        {
            string mobileReg = "^([0-9]{2}[ ][0-9]{10})|([0-9]{3}[ ][0-9]{10})$";         //here both country codes with 2 or 3 numbers will be valid. other than that invalid.
            try
            {
                bool TestMobile(string mobile) => (Regex.IsMatch(mobile, mobileReg));           //declaration of a method inside another method
                bool output = TestMobile(name);
                if (output)                                          //it true, then proceed
                {
                    return "Valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "Invalid");         //throwing custom exceptions for handling invalid
                }
            }
            catch (CustomException e)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_VALUE, "Entry cannot be null");     //throwing custom exceptions for handling null entry
            }
        }

        public static string PassWord(string name)
        {
            string pwdReg = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$";
            try
            {
                bool TestPassword(string pwd) => (Regex.IsMatch(pwd, pwdReg));           //declaration of a method inside another method
                bool output = TestPassword(name);
                if (output)                                //it true, then proceed
                {
                    return "Valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "Invalid");         //throwing custom exceptions for handling invalid
                }
            }
            catch (CustomException e)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_VALUE, "Entry cannot be null");     //throwing custom exceptions for handling null entry
            }
        }

    }
    
}
