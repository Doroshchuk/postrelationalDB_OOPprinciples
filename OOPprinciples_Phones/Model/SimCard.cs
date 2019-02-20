using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model
{
    public class SimCard
    {
        public string Number { get; private set; }
        public List<Contact> Contacts { get; private set; }

        public SimCard(string number)
        {
            Number = number;
            Contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            if (!Contacts.Contains(contact))
            {
                Contacts.Add(contact);
                Console.WriteLine("Контакт успешно добавлен!");
            }
            else Console.WriteLine("Контакт с таким именем уже существует!");
        }

        public Contact GetContactByName(string name) => Contacts.FirstOrDefault(x => x.Name == name);

        public Contact GetContactByNumber(string number) => Contacts.FirstOrDefault(x => x.Numbers.Contains(number));
    }
}
