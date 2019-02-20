using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model.Wireless
{
    public class VideoPhone : CellPhone
    {
        public VideoPhone(int year, int batteryTime) : base(year, batteryTime)
        {

        }

        public override void Call(string outputNumber)
        {
            Console.WriteLine("Осуществляется исходящий видео-звонок с текущего номера '" + SimCard.Number + "' на номер другого абонента '" + outputNumber + "'.");
        }

        public override void Ring(string inputNumber)
        {
            Console.WriteLine("Осуществляется входящий видео-звонок с номера '" + inputNumber + "' на текущий номер '" + SimCard.Number + "'.");
        }
    }
}
