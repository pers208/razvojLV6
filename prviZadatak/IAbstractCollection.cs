using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prviZadatak
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
