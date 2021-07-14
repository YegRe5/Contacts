using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Sms.Demo.Contacts
{
    /// <summary>
    /// Контроллер контактов
    /// </summary>
    public class ContactController : ControllerBase
    {
        #region Fields

        private readonly IContactService _contactService;

        #endregion

        #region Constructor

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        #endregion

        #region Web methods

        [HttpGet]
        public IEnumerable<Contact> GetAll()
        {
            return _contactService.GetAll();
        }

        [HttpPost]
        public void Save([FromBody] IEnumerable<Contact> contacts)
        {
            _contactService.Save(contacts);
        }

        #endregion
    }
}
