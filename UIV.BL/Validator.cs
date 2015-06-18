using System;
using System.Text.RegularExpressions;

namespace UIV.BL
{
    public class Validator
    {
        public static bool IsValid(string inputString)
        {

            if (String.IsNullOrEmpty(inputString))
                return false;

            if (inputString.Length < 5 || inputString.Length > 12)
                return false;

            Match matchAlphanumeric = Regex.Match(inputString, @"^(?=.*[a-zA-Z0-9].*)([a-zA-Z0-9]+)$");
            if (!matchAlphanumeric.Success)
                return false;

            Match matchAtLeastOneNumberAndOneLetter = Regex.Match(inputString, @"^(?=[^0-9]*[0-9])(?=[^A-Za-z]*[A-Za-z])\w+$");
            if (!matchAtLeastOneNumberAndOneLetter.Success)
                return false;

            Match matchRepeatingSequences = Regex.Match(inputString, @"(\w+)\1");
            if (matchRepeatingSequences.Success)
                return false;

            return true;
        }
    }
}
