using AddressBook.Domain.Repositories;
using AddressBook.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Domain.Entities;
using AddressBook.Web.Models;
using AutoMapper;

namespace AddressBook.Web.Controllers
{
    [Route("api/contacts")]
    public class ContactsController : Controller
    {
        private readonly ContactsService _contactsService;
        private readonly IMapper _mapper;

        public ContactsController(ContactsService contactsService, IMapper mapper)
        {
            _contactsService = contactsService;
            _mapper = mapper;
        }

        [HttpGet("{contactId}")]
        public IActionResult GetContact(int contactId)
        {
            Contact contact = _contactsService.GetContact(contactId);
            return Ok(new { contact });
        }

        [HttpGet("")]
        public IActionResult GetContacts()
        {
            var contacts = _contactsService.GetAllContacts();
            return Ok(new { contacts });
        }

        [HttpPost("")]
        public IActionResult AddContact([FromBody]AddContactRequestModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var contact = _mapper.Map<Contact>(model);
            _contactsService.AddContact(contact);
            return Ok(new { contact });
        }

        [HttpPost("{contactId}")]
        public IActionResult UpdateContact(int contactId, [FromBody]UpdateContactRequestModel model)
        {
            if (contactId <= 0) throw new ArgumentOutOfRangeException(nameof(contactId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var contact = _mapper.Map<Contact>(model);
            contact.Id = contactId;
            _contactsService.UpdateContact(contact);

            return Ok();
        }

    }
}
