using E_Comm.Constracts;
using E_Comm.Models;

namespace E_Comm.Reposiotry
{
    public class RepositoryOrders : RepositoryBase<Orders>, IRepositoryOrders
    {
        public RepositoryOrders(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {
        }

        public IEnumerable<Orders> getAllOrders(bool trackChanges)
          => FindAll(trackChanges).OrderBy(o => o.Id).ToList();

        public Orders getOrderById(int? id, bool trackChanges)
          => FindByCondition(o => o.Id == id, trackChanges).FirstOrDefault();

        public void CreateOrder(Orders order)
            => Create(order);

    }
}
