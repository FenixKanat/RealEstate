using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Villa:Residential
    {

        public int numOfRoomsInTotal { get; set; }
        public int numOfGuestRooms { get; set; }
        public int numOfBedRooms { get; set; }
        public int numOfWc { get; set; }
        public double villaSize { get; set; }


        public override void DisplayDetails() {
            Console.WriteLine($"Villa ID: {ID}");
            Console.WriteLine($"Address: {Address.Street}, {Address.City}, {Address.ZipCode}, {Address.Country}");
            Console.WriteLine($"Number of rooms: {numOfRoomsInTotal}");
            Console.WriteLine($"Number of guest rooms: {numOfGuestRooms}");
            Console.WriteLine($"Number of bed rooms: {numOfBedRooms}");
            Console.WriteLine($"Number of WC: { numOfWc}");
            Console.WriteLine($"Villa size: {villaSize}");
        }





    }
}
