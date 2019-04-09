using Microsoft.EntityFrameworkCore;
using RealDigital.Domain.SeedWork;
using RealDigital.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Infrastructure.Implementations.Repositories
{
    public abstract class Repository<TRootEntity> : IRepository<TRootEntity> where TRootEntity : class, IAggregateRoot
    {
        #region Fields

        private readonly RealDigitalContext _context;

        #endregion Fields

        #region Contstructors

        public Repository(RealDigitalContext context)
        {
            _context = context;
        }

        #endregion Contstrutors

        #region Methods

        public async Task<IEnumerable<TRootEntity>> GetAllAsync()
        {
            return await _context.Set<TRootEntity>().ToListAsync();
        }

        public async Task<TRootEntity> GetById(Guid id)
        {
            return await _context.FindAsync<TRootEntity>(id);
        }

        public async Task Insert(TRootEntity entity)
        {
            await _context.AddAsync(entity);
        }

        public void Update(TRootEntity entity)
        {
            _context.Update(entity);
        }
        public void Delete(TRootEntity entity)
        {
            _context.Remove(entity);
        }

        #endregion Methods
    }
}
