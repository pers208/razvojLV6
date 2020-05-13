using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cetvrtiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Jozo", "sjenjak 42", 100m);
            BankAccount account2 = new BankAccount("Bozo", "sjenjak 43", 1000m);
            BankAccount account3 = new BankAccount("Zvonko", "sjenjak 44", 10000m);

            Memento account1Memento = account1.StoreState();
            Memento account2Memento = account2.StoreState();
            Memento account3Memento = account3.StoreState();

            List<Memento> bank = new List<Memento>();
            bank.Add(account1Memento);
            bank.Add(account2Memento);
            bank.Add(account3Memento);

            Console.WriteLine("before storing: ");
            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);

            Console.WriteLine("after restoring: ");
            account3.RestoreState(bank.ElementAt(0));
            account2.RestoreState(bank.ElementAt(1));
            account1.RestoreState(bank.ElementAt(2));
            Console.WriteLine(account3);
            Console.WriteLine(account2);
            Console.WriteLine(account1);


            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);
        }
    }
}
