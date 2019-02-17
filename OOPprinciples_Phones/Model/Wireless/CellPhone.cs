using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model.Wireless
{
    public class CellPhone : WirelessPhone
    {
        public CellPhone(int year, int hour) : base(year, hour)
        {

        }

        public override void Call(int outputNumber)
        {
            Console.WriteLine("Осуществляется входящий вызов с номера '" + outputNumber + "' на текущий номер '" + Number + "'.");
        }

        public override void Ring(int inputNumber)
        {
            Console.WriteLine("Осуществляется исходящий вызов с текущего номера '" + Number + "' на номер другого абонента '" + inputNumber + "'.");
        }
    }
}
