using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugiZadatak
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
