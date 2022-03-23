namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {
            // create taxi obj
            Taxi taxi = new Taxi();

            // set property value
            taxi.DriverName = "Jono";
            taxi.onDuty = true;
            taxi.NumPassenger = 10;

            // call method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}