using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Domain.Entities;

namespace AddressBook.Domain.Repositories
{
    public interface IContactsRepository
    {
        List<Contact> GetAllContacts();
    }
}
