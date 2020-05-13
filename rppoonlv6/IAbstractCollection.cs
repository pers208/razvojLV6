using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoonlv6
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
