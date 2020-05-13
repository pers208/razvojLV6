using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedmiZadatak
{
    class StringLowerCaseChecker:StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            for (int i = 0; i < stringToCheck.Length; i++)
            {
                if (char.IsLower(stringToCheck[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
