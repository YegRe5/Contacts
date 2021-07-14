namespace Sms.Demo.Contacts
{
    /// <summary>
    /// Контакт
    /// </summary>
    public class Contact
    {
        #region Properties

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Телефонный номер
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Адрес почты
        /// </summary>
        public string Email { get; set; }

        #endregion
    }
}
