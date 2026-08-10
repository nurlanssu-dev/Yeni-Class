namespace Yeni.Class._09;

public class EcommercePlatform
{
    public string PlatformName;
    public Product[] Products;
    public int ProductCount;
    public User[] Users;
    public int UserCount;

    public EcommercePlatform(string platformName)
    {
        PlatformName = platformName;
        Products = new Product[100];
        ProductCount = 0;
        Users = new User[100];
        UserCount = 0;
    }
    public void AddProduct(Product product)
    {
        if (ProductCount < Products.Length)
        {
            Products[ProductCount] = product;
            ProductCount++;
        }
        else
        {
            Console.WriteLine("Məhsul əlavə etmək üçün yer yoxdur.");
        }
    }
    public void RegisterUser(User user)
    {
        if (UserCount < Users.Length)
        {
            Users[UserCount] = user;
            UserCount++;
        }
        else
        {
            Console.WriteLine("İstifadəçi əlavə etmək üçün yer yoxdur.");
        }
    }
    public void ShowAllProducts()
    {
        for (int i = 0; i < ProductCount; i++)
        {
            Products[i].GetInfo();

        }
    }
    public void FilterByCategory(string category)
    {
        for (int i = 0; i < ProductCount; i++)
        {
            if (Products[i].Category == category)
            {
                Products[i].GetInfo();
            }
        }
    }
    public void GetOutOfStockProducts()
    {
        for (int i = 0; i < ProductCount; i++)
        {
            if (Products[i].StockQuantity == 0)
            {
                Console.WriteLine($"Anbarda yoxdur : {Products[i].Name}");
            }
        }
    }
    public string FindProductById(int id)
    {
        for (int i = 0; i < ProductCount; i++)
        {
            if (Products[i].Id == id)
            {
                return Products[i].Name;
            }
        }
        return "yoxdur";  
    }
}