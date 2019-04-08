using RealDigital.Domain.AggregateModels.ContactAggregate;
using RealDigital.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Infrastructure.Implementations.Repositories.ContactRepo
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(RealDigitalContext context) : base(context)
        {

        }
    }
}
