using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Domain.AggregateModels.ContactAggregate.Builders.Impl
{
    public class ContactBuilder : IContactBuilder<ContactBuilder, Contact>
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNo { get; private set; }
        public string Email { get; private set; }

        public ContactBuilder SetId (Guid id)
        {
            Id = id;
            return this;
        }

        public ContactBuilder SetFirstName(string firstName)
        {
            FirstName = firstName;
            return this;
        }

        public ContactBuilder SetLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }

        public ContactBuilder SetPhoneNo(string phoneNo)
        {
            PhoneNo = phoneNo;
            return this;
        }

        public ContactBuilder SetEmail(string email)
        {
            Email = email;
            return this;
        }

        public ContactBuilder Copy(Contact contact)
        {
            Id = contact.Id;
            FirstName = contact.FirstName;
            LastName = contact.LastName;
            PhoneNo = contact.PhoneNo;
            Email = contact.Email;
            return this;
        }        

        public ContactBuilder Set()
        {
            return this;
        }

        public Contact Build()
        {
            return new Contact(this);
        }
    }   
}
