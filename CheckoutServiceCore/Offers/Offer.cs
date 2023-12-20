namespace CheckoutServiceCore.Offers
{
    public abstract class Offer
    {
        private DateTime expiration = DateTime.Now.AddYears(1);

        public void Apply(ICheck check)
        {
            if (CheckCondition(check) && CheckExpiration())
                check.AddPoints(CalculatePoints(check));
        }

        public void ChangeExpiration(DateTime expiration)
        {
            this.expiration = expiration;
        }


        private bool CheckExpiration()
        {
            return expiration > DateTime.Now;
        }

        public abstract int CalculatePoints(ICheck check);


        public abstract bool CheckCondition(ICheck check);
    }
}
