using AddressBook.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Domain.Repositories
{
    public class ContactsRepository : IContactsRepository
    {
        private readonly DataContext _dataContext;

        public ContactsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

    }
}
