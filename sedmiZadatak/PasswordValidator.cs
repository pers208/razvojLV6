using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedmiZadatak
{
    class PasswordValidator
    {   private StringChecker first;
        private StringChecker last;
        public PasswordValidator(StringDigitChecker stringDigitChecker)
        {
            this.first = stringDigitChecker;
            this.last = stringDigitChecker;
            this.first.SetNext(null);
        }
        public void AddNext(StringChecker stringChecker)
        {
            this.last.SetNext(stringChecker);
            this.last = stringChecker;
        }
        public bool CheckValidation(string password)
        {
            return first.Check(password);
        }
    }
}
