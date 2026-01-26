using System;
using System.Collections.Generic;
using System.Text;

namespace ThePasswordValidator
{
    internal class PasswordValidator
    {
        private readonly string _password;

        public PasswordValidator(string password)
        {
            _password = password;
        }

        public bool IsValid(out string message)
        {
            bool hasDigitChar = false;
            bool hasUpperCaseChar = false;
            bool hasLowerCaseChar = false;
            bool hasCapitalTChar = false;
            bool hasAmpersandSymbol = false;
            bool isCorrectLength = false;


            if (_password.Length >= 6 || _password.Length <= 13)
            {
                isCorrectLength = true;
            }
            
            foreach (char c in _password)
            {
                if (char.IsUpper(c)) hasUpperCaseChar = true;

                if (char.IsLower(c)) hasLowerCaseChar = true;

                if (char.IsDigit(c)) hasDigitChar = true;

                if (c == 'T') hasCapitalTChar = true;

                if (c == '&') hasAmpersandSymbol = true;
            }

            if (!isCorrectLength)
            {
                message = "Password needs to be more than 6 characters and less than 13";
                return false;
            }
            if (!hasDigitChar || !hasUpperCaseChar || !hasLowerCaseChar)
            {
                message = "Password must contain at least one uppercase letter, one lowercase and one number";
                return false;
            }
            if (hasAmpersandSymbol || hasCapitalTChar)
            {
                message = "Password must not contain a capital T or an & character";
                return false;
            }

            message = "Password is valid!";
            return true;

        }

    }
}
