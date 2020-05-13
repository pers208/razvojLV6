using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedmiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordValidator passwordValidator = new PasswordValidator(new StringDigitChecker());
            passwordValidator.AddNext(new StringLengthChecker());
            passwordValidator.AddNext(new StringUpperCaseChecker());
            passwordValidator.AddNext(new StringLowerCaseChecker());
            Console.WriteLine(passwordValidator.CheckValidation("aaa"));
            Console.WriteLine(passwordValidator.CheckValidation("aa1111111aZZ"));
            Console.WriteLine(passwordValidator.CheckValidation("aaaAA22Z"));
            Console.WriteLine(passwordValidator.CheckValidation("aaaAA22"));
            Console.WriteLine(passwordValidator.CheckValidation("aAa121"));

        }
    }
}