using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MIS.Data.Interfaces;
using System.Linq.Expressions;

namespace MIS.Data.Repositories
{
    public class MisRepository : IMisRepository
    {
        // CREATE, UPDATE, DELETE
        public Task<Guid> CreateAsync<T>(T entity, CancellationToken cancellationToken = default) where T : class, IEntity
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync<T>(T entity, CancellationToken cancellationToken = default) where T : class, IEntity
        {
            throw new NotImplementedException();

        }

        public Task DeleteAsync<T>(Guid id, CancellationToken cancellationToken = default) where T : class, IEntity
        {
            throw new NotImplementedException();
        }

        // SEARCH
        public Task<T> FindByIdAsync<T>(Guid id, CancellationToken cancellationToken = default) where T : class, IEntity
        {
            throw new NotImplementedException();
        }

        public Task<T> SingleAsync<T>(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default) where T : class, IEntity
        {
            throw new NotImplementedException();
        }

        public Task<T?> FirstOrDefaultAsync<T>(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default) where T : class, IEntity
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync<T>(Expression<Func<T, bool>>? expression = null, CancellationToken cancellationToken = default) where T : class, IEntity
        {
            throw new NotImplementedException();
        }

        // OTHER
        public Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void ChangeTracker(QueryTrackingBehavior queryTrackingBehavior)
        {
            throw new NotImplementedException();
        }

        public void ChangeEntryState<T>(T entity, EntityState entityState = EntityState.Unchanged) where T : class, IEntity
        {
            throw new NotImplementedException();
        }

        public Task<IDbContextTransaction> BeginTransactionAsync()
        {
            throw new NotImplementedException();
        }
    }
}
