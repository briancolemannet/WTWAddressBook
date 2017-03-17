using System;
using System.Collections.Generic;
using AddressBook.Domain.Entities;
using AddressBook.Domain.Repositories;
using AddressBook.Domain.Services;
using Moq;
using NUnit.Framework;

namespace AddressBook.Domain.Tests.Services
{
    [TestFixture]
    public class ContactsServiceTests
    {
        [Test]
        public void GetAllContacts_ReturnsAllContacts_WhenCalled()
        {
            var moqContactsRepository = new Mock<IContactsRepository>();
            var service = new ContactsService(moqContactsRepository.Object);
            var contacts = new List<Contact>();

            moqContactsRepository.Setup(r => r.GetAllContacts()).Returns(contacts);

            var result = service.GetAllContacts();

            Assert.That(result, Is.EqualTo(contacts));
        }

        [Test]
        public void GetContact_ThrowsException_InvalidId()
        {
            var moqContactsRepository = new Mock<IContactsRepository>();
            var service = new ContactsService(moqContactsRepository.Object);

            moqContactsRepository.Setup(r => r.GetContact(0)).Throws<Exception>();
            
            Assert.That(() => service.GetContact(0), Throws.Exception);
        }


    }
}