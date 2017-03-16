using AddressBook.Domain.Repositories;
using AddressBook.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Web.Controllers
{
    [Route("api/contacts")]
    public class ContactsController : Controller
    {
        private readonly ContactsService _contactsService;

        public ContactsController(ContactsService contactsService)
        {
            _contactsService = contactsService;
        }

        [HttpGet("")]
        public IActionResult GetContacts()
        {
            var contacts = _contactsService.GetAllContacts();
            return Ok(new { contacts });
        }

        [HttpPost("")]
        public IActionResult AddContact()
        {
            throw new NotImplementedException();
        }

        [HttpPost("{contactId}")]
        public IActionResult UpdateContact()
        {
            throw new NotImplementedException();
        }

    }
}
