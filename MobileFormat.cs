using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class MobileFormat
    {
        public static string USER_FIRST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        //public static string USER_LAST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string USER_MOBILE_FORMAT = "91 9600813037";
        public bool FirstName(string firstName)
        {
            return Regex.IsMatch(firstName, USER_FIRST_NAME);
        }
    }
}
