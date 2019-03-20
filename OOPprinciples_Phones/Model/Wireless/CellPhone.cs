using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model.Wireless
{
    public class CellPhone : WirelessPhone
    {
        public SimCard SimCard { get; private set; }

        public CellPhone(int year, int batteryTime, SimCard simCard) : base(year, batteryTime)
        {
            SimCard = simCard;
        }

        public override void Call(string outputNumber)
        {
            Console.WriteLine("Осуществляется исходящий вызов с текущего номера '" + SimCard.Number + "' на номер другого абонента '" + outputNumber + "'.");
        }

        public override void Ring(string inputNumber)
        {
            Console.WriteLine("Осуществляется входящий вызов с номера '" + inputNumber + "' на текущий номер '" + SimCard.Number + "'.");
            
        }
    }
}
