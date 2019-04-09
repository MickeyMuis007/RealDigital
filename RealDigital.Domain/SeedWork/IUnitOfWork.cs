using RealDigital.Domain.AggregateModels.ContactAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Domain.SeedWork
{
    public interface IUnitOfWork
    {
        IContactRepository ContactRepository { get; }
    }
}
