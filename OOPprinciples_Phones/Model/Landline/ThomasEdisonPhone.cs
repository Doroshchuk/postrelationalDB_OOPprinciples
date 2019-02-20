using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model.Landline
{
    public class ThomasEdisonPhone : LandlinePhone
    {
        public ThomasEdisonPhone(int year) : base(year)
        {

        }

        private void KeepConnection()
        {
            Console.WriteLine("Вращайте ручку!");
        }

        public override void Call(string outputNumber)
        {
            KeepConnection();
            base.Call(outputNumber);
        }
    }
}
