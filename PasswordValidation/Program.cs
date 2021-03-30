using System;

namespace PasswordValidation
{
    class Program
    {
        // https://edabit.com/challenge/etT7orqDDXJF2zGYM
        // SOLVED

        static void Main(string[] args)
        {
            Validator password = new("Goby1aaa");
            password.IsCorrectLength();
            password.HasCorrectCases();
            password.IsDigit();
            password.CreateShiftedString1();
            password.CreateShiftedString2();
            password.HasRepeatingCharacters();
            Console.Write(password.IsPasswordValid());
        }
    }
}
