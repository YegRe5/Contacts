using System;
using System.Collections.Generic;

namespace Sms.Demo.Contacts
{
    /// <summary>
    /// Контракт сервиса контактов
    /// </summary>
    public interface IContactService : IDisposable
    {
        /// <summary>
        /// Вернуть все контакты
        /// </summary>
        /// <returns>Список контактов</returns>
        IEnumerable<Contact> GetAll();

        /// <summary>
        /// Сохранить контакты
        /// </summary>
        /// <param name="contact">Список контактов</param>
        void Save(IEnumerable<Contact> contacts);
    }
}
