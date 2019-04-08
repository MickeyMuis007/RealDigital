using RealDigital.Domain.AggregateModels.ContactAggregate.Builders;
using RealDigital.Domain.AggregateModels.ContactAggregate.Builders.Impl;
using RealDigital.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Domain.AggregateModels.ContactAggregate
{
    public class Contact : IAggregateRoot
    {
        #region Properties

        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNo { get; private set; }
        public string Email { get; private set; }

        #endregion Properties

        #region Constructors

        //Required for EF
        private Contact()
        {

        }

        public Contact(ContactBuilder builder)
        {
            Id = builder.Id;
            FirstName = builder.FirstName;
            LastName = builder.LastName;
            PhoneNo = builder.PhoneNo;
            Email = builder.Email;
        }

        #endregion Constructors
    }

    public class test
    {
        public test()
        {
            BuilderFactory<ContactBuilder, Contact>.Create();
        }
    }
}
