// See https://aka.ms/new-console-template for more information
using SOLID_Principle.Implementations;
using SOLID_Principle.Interfaces;

IProduct radio = new Electronics(1, "Radio", "XBrand", 2000);
IProduct book = new Book(2, "Chemistry", "XAuthor", "12345", 1000);
IShoppingCart cart = new ShoppingCart();
cart.AddProductDetails(radio);
cart.AddProductDetails(book);
var products = cart.ViewProductDetails();
IDiscountService service = new DiscountService(5);
ICheckoutService checkoutService = new CheckoutService(service);
var totalPrice = checkoutService.ApplyDiscountOnProduct(products);
checkoutService.ProcessPayment(totalPrice);
