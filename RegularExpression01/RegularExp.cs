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
                Console.WriteLine(name + " is valid");
            }
            else
                Console.WriteLine(name + " is invalid. Please check your name and start with capital letter.");
        }
    }
    
}
