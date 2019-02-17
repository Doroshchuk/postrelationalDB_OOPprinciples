using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model.Landline
{
    public class LandlinePhone : Phone
    {
        public LandlinePhone(int year) : base(year)
        {

        }

        public override void Call(int outputNumber)
        {
            string currentOutputNumber = "";
            foreach (char digit in outputNumber.ToString())
            {
                currentOutputNumber += digit;
                Console.WriteLine("Введено номер: '" + currentOutputNumber + "'.");
            }
            Console.WriteLine("Вызов осуществляется!");
        }

        public override void Ring(int inputNumber)
        {
            Console.WriteLine("Телефон звонит!");
        }
    }
}
