namespace SOLID_Principle.Interfaces
{
    //Single Responsibility Principle
    public interface IProduct
    {
        public void GetProductDetails();

        public int Price { get; }
    }
}
