using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutServiceCore.Offers;

namespace CheckoutServiceCore
{
    public class CheckoutService : ICheckoutService
    {
        private ICheck _check;

        public void AddOffer(Offer offer)
        {
            _check.AddOffer(offer);
        }

        public void AddProduct(Product product)
        {
            if (_check == null)
            {
                OpenCheck();
            }

            _check.AddProduct(product);
        }

        public ICheck CloseCheck()
        {
            _check.UseOffers(_check);

            ICheck closedCheck = _check;
            _check = null;

            return closedCheck;
        }

        public ICheck GetCheck()
        {
            return _check;
        }

        public void OpenCheck()
        {
            _check = new Check();
        }
    }
}
