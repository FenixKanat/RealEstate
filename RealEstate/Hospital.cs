using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Hospital:Institutional
    {
        public int numOfRooms { get; set; }
        public int sizeOfHosp { get; set; }

        public int rentOfHosp { get; set; }
       
        public override void DisplayDetails()
        {

            Console.WriteLine($"Hospital ID: {ID}");
            Console.WriteLine($"Hospital Address: {Address.Street}, {Address.City}, {Address.ZipCode}, {Address.Countries}");
            Console.WriteLine($"Number of rooms: {numOfRooms}");
            Console.WriteLine($"Hospital size: {sizeOfHosp}");
            Console.WriteLine($"Hospital rent: {rentOfHosp}");
        }
    }
}
