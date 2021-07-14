using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Sms.Demo.Contacts
{
    /// <summary>
    /// Сервис контактов
    /// </summary>
    public class ContactService : IContactService
    {
        #region Fileds

        private readonly IContactRepository _contactRepository;
        private readonly ILogger<ContactService> _logger;

        #endregion

        #region Constructor

        public ContactService(IContactRepository contactRepository, ILogger<ContactService> logger)
        {
            _contactRepository = contactRepository;
            _logger = logger;
        }

        #endregion

        #region IContactService

        public IEnumerable<Contact> GetAll()
        {
            _logger.LogInformation("Список контактов был запрошен!");
            return _contactRepository.GetAll();
        }

        public void Save(IEnumerable<Contact> contacts)
        {
            _contactRepository.Update(contacts);
            _logger.LogInformation("Список контактов был обновлен!");
        }

        #endregion
    }
}
