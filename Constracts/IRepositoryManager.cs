using E_Comm.Constracts;


namespace E_Comm.Constracts
{
    public interface IRepositoryManager
    {
        IUsresRepository Users { get; }
        IRepositoryProduct Product { get; }
        IRepositoryOrders Orders { get; }
        IRepositoryCart Cart { get; }

        void Save();
    }
}
