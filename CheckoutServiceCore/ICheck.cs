using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutServiceCore.Offers;

namespace CheckoutServiceCore
{
    public interface ICheck
    {
        int GetTotalCost();
        void AddProduct(Product product);
        void AddOffer(Offer offer);
        void UseOffers(ICheck check);
        void AddPoints(int points);
        int GetCostByCategory(Category category);
    }
}
