using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sestiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDigitChecker stringDigitChecker = new StringDigitChecker();
            StringLengthChecker stringLengthChecker = new StringLengthChecker();
            StringUpperCaseChecker stringUpperCaseChecker = new StringUpperCaseChecker();
            StringLowerCaseChecker stringLowerCaseChecker = new StringLowerCaseChecker();

            stringDigitChecker.SetNext(stringLengthChecker);
            stringLengthChecker.SetNext(stringUpperCaseChecker);
            stringUpperCaseChecker.SetNext(stringLowerCaseChecker);

            Console.WriteLine("Password 'aaa' is valid? "+stringDigitChecker.Check("aaa") );
            Console.WriteLine("Password 'aA712asaas' is valid? " + stringDigitChecker.Check("aA712asas"));
        }
    }
}
