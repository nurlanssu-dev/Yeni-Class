namespace Yeni.Class._09;

public class Product
{
    public int Id;
    public string Name;
    public decimal Price;
    public int StockQuantity;
    public string Category;

    public Product(int id, string name, decimal price, string category , int stockQuantity = 10 )
    {
        Id = id;
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
        Category = category;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Product ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Stock Quantity: {StockQuantity}");
        Console.WriteLine($"Category: {Category}");
    }

    public void DecreaseStock(int amount)
    {
        if (StockQuantity < amount)
        {
            Console.WriteLine($"Stockda {amount} Sayda {Name} Məhsul Yoxdur");
        }
        else
        {
            StockQuantity -= amount;
        }
    }
    public void IncreaseStock(int amount)
    {
        StockQuantity += amount;
    }
    public bool HasEnoughStock(int requiredAmount)
    {
        if (StockQuantity >= requiredAmount)
        {
            return true;
        }
        return false;
    }

}
