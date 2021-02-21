using System;
using System.Text.RegularExpressions;

namespace GlucoCheck.Classes
{
    public static class DataValidation
    {
        /// <summary>
        /// Checks if a string is a natural number. A "natural number" is a
        /// number that should be greater than 0, such insulin dosed (which of
        /// course, can't be something like -3).
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNaturalNumber(string input)
        {
            //This regular expression checks if a string only consists of
            //digits (that is, if the string is a number). This regex was found
            //on Stack overflow (see the second answer):
            //https://stackoverflow.com/questions/894263/identify-if-a-string-is-a-number
            if (!Regex.IsMatch(input, @"^\d+$"))
                return false;

            else if (Convert.ToInt32(input) < 0)
                return false;

            else
                return true;
        }
    }
}