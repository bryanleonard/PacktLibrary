using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Packt.CS7
{
    public static class StringExtensions
    //public class StringExtensions
    // works but can be better  StringExtensions.IsValidEmail(email1)
    // versus email1.IsValidEmail()
    {
        // old version doesn't use 'this'
        public static bool IsValidEmail(this string input)
        {
            // use simple regular expression to check  
            // that the input string is a valid email
            return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }
    }
}
