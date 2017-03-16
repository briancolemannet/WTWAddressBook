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
        public List<Contact> Contacts { get; } = new List<Contact>();
    }
}
