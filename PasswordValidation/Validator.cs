using System;

namespace PasswordValidation
{
    public class Validator
    {
        private readonly string _password;
        private string ShiftedPassword { get; set; }
        private string ShiftedPassword1 { get; set; }
        private bool IsValid { get; set; }

        public Validator(string password) // "P1zz@"
        {
            _password = password;
            IsValid = true;
        }

        public void IsCorrectLength()
        {
            if (_password.Length > 24 || _password.Length < 6) IsValid = false;
        }

        public void HasCorrectCases()
        {
            bool isUpper = false;
            bool isLower = false;
            for(int i = 0; i < _password.Length; i++)
            {
                char c = _password[i];
                if(Char.IsUpper(c)) isUpper = true;
                if(Char.IsLower(c)) isLower = true;
            }
            if (!isUpper || !isLower) IsValid = false;
        }

        public void IsDigit()
        {
            bool isDigit = false;
            for(int i = 0; i < _password.Length; i++)
            {
                char c = _password[i];
                if (Char.IsNumber(c)) isDigit = true;
            }
            if (!isDigit) IsValid = false;
        }

        public void HasRepeatingCharacters()
        {
            bool isRepeating = false;
            for(int i = 0; i < _password.Length; i++)
            {
                char c = _password[i];
                char c1 = ShiftedPassword[i];
                char c2 = ShiftedPassword1[i];
                if (c == c1 && c1 == c2) isRepeating = true;
            }
            if (isRepeating) IsValid = false;
        }

        public void CreateShiftedString1() // "aaaW123@"
        {
            string s = "";
            char offsetLength = '1';
            for(int i = 1; i < _password.Length; i++)
            {
                char c = _password[i];
                s += c;
            }
            s += offsetLength;
            ShiftedPassword = s;
        }

        public void CreateShiftedString2() // "W123aaa@"
        {
            string s = "";
            char offsetLength = '2';
            char offsetLength1 = '3';
            for (int i = 2; i < _password.Length; i++)
            {
                char c = _password[i];
                s += c;
            }
            s += offsetLength;
            s += offsetLength1;
            ShiftedPassword1 = s;
        }

        public bool IsPasswordValid() => IsValid;
    }
}
