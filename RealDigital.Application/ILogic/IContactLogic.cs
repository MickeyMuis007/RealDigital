using RealDigital.Application.Models;
using RealDigital.Application.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Application.ILogic
{
    public interface IContactLogic
    {
        Task<IEnumerable<ContactViewModel>> GetAllAsync();
        Task<ContactViewModel> GetById(Guid contactId);
        Task<ContactViewModel> Insert(ContactModel contactModel);
        Task Update(Guid id, ContactModel contactModel);
        Task Delete(Guid contactId);
    }
}
