namespace SOLID_Principle.Interfaces
{
    //Interface Segregation principle
    public interface ICheckoutService
    {
        int ApplyDiscountOnProduct(List<IProduct> products);
        void ProcessPayment(int price);
    }
}
