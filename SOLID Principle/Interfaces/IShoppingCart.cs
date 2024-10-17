namespace SOLID_Principle.Interfaces
{
    public interface IShoppingCart
    {
        void AddProductDetails(IProduct product);

        List<IProduct> ViewProductDetails();
    }
}
