using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutServiceCore.Offers;

namespace CheckoutServiceCore
{
    public interface ICheckoutService
    {
        void OpenCheck();
        void AddProduct(Product product);
        void AddOffer(Offer offer);
        ICheck CloseCheck();
        ICheck GetCheck();
    }
}
