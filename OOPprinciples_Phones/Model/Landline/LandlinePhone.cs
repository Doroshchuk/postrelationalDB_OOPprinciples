using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model.Landline
{
    public class LandlinePhone : Phone
    {
        public string Number { get; set; }

        public LandlinePhone(int year) : base(year)
        {

        }

        public override void Call(string outputNumber)
        {
            string currentOutputNumber = "";
            foreach (char digit in outputNumber)
            {
                currentOutputNumber += digit;
                Console.WriteLine("Введено номер: '" + currentOutputNumber + "'.");
            }
            Console.WriteLine("Вызов осуществляется!");
        }

        public override void Ring(string inputNumber)
        {
            Console.WriteLine("Телефон звонит!");
        }
    }
}
