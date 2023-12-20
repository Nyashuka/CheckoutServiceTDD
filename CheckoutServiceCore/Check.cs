using System;

namespace CheckoutServiceCore
{
    public class Check : ICheck
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public int GetTotalCost()
        {
            int totalCost = 0;

            foreach (Product product in _products)
            {
                totalCost += product.Price;
            }

            return totalCost;
        }
    }
}
