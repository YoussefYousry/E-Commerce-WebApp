using E_Comm.Constracts;
using E_Comm.Models;
using E_Comm.Reposiotry;

namespace E_Comm.Reposiotry
{
    public class RepositoryManager : IRepositoryManager 
    {
        private RepositoryContext _repositoryContext;
        private IUsresRepository _usersRepository;
        private IRepositoryProduct _repositoryProduct;
        private IRepositoryOrders _repositoryOrders;
        private IRepositoryCart _repositoryCart;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            this._repositoryContext = repositoryContext; // inject DBContext into constructor
        }



        public void Save() => _repositoryContext.SaveChanges();
        public IUsresRepository Users
        {
            get
            {
                if (_usersRepository == null)
                {
                    _usersRepository = new UsersRepository(_repositoryContext);
                }
                return _usersRepository;
            }
        }


        public IRepositoryProduct Product
        {
            get
            {
                if (_repositoryProduct == null)
                {
                    _repositoryProduct = new RepositoryProduct(_repositoryContext);
                }
                return _repositoryProduct;
            }
        }

        public IRepositoryOrders Orders
        {
            get
            {
                if (_repositoryOrders == null)
                {
                    _repositoryOrders = new RepositoryOrders(_repositoryContext);
                }
                return _repositoryOrders;
            }
        }
        public IRepositoryCart Cart
        {
            get
            {
                if (_repositoryCart == null)
                {
                    _repositoryCart = new RepositoryCart(_repositoryContext);
                }
                return _repositoryCart;
            }
        }







    }
}
