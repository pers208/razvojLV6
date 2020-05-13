using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedmiZadatak
{
    class StringUpperCaseChecker:StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            for (int i = 0; i < stringToCheck.Length; i++)
            {
                if (char.IsUpper(stringToCheck[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
