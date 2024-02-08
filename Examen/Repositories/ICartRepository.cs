namespace Examen.Repositories
{
    public interface ICartRepository
    {
        Task<int> AddItem(int PhoneId, int qty);
        Task<int> RemoveItem(int PhoneId);
        Task<ShoppingCart> GetUserCart();
        Task<int> GetCartItemCount(string userId = "");
        Task<ShoppingCart> GetCart(string userId);
        Task<bool> DoCheckout();
    }
}
