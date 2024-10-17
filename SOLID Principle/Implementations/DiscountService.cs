using SOLID_Principle.Interfaces;

namespace SOLID_Principle.Implementations
{
    public class DiscountService : IDiscountService
    {
        private readonly int percentage;

        public DiscountService(int percentage)
        {
            this.percentage = percentage;
        }

        public int ApplyDiscount(int price)
        {
            return price - (price * percentage / 100);
        }
    }
}
