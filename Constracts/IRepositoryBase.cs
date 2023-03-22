using System.Linq.Expressions;

namespace E_Comm.Constracts
{
    public interface IRepositoryBase<T> // where <T> is a class 
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChnages); // LINQ EXPRESSION
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
