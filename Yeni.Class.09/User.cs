namespace Yeni.Class._09;

public class User
{
    public int Id;
    public string FullName;
    public decimal Balance;
    public Cart[] Cart;
    public bool IsVIP;

    public User(int id, string fullName, decimal balance, bool isVIP)
    {
        Id = id;
        FullName = fullName;
        Balance = balance;
        IsVIP = isVIP;
        Cart = new Cart[5];
    }
    public void DepositBalance(decimal amount)
    {
        Balance += amount;
    }
    public void Checkout()
    {
        decimal totalAmount = 0;
        for (int i = 0; i < Cart.Length; i++)
        {
            if (Cart[i] != null)
            {
                totalAmount += Cart[i].CalculateTotal();
            }
        }
        if (IsVIP)
        {
            totalAmount -= totalAmount * 0.05m;
        }
        if (Balance >= totalAmount)
        {
            Balance -= totalAmount;
            Console.WriteLine($"Ödəniş uğurla həyata keçirildi. Qalıq balans: {Balance}");
            for (int i = 0; i < Cart.Length; i++)
            {
                Cart[i] = null;
            }
        }
        else
        {
            Console.WriteLine("Balansınız ödənişi həyata keçirmək üçün kifayət deyil.");
        }
    }

}
