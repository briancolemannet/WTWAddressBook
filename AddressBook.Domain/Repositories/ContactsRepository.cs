using AddressBook.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Domain.Entities;

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
    }
}
