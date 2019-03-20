using OOPprinciples_Phones.Model;
using OOPprinciples_Phones.Model.Landline;
using OOPprinciples_Phones.Model.Wireless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCard simCard = new SimCard("+38(096)5236888");
            simCard.AddContact(new Contact("Mum", "+38(096)5236845"));
            simCard.AddContact(new Contact("Dad", "+38(096)5236889"));
            Contact brother = new Contact("Brother", "+38(096)5233873");
            brother.Numbers.Add("+38(093)5233779");
            simCard.AddContact(brother);

            LandlinePhone landlinePhone = new LandlinePhone(2005);
            landlinePhone.Number = "596235";
            ThomasEdisonPhone thomasEdisonPhone = new ThomasEdisonPhone(1980);
            thomasEdisonPhone.Number = "562348";
            CellPhone cellphone = new CellPhone(2011, 5, simCard);
            Smartphone smartphone = new Smartphone(2018, 48, "Android", simCard);
            VideoPhone videoPhone = new VideoPhone(2017, 24, simCard);

            User user = new User("Daria");
            Console.WriteLine("LandlinePhone");
            user.CallAnotherUser("395698", landlinePhone);
            Console.WriteLine("*************************");
            user.AcceptIncomingCall("798562", landlinePhone);
            Console.WriteLine("*************************");
            Console.WriteLine("ThomasEdisonPhone");
            user.CallAnotherUser("984256", thomasEdisonPhone);
            Console.WriteLine("*************************");
            user.AcceptIncomingCall("658423", thomasEdisonPhone);
            Console.WriteLine("*************************");
            Console.WriteLine("CellPhone");
            user.CallAnotherUser("Mum", cellphone);
            Console.WriteLine("*************************");
            user.AcceptIncomingCall("+38(096)5236889", cellphone);
            Console.WriteLine("*************************");
            Console.WriteLine("Smartphone");
            user.CallAnotherUser("+38(097)5428953", smartphone);
            Console.WriteLine("*************************");
            user.AcceptIncomingCall("+38(097)5428953", smartphone);
            Console.WriteLine("*************************");
            Console.WriteLine("VideoPhone");
            user.CallAnotherUser("+38(097)5428988", videoPhone);
            Console.WriteLine("*************************");
            user.AcceptIncomingCall("+38(097)5477753", videoPhone);
            Console.WriteLine("*************************");
            Console.ReadLine();
        }
    }
}
