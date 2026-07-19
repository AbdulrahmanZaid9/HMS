using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utilities
{
    public static class ClsValidation
    {
        // Checks whether a keystroke is valid input for a price field (digits, backspace, single decimal point).
        public static bool IsValidPrice(char keychar, string currentText)
        {
            if (!char.IsDigit(keychar) && keychar != (char)8 && keychar != '.')
            {
                return false;
            }

            if (keychar == '.' && currentText.Contains("."))
            {
                return false;
            }

            return true;
        }

        // Checks whether a keystroke is valid input for an integer field (digits or backspace only).
        public static bool IsValidInteger(char keychar)
        {
            if (!char.IsDigit(keychar) && keychar != (char)8)
            {
                return false;
            }
            return true;
        }

        // Checks whether a string consists entirely of digits (and is non-empty).
        public static bool IsNumber(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        // Checks whether a string is a valid phone number (optional leading +, 7-15 digits).
        public static bool IsValidPhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            return Regex.IsMatch(phone.Trim(), @"^\+?\d{7,15}$");
        }

        // Checks whether a keystroke is valid input for a text field (letters, single spaces, backspace).
        public static bool IsValidString(char keychar, string currentText)
        {
            if (!char.IsLetter(keychar) && !char.IsWhiteSpace(keychar) && keychar != (char)8)
            {
                return false;
            }

            if (char.IsWhiteSpace(keychar) && currentText.Contains("  "))
            {
                return false;
            }

            return true;
        }

        // Checks whether a string is a valid email address format.
        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);
        }
    }
}