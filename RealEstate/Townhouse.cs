using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Townhouse:Residential
    {

        public int numOfRooms { get; set; }
        public int sizeOfTH { get; set; }

        public int rentOfTH { get; set; }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Townhouse ID: {ID}");
            Console.WriteLine($"Townhouse Address: {Address.Street}, {Address.City}, {Address.ZipCode}, {Address.Countries}");
            Console.WriteLine($"Number of rooms: {numOfRooms}");
            Console.WriteLine($"Size of Townhouse: {sizeOfTH}");
            Console.WriteLine($"Rent of Townhouse: {rentOfTH}");
        }
    }
}
