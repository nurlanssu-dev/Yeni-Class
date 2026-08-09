namespace Yeni.Class._09;

public class CartItem
{
    public Product Product;
    public int Quantity;

    public CartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
    public decimal GetTotalPrice()
    {
        return Product.Price * Quantity;
    }
}
