using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model
{
    public class Contact
    {
        public string Name { get; private set; }
        public List<string> Numbers { get; set; }

        public Contact(string name, string number)
        {
            Name = name;
            Numbers = new List<string>();
            Numbers.Add(number);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Contact);
        }

        public bool Equals(Contact contact)
        {
            return contact != null &&
                        contact.Name == Name;
        }
    }
}
