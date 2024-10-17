using SOLID_Principle.Interfaces;

namespace SOLID_Principle.Implementations
{
    public class ShoppingCart : IShoppingCart
    {
        private List<IProduct> products = new List<IProduct>();
        //Liskov substitution principle
        public List<IProduct> ViewProductDetails()
        {
            foreach (var product in products)
            {
                product.GetProductDetails();
            }

            return products;
        }

        void IShoppingCart.AddProductDetails(IProduct product)
        {
            products.Add(product);
        }
    }
}
