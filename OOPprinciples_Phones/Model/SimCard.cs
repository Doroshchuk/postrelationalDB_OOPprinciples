using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model
{
    public class SimCard
    {
        private List<Contact> _contacts;

        public SimCard()
        {
            _contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            if (!_contacts.Contains(contact))
            {
                _contacts.Add(contact);
                Console.WriteLine("Контакт успешно добавлен!");
            }
            else Console.WriteLine("Контакт с таким именем уже существует!");
        }

        public Contact GetContact(string name)
        {
            return _contacts.FirstOrDefault(x => x.Name == name);
        }
    }
}
