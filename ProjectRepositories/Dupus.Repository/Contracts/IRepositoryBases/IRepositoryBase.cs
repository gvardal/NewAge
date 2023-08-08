using System.Linq.Expressions;

namespace Dupus.Repository.Contracts.IRepositoryBases
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll(bool trackChanges);
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
