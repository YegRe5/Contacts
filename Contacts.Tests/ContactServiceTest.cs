using NUnit.Framework;
using System;
using System.Linq;

namespace Sms.Demo.Contacts.Tests
{
    [TestFixture]
    public class ContactServiceTest
    {
        #region Fields

        private IContactService _contactService;
        private IContactRepository _contactRepository;

        #endregion

        [SetUp]
        public void Setup()
        {
            var logger = new LoggerMock<ContactService>();

            _contactRepository = new ContactReportsitoryMock();
            _contactService = new ContactService(_contactRepository, logger);
        }

        #region Test methods

        [Test]
        public void Save_Contacts()
        {
            // Arrange
            var contacts = new Contact[]
            {
                new Contact() { Name = "Test1" },
                new Contact() { Name = "Test2" },
                new Contact() { Name = "Test3" }
            };

            // Act
            _contactService.Save(contacts);

            // Assert
            contacts = _contactRepository
                .GetAll()
                .ToArray();

            Assert.AreEqual(contacts.Length, 3);
        }

        [Test]
        public void GetAll_Contacts_ReturnsAllContacts()
        {
            // Arrange
            var contacts = new Contact[]
            {
                new Contact() { Name = "Test1" },
                new Contact() { Name = "Test2" },
                new Contact() { Name = "Test3" }
            };

            _contactRepository.Update(contacts);

            // Act
            _contactService.GetAll();

            // Assert
            contacts = _contactService
                .GetAll()
                .ToArray();

            Assert.AreEqual(contacts.Length, 3);
        }

        [Test]
        public void Save_ContactWithEmptyName_ThrowArgumentException()
        {
            // Arrange
            var contact = new Contact();

            // Act
            TestDelegate saveContact = () => { _contactService.Save(new Contact[] { contact }); };

            // Assert
            Assert.Throws(typeof(ArgumentException), saveContact);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _contactService.Dispose();
        }
    }
}