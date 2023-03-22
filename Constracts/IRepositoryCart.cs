using E_Comm.Models;

namespace E_Comm.Constracts
{
    public interface IRepositoryCart
    {
        void CreateCartItemToCart(CartItem cartItem);
        public IEnumerable<CartItem> getAllCartsItems(bool trackChanges);

        public void DeleteItem(CartItem cartItem);

        public CartItem GetCartITemById(int id);


    }
}
