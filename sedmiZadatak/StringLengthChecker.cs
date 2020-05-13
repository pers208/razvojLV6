using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedmiZadatak
{
    class StringLengthChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Length >= 8;
        }
    }
}
