using OOPprinciples_Phones.Model.Landline;
using OOPprinciples_Phones.Model.Wireless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model
{
    public class User
    {
        private string _name;

        public User(string name)
        {
            _name = name;
        }

        public void CallAnotherUser(string outputNumber, LandlinePhone phone)
        {
            phone.Call(outputNumber);
        }

        public void CallAnotherUser(string contactNameOrNumber, WirelessPhone phone)
        {
            Contact contact = phone.SimCard.GetContactByName(contactNameOrNumber);
            string outputNumber = contact != null ? contact.Numbers.First() : contactNameOrNumber;
            phone.Call(outputNumber);
        }


        public void AcceptIncomingCall(string inputNumber, WirelessPhone phone)
        {
            Contact contact = phone.SimCard.GetContactByNumber(inputNumber);
            Console.WriteLine(contact != null ? contact.Name : "Неизвестный абонент");
            phone.Ring(inputNumber);
        }

        public void AcceptIncomingCall(string inputNumber, LandlinePhone phone)
        {
            phone.Ring(inputNumber);
        }
    }
}
