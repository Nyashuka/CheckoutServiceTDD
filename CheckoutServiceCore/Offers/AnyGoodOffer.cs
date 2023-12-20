namespace CheckoutServiceCore.Offers
{
    public class AnyGoodsOffer : Offer
    {
        public readonly int _necessaryTotalCost;
        public readonly int _points;

        public AnyGoodsOffer(int necessaryTotalCost, int points)
        {
            _necessaryTotalCost = necessaryTotalCost;
            _points = points;
        }


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
