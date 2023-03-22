using E_Comm.Models;

namespace E_Comm.Constracts
{
    public interface IRepositoryProduct
    {
        public void create(Product product);
        
        public void update(Product product);

        public void delete(Product product);

        public Product getProductById(int? productId, bool trackChanges);
        public IEnumerable<Product> getAllProducts(string? SearchTerm,bool trackChanges);

    }
}
