using E_Comm.Models;

namespace E_Comm.Constracts
{
    public interface IRepositoryOrders
    {
        public IEnumerable<Orders> getAllOrders(bool trackChanges);
        public Orders getOrderById(int? id, bool trackChanges);
        
        void CreateOrder(Orders order);


    }
}
