using CheckoutServiceCore;


namespace CheckoutServiceTests
{
    public class CheckoutServiceTest
    {
        private ICheckoutService _checkoutService = new CheckoutService();
        private Product _milk_7;
        private Product _bread_3;


        public CheckoutServiceTest()
        {
            _checkoutService.OpenCheck();
            _milk_7 = new Product(7, "Milk", Category.Dairy);
            _bread_3 = new Product(3, "Bread", Category.Bread);
        }

        [Fact]
        public void CloseCheck__WithOneProduct()
        {
            _checkoutService.AddProduct(_milk_7);
            ICheck check = _checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 7);
        }

        [Fact]
        public void CloseCheck__WithTwoProduct()
        {
            _checkoutService.AddProduct(_milk_7);
            _checkoutService.AddProduct(_bread_3);
            ICheck check = _checkoutService.CloseCheck();
            Assert.Equal(check.GetTotalCost(), 10);
        }

        [Fact]
        public void AddProduct__WhenCheckIsClosed__OpensNewCheck()
        {
            _checkoutService.AddProduct(_milk_7);
            ICheck milkCheck = _checkoutService.CloseCheck();
            Assert.Equal(milkCheck.GetTotalCost(), 7);

            _checkoutService.AddProduct(_bread_3);
            ICheck bredCheck = _checkoutService.CloseCheck();

            Assert.Equal(bredCheck.GetTotalCost(), 3);
        }

        [Fact]
        public void UseOffer__AddOfferPoints()
        {
            _checkoutService.AddProduct(_milk_7);
            _checkoutService.AddProduct(_bread_3);

            _checkoutService.AddOffer(new AnyGoodsOffer(6, 2));
            ICheck check = _checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalPoints(), 12);
        }

        [Fact]
        public void UseOffer__WhenCostLessThanRequired__DoNothing()
        {
            _checkoutService.AddProduct(_bread_3);

            _checkoutService.AddOffer(new AnyGoodsOffer(6, 2));
            ICheck check = _checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalPoints(), 3);
        }

        [Fact]
        public void UseOffer__FactorByCategory()
        {
            _checkoutService.AddProduct(_milk_7);
            _checkoutService.AddProduct(_milk_7);
            _checkoutService.AddProduct(_bread_3);

            _checkoutService.AddOffer(new FactorByCategoryOffer(Category.Dairy, 3));
            ICheck check = _checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalPoints(), 45);
        }

        [Fact]
        public void UseOffer__BeforeCloseCheck()
        {

            _checkoutService.AddProduct(_milk_7);
            _checkoutService.AddOffer(new FactorByCategoryOffer(Category.Dairy, 3));
            _checkoutService.AddProduct(_milk_7);
            _checkoutService.AddProduct(_bread_3);

            ICheck check = _checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalPoints(), 45);
        }

        [Fact]
        public void UseOffer__WithChangeDate()
        {
            _checkoutService.AddProduct(_milk_7);

            Offer offer = new FactorByCategoryOffer(Category.Dairy, 3);
            offer.ChangeExpiration(DateTime.Now.AddDays(-1));

            _checkoutService.AddOffer(offer);
            ICheck check = _checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalPoints(), 7);
        }

        [Fact]
        public void UseOffer__WithoutChangeDate()
        {
            _checkoutService.AddProduct(_milk_7);

            Offer offer = new FactorByCategoryOffer(Category.Dairy, 3);

            _checkoutService.AddOffer(offer);
            ICheck check = _checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalPoints(), 21);
        }
    }
}