using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Sms.Demo.Contacts
{
    /// <summary>
    /// Репозиторий контактов на основе JSON файла
    /// </summary>
    public class JsonContactRepository : IContactRepository
    {
        #region Fields

        private readonly FileInfo _fileInfo;

        #endregion

        #region Constructors

        public JsonContactRepository(FileInfo fileInfo)
        {
            _fileInfo = fileInfo;
        }

        #endregion

        #region IContactRepository

        /// <inheritdoc/>
        public IEnumerable<Contact> GetAll()
        {
            return JsonConvert.DeserializeObject<Contact[]>(File.ReadAllText(_fileInfo.FullName));
        }

        /// <inheritdoc/>
        public void Update(IEnumerable<Contact> contacts)
        {
            File.WriteAllText(_fileInfo.FullName, JsonConvert.SerializeObject(contacts, Formatting.Indented));
        }

        #endregion
    }
}
