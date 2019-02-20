using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model
{
    public abstract class Phone
    {
        private int _year;

        public Phone(int year)
        {
            _year = year;
        }

        public abstract void Call(string outputNumber);

        public abstract void Ring(string inputNumber);
    }
}
