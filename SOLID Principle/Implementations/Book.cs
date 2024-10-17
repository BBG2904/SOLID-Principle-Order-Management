using SOLID_Principle.Interfaces;

namespace SOLID_Principle.Implementations
{
    // Open For Extension and close for modification
    public class Book : IProduct
    {
        private readonly int _id;
        private readonly string _title;
        private readonly string _author;
        private readonly string _isbn;
        private int _price;

        public Book(int id, string title, string author, string isbn, int price)
        {
            _id = id;
            _title = title;
            _author = author;
            _isbn = isbn;
            _price = price;
        }

        public int Price { get => _price; }

        public void GetProductDetails()
        {
            Console.WriteLine($"View Book details like Id - {_id} , title - {_title}," +
                $" author -{_author}, isbn -{_isbn}, price - {_price}");
        }
    }
}
