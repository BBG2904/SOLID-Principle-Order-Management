using SOLID_Principle.Interfaces;

namespace SOLID_Principle.Implementations
{
    public class CheckoutService : ICheckoutService
    {
        private readonly IDiscountService discountService;
        //Dependency Inversion principle
        public CheckoutService(IDiscountService discountService)
        {
            this.discountService = discountService;
        }

        public int ApplyDiscountOnProduct(List<IProduct> products)
        {
            int totalPriceAfterDiscount = 0;

            foreach (var product in products)
            {
                totalPriceAfterDiscount += discountService.ApplyDiscount(product.Price);
                
            }
            Console.WriteLine($"Shopping cart value after applying discount:{totalPriceAfterDiscount}");
            return totalPriceAfterDiscount;
        }

        public void ProcessPayment(int price)
        {
            Console.WriteLine($"Rs. {price} Paid Successfully");
        }
    }
}
