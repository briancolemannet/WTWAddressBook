using AddressBook.Domain.Entities;
using AddressBook.Web.Models;
using AutoMapper;

namespace AddressBook.Web.Infrastructure
{
    public class ContactMapperProfile : Profile
    {
        public ContactMapperProfile()
        {
            CreateMap<Contact, ContactApiModel>().ReverseMap();
            CreateMap<AddContactRequestModel, Contact>();
            CreateMap<UpdateContactRequestModel, Contact>();
        }
    }
}