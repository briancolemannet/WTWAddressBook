using AddressBook.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Domain.Entities;
using System.Data;

namespace AddressBook.Domain.Repositories
{
    public class ContactsRepository : IContactsRepository
    {
        private readonly DataContext _dataContext;

        public ContactsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Contact> GetAllContacts()
        {
            return _dataContext.Contacts;
        }

        public void AddContact(Contact contact)
        {
            contact.Id = _dataContext.GetNextContactId();
            _dataContext.Contacts.Add(contact);
        }

        public void UpdateContact(Contact contact)
        {
            var original = _dataContext.Contacts.Single(c => c.Id == contact.Id);

            original.Address = contact.Address;
            original.Email = contact.Email;
            original.Name = contact.Name;
            original.PhoneNumber = contact.PhoneNumber;
        }

        public Contact GetContact(int contactId)
        {
            var contact = _dataContext.Contacts.Single(c => c.Id == contactId);
            return contact;
        }
    }
}
