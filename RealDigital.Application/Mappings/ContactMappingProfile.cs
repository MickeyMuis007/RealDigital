using AutoMapper;
using RealDigital.Application.Models;
using RealDigital.Application.Models.ViewModels;
using RealDigital.Domain.AggregateModels.ContactAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Application.Mappings
{
    public class ContactMappingProfile : Profile
    {
        public ContactMappingProfile()
        {
            CreateMap<ContactModel, Contact>();
            CreateMap<Contact, ContactViewModel>();
        }
    }
}
