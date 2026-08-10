namespace Yeni.Class._09;

public class Cart
{
    public CartItem[] Items;
    public int ItemCount;
    public string PromoCode;
    public decimal DiscountPercentage;

    public Cart()
    {
        Items = new CartItem[20];
        ItemCount = 0;
        PromoCode = "";
        DiscountPercentage = 0;
    }
    public void AddToCart(Product product, int quantity)
    {
        if (ItemCount >= Items.Length)
        {
            Console.WriteLine("Səbət doludur. Daha çox məhsul əlavə edə bilməzsiniz.");
            return;
        }
        if (!product.HasEnoughStock(quantity))
        {
            Console.WriteLine($"Stockda {quantity} Sayda {product.Name} Məhsul Yoxdur");
            return;
        }
        CartItem newItem = new CartItem(product, quantity);
        Items[ItemCount] = newItem;
        ItemCount++;
        product.DecreaseStock(quantity);
    }
    public void RemoveFromCart(int productId)
    {
        for (int i = 0; i < ItemCount; i++)
        {
            if (Items[i].Product.Id == productId)
            {
                Items[i].Product.IncreaseStock(Items[i].Quantity);
                for (int j = i; j < ItemCount - 1; j++)
                {
                    Items[j] = Items[j + 1];

                }
                ItemCount--;
                Items[ItemCount] = null;
                break;
            }
        }
    }
    public void ApplyPromoCode(string code, decimal discount)
    {
        if (code == "SAVE10")
        {
            DiscountPercentage = discount;
        }
    }
    public decimal CalculateTotal()
    {
        decimal total = 0;
        for (int i = 0; i < ItemCount; i++)
        {
            total += Items[i].GetTotalPrice();
        }
        if (DiscountPercentage != 0)
        {
            total -= total * DiscountPercentage / 100;
        }
        return total;
    }
    public void ShowCart()
    {
        for (int i = 0; i < ItemCount; i++)
        {
            Console.WriteLine(Items[i].Product.Name);
            Console.WriteLine(Items[i].Quantity);
            Console.WriteLine(Items[i].GetTotalPrice());
        }
        Console.WriteLine($"Ümumi: {CalculateTotal()}");
    }
    public void ClearCart()
    {
        for (int i = 0; i < ItemCount; i++)
        {
            Items[i] = null;
        }

        ItemCount = 0;
    }
}
