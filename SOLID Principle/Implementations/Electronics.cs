using SOLID_Principle.Interfaces;

namespace SOLID_Principle.Implementations
{
    // Open For Extension and close for modification
    public class Electronics : IProduct
    {
        public int _Id;
        public string _ElectronicsName;
        public string _BrandName;
        private int _price;
        public Electronics(int Id, string ElectronicsName, string BrandName, int price)
        {
            _Id = Id;
            _ElectronicsName = ElectronicsName;
            _BrandName = BrandName;
            _price = price;
        }
        public int Price { get => _price; }
        public void GetProductDetails()
        {
            Console.WriteLine($"View Electronic product details like Id - {_Id},  " +
                $"name - {_ElectronicsName}, brand name - {_BrandName}, price - {_price}");
        }
    }
}
