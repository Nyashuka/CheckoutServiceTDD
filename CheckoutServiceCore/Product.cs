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
        private readonly Category _category;

        public int Price => _price;
        public string Name => _name;
        public Category Category => _category;  

        public Product(int price, string name, Category category)
        {
            _price = price;
            _name = name;
            _category = category;
        }
    }
}
