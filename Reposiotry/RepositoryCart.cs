using E_Comm.Constracts;
using E_Comm.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Comm.Reposiotry
{
    public class RepositoryCart : RepositoryBase<Cart> , IRepositoryCart 
    {
        private readonly RepositoryContext _context;
        public RepositoryCart(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
            _context = repositoryContext;
        }
        

        public void CreateCartItemToCart(CartItem cartItem)
        {  
            _context.Set<CartItem>().Add(cartItem);
            _context.SaveChanges();      
        }
        public IEnumerable<CartItem> getAllCartsItems(bool trackChanges)
        {    
            var cartItems = _context.CartItemsTable.AsNoTracking().ToList();
            return cartItems;
        }

        public void DeleteItem(CartItem cartItem)
        {
            _context.CartItemsTable.Remove(cartItem);
        }
        public CartItem GetCartITemById(int id)
        {
            var caritem = _context.CartItemsTable.AsNoTracking().FirstOrDefault(e => e.Id == id);
            return caritem;
        }



    }
}
