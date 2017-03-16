using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Domain.Entities;
using AddressBook.Domain.Repositories;

namespace AddressBook.Domain.Services
{
    public class ContactsService
    {
        private readonly IContactsRepository _contactsRepository;

        public ContactsService(IContactsRepository contactsRepository)
        {
            _contactsRepository = contactsRepository;
        }
        public List<Contact> GetAllContacts()
        {
            var contacts = _contactsRepository.GetAllContacts();
            return contacts;
        }
    }
}
