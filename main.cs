using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTicket
{
    class main
    {
        static void Main(string[] args)
        {
            // object
            planeTicket ticket = new planeTicket();
            planeTicket ticket2 = new planeTicket();

            ticket.Origin = "Yogyakarta";
            ticket.Destination = "PKU";
            ticket.Cost = 1500000;
            ticket.Currency = "IDR";

            ticket2.Origin = "Jakarta";
            ticket2.Destination = "PKU";
            ticket2.Cost = 50;
            ticket2.Currency = "USD";

            ticket.printSummary();
            ticket2.printSummary();

            Console.ReadKey();
        }
    }
}
