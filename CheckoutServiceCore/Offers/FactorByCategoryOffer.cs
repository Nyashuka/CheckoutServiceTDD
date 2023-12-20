using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutServiceCore.Offers
{
    public class FactorByCategoryOffer : Offer
    {
        public readonly Category category;
        public readonly int factor;

        public FactorByCategoryOffer(Category category, int factor)
        {
            this.category = category;
            this.factor = factor;
        }

        public override int CalculatePoints(ICheck check)
        {
            int points = check.GetCostByCategory(category);
            return points * (factor - 1);
        }

        public override bool CheckCondition(ICheck check)
        {
            return check.GetCostByCategory(category) > 0;
        }
    }
}
