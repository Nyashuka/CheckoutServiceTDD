using System;
using CheckoutServiceCore.Offers;

namespace CheckoutServiceCore
{
    public class Check : ICheck
    {
        private List<Product> _products = new List<Product>();

        public void AddOffer(Offer offer)
        {
            throw new NotImplementedException();
        }

        public void AddPoints(int points)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public int GetCostByCategory(Category category)
        {
            throw new NotImplementedException();
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

        public void UseOffers(ICheck check)
        {
            throw new NotImplementedException();
        }
    }
}
