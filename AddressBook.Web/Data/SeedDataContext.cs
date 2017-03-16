using AddressBook.Domain.Data;
using AddressBook.Domain.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Web.Data
{
    public static class SeedDataContext
    {

        public static void Seed(DataContext dataContext)
        {
            if (dataContext.Contacts.Any())
            {
                return;
            }

            var strContacts = File.ReadAllText(@"data\contacts.json");
            var jobj = JObject.Parse(strContacts);
            dataContext.Contacts.AddRange(jobj.GetValue("contacts").ToObject<List<Contact>>());
        }
    }
}
