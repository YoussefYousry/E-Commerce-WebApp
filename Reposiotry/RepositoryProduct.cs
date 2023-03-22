using E_Comm.Constracts;
using E_Comm.Models;

namespace E_Comm.Reposiotry
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        public RepositoryProduct(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public void create(Product product)
        {
            Create(product);
        }

        public void delete(Product product)
        {
            Delete(product);
        }

        public void update(Product product)
        {
            Update(product);
        }
        public Product getProductById(int? productId, bool trackChanges)
            => FindByCondition(p => p.Id.Equals(productId), trackChanges).FirstOrDefault();
        public IEnumerable<Product> getAllProducts(string? SearchTerm, bool trackChanges)
        {
            var products = FindAll(trackChanges).OrderBy(p => p.Id).ToList();

            if (string.IsNullOrWhiteSpace(SearchTerm))
                return products;
            var lowerCaseTerm = SearchTerm.Trim().ToLower();

            return products.Where(e => e.Name!.ToLower().Contains(lowerCaseTerm));


        }

        //public void CreateProductToCart(int cartId, Product product)
        //    => reate()

    }
}
