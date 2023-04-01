using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTicket
{
    class planeTicket
    {
        // properties
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int Cost { get; set; }
        public string Currency { get; set; }

        // method
        public void printSummary()
        {
            Console.WriteLine("Origin : {0}", Origin);
            Console.WriteLine("Destination : {0}", Destination);
            Console.WriteLine("Cost : {0} ({1})", Cost, Currency);

            if(Currency == "IDR")
            {
                Console.WriteLine("Convert to Dollar : {0}", Cost / 15000);
            } 
            else if(Currency == "USD") 
            {
                Console.WriteLine("Convert to Rupiah : {0}", Cost * 15000);
            }

            Console.WriteLine();
           
        }
    }
}
