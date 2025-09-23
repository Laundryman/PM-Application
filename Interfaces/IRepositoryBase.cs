using System.Linq.Expressions;

namespace PMApplication.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);

        //Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec, CancellationToken cancellationToken = default);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
