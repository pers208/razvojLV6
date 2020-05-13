using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Product shirt = new Product("100% cotton", 100);
            Product videoGame = new Product("PG-13", 300);
            Product shoes = new Product("yeezy", 10000);
            Box box = new Box();
            box.AddProduct(shirt);
            box.AddProduct(videoGame);
            box.AddProduct(shoes);
            IAbstractIterator iterator = box.GetIterator();
            for (Product product = iterator.First(); iterator.IsDone == false; product= iterator.Next())
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
