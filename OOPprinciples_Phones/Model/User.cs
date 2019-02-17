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

        public void callAnotherUser(string number, Phone phone)
        {
            phone.Call(number);
        }
    }
}
