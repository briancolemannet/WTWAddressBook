using AddressBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Domain.Data
{
    public class DataContext
    {
        private int _maxId;
        private readonly object _currentIdLockObject = new object();

        public List<Contact> Contacts { get; } = new List<Contact>();

        public int GetNextContactId()
        {
            lock (_currentIdLockObject)
            {
                if (_maxId == 0)
                {
                    _maxId = Contacts.Max(c => c.Id);
                }
                return ++_maxId;
            }
        }
    }
}
