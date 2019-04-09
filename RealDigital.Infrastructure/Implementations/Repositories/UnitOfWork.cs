using RealDigital.Domain.AggregateModels.ContactAggregate;
using RealDigital.Domain.SeedWork;
using RealDigital.Infrastructure.Implementations.Repositories.ContactRepo;
using RealDigital.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Infrastructure.Implementations.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields

        private readonly RealDigitalContext _context;
        private IContactRepository _contactRepository;
        #endregion Fields

        #region Properties

        public IContactRepository ContactRepository {
            get
            {
                return _contactRepository = _contactRepository ?? new ContactRepository(_context);
            }
        }

        #endregion Properties

        #region Constructors 

        public UnitOfWork(RealDigitalContext context)
        {
            _context = context;
        }

        #endregion Constructors

        #region Methods

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        #endregion Methods
    }
}
