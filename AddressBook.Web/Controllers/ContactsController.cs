using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Web.Controllers
{
    [Route("api/contacts")]
    public class ContactsController:Controller
    {
        [HttpGet("")]
        public IActionResult GetContact()
        {
            throw new NotImplementedException();
        }

        [HttpPost("")]
        public IActionResult AddContact()
        {
            throw new NotImplementedException();
        }

        [HttpPost("{contactId")]
        public IActionResult UpdateContact()
        {
            throw new NotImplementedException();
        }

    }
}
