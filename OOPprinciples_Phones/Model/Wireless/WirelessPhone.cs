using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model.Wireless
{
    public abstract class WirelessPhone : Phone
    {
        private int _batteryTime;
        public SimCard SimCard { get; set; }

        public WirelessPhone(int year, int batteryTime) : base(year)
        {
            _batteryTime = batteryTime;
        }
    }
}
