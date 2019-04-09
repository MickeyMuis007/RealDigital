using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Domain.SeedWork
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetById(Guid id);
        Task Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
