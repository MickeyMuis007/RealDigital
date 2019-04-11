using AutoMapper;
using RealDigital.Application.Errors;
using RealDigital.Application.ILogic;
using RealDigital.Application.Models;
using RealDigital.Application.Models.ViewModels;
using RealDigital.Domain.AggregateModels.ContactAggregate;
using RealDigital.Domain.AggregateModels.ContactAggregate.Builders;
using RealDigital.Domain.AggregateModels.ContactAggregate.Builders.Impl;
using RealDigital.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Infrastructure.Implementations.Logics
{
    public class ContactLogic : IContactLogic
    {
        #region Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion Fields

        #region Constructors

        public ContactLogic(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion Constructors
        public async Task<IEnumerable<ContactViewModel>> GetAllAsync()
        {
            IEnumerable<Contact> contacts = await _unitOfWork.ContactRepository.GetAllAsync();
            var contactViewModels = _mapper.Map<IEnumerable<ContactViewModel>>(contacts);
            return contactViewModels.OrderBy(t => t.FirstName);
        }

        public async Task<ContactViewModel> GetById(Guid contactId)
        {
            Contact contact = await _unitOfWork.ContactRepository.GetById(contactId);
            if (contact == null)
                throw new RecordNotFound(contactId);

            var contactViewModel = _mapper.Map<ContactViewModel>(contact);
            return contactViewModel;
        }

        public async Task<ContactViewModel> Insert(ContactModel contactModel)
        {
            var contact = _mapper.Map<Contact>(contactModel);            
            await _unitOfWork.ContactRepository.Insert(contact);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<ContactViewModel>(contact);
        }

        public async Task Update(Guid contactId, ContactModel contactModel)
        {
            Contact contact = await _unitOfWork.ContactRepository.GetById(contactId);
            if (contact == null)
                throw new RecordNotFound(contactId);

            _mapper.Map(contactModel, contact);
            _unitOfWork.ContactRepository.Update(contact);
            await _unitOfWork.SaveAsync();
        }
        public async Task Delete(Guid contactId)
        {
            Contact contact = await _unitOfWork.ContactRepository.GetById(contactId);
            if (contact == null)
                throw new RecordNotFound(contactId);

            _unitOfWork.ContactRepository.Delete(contact);
            await _unitOfWork.SaveAsync();
        }
    }
}
