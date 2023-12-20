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
            return _points;
        }

        public override bool CheckCondition(ICheck check)
        {
            return _necessaryTotalCost <= check.GetTotalCost();
        }
    }
}
