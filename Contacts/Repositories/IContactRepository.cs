using System.Collections.Generic;

namespace Sms.Demo.Contacts
{ 
    /// <summary>
    /// Контракт репозитория контактов
    /// </summary>
    public interface IContactRepository
    {
        /// <summary>
        /// Вернуть все контакты
        /// </summary>
        /// <returns>Список контактов</returns>
        public IEnumerable<Contact> GetAll();

        /// <summary>
        /// Обновить контакты
        /// </summary>
        /// <param name="contact">Список контактов</param>
        public void Update(IEnumerable<Contact> contacts);
    }
}
