using RealDigital.Application.ILogic;
using RealDigital.Application.Models;
using RealDigital.Application.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Infrastructure.Implementations.Logics
{
    public class ContactLogic : IContactLogic
    {
        public Task<IEnumerable<ContactViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ContactViewModel> GetById(int contactId)
        {
            throw new NotImplementedException();
        }

        public Task<ContactViewModel> Insert(ContactModel contactModel)
        {
            throw new NotImplementedException();
        }

        public Task Update(ContactModel contactModel)
        {
            throw new NotImplementedException();
        }
        public Task Delete(int contactId)
        {
            throw new NotImplementedException();
        }

    }
}
