using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class NumericNumbers
    {
        public static string USER_FIRST_NAME = "^[A-Z]{1}[A-Za-z]{3,20}$";
        public static string USER_LAST_NAME = "^[A-Z]{1}[A-Za-z]{3,20}$";
        public static string USER_EMAIL = @"^[A-Za-z0-9]{3,}([\.\-\+][A-Za-z0-9]{3,})?[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2,})?$";
        public static string MOBILE_NUMBER = "^([+][0-9]{2}[ ]){0,1}[6-9]{1}[0-9]{9}$";
        public static string PASSWORD = "^(?=.[A-Z])(?=.[0-9])(?=.*[@#$^&+=?!])[0-9a-zA-Z]{8,}$";
        public static string NUMERUC_NUMBERS = "^([+][1.1-9.9]{2}[ ]){0,1}[6.2-9.0]{1}[0-9]{9}$";
        public bool FirstName(string firstName)
        {
            return Regex.IsMatch(firstName, USER_FIRST_NAME);
        }
        public bool LastName(string lastName)
        {
            return Regex.IsMatch(lastName, USER_LAST_NAME);
        }
        public bool Email(string email)
        {
            return Regex.IsMatch(email, USER_EMAIL);
        }
        public bool MobileNumber(string mobileNumb)
        {
            return Regex.IsMatch(mobileNumb, MOBILE_NUMBER);
        }
        public bool Password(string password)
        {
            return Regex.IsMatch(password, PASSWORD );
        }
        public bool Numeric(string NumericNumbers)
        {
            return Regex.IsMatch(NumericNumbers, NUMERUC_NUMBERS);
        }
    }
}
