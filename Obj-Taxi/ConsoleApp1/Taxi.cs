using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    public class Taxi
    {
        // property
        public string DriverName;
        public bool onDuty;
        public int NumPassenger;

        // method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", onDuty ? "yes" : "no");
            Console.WriteLine("Number of Passenger : {0} \n", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} sedang mengantar penumpang", DriverName);
        }
    }
}
