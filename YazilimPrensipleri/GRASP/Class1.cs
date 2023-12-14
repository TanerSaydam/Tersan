namespace GRASP;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class ShoppingCart
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CaclulateTotal()
    {
        return products.Sum(s => s.Price);
    }

    // Sepeti temsil eden diğer metotlar
}

public class Order
{
    public ShoppingCart Cart { get; set; }
    public string CustomerId { get; set; }

    public void PlaceOrder()
    {
        // Sipariş işleme ve onaylama kodlarını
    }

    // Siparişle ilgili başka işlemler
}

public class OrderController
{
    public void CreateOrder(ShoppingCart cart, string customerId)
    {
        Order order = new() { Cart = cart, CustomerId = customerId };
        order.PlaceOrder();
    }
}
