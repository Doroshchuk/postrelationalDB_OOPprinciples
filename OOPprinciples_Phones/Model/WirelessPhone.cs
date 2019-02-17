using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model
{
    public abstract class WirelessPhone : Phone
    {
        private int _hour;

        public WirelessPhone(int year, int hour) : base(year)
        {
            _hour = hour;
        }
    }
}
