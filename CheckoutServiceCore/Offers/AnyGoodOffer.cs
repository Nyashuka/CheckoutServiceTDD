using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutServiceCore.Offers
{
    public class AnyGoodOffer : Offer
    {
        public override int CalculatePoints(ICheck check)
        {
            throw new NotImplementedException();
        }

        public override bool CheckCondition(ICheck check)
        {
            throw new NotImplementedException();
        }
    }
}
