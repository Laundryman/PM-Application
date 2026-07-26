using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace PMApplication.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        Task<int> SaveChangesAsync();
        Task SaveAndCommitAsync();
    }
}
