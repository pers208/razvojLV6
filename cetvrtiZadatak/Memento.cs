using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cetvrtiZadatak
{
    class Memento
    {
        public string OwnerName { get; private set; }
        public string OwnerAddress { get; private set; }
        public decimal Balance { get; private set; }
        public Memento(string ownerName, string ownerAddress, decimal balance)
        {
            this.OwnerAddress = ownerAddress;
            this.OwnerName = ownerName;
            this.Balance = balance;
        }
    }
}
