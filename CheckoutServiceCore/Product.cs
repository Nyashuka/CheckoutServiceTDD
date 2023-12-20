using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutServiceCore
{
    public class Product
    {
        private readonly int _price;
        private readonly string _name;

        public int Price => _price;
        public string Name => _name;

        public Product(int price, string name)
        {
            _price = price;
            _name = name;
        }
    }
}
