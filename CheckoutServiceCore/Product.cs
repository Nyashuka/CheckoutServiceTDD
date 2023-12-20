using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutServiceCore
{
    public class Product
    {
        public readonly int _price;
        public readonly string _name;

        public Product(int price, string name)
        {
            _price = price;
            _name = name;
        }
    }
}
