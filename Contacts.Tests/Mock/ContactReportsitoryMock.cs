using System;
using System.Collections.Generic;

namespace Sms.Demo.Contacts.Tests
{
    /// <summary>
    /// Mock для репозитория контактов
    /// </summary>
    internal class ContactReportsitoryMock : IContactRepository
    {
        #region Fields

        private IEnumerable<Contact> _contacts = Array.Empty<Contact>();

        #endregion

        #region IContactRepository

        public IEnumerable<Contact> GetAll()
        {
            return _contacts;
        }

        public void Update(IEnumerable<Contact> contacts)
        {
            _contacts = contacts;
        }

        #endregion
    }
}
