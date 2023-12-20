using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutServiceCore
{
    public interface ICheckoutService
    {
        void OpenCheck();
        void AddProduct(Product product);
        Check CloseCheck();
        Check GetCheck();
    }
}
