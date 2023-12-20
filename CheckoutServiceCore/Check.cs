using System;
using CheckoutServiceCore.Offers;

namespace CheckoutServiceCore
{
    public class Check : ICheck
    {
        private List<Product> _products = new List<Product>();
        private List<Offer> offers = new List<Offer>();

        private int _points;

        public void AddOffer(Offer offer)
        {
            offers.Add(offer);
        }

        public void AddPoints(int points)
        {
             _points = points;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public int GetCostByCategory(Category category)
        {
            return _products.Where(x => x.Category == category).Sum(x => x.Price);
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

        public int GetTotalPoints()
        {
            return GetTotalCost() + _points;
        }

        public void UseOffers(ICheck check)
        {
            foreach (var offer in offers)
                offer.Apply(check);
        }
    }
}
