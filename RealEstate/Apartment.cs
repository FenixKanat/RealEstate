using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Apartment:Residential
    {

        public int numOfRooms { get; set; }
        public int apartmentRent { get; set; }

        public int apartmentSize { get; set; }


        public override void DisplayDetails()
        {
            Console.WriteLine($"Apartment ID: {ID}");
            Console.WriteLine($"Apartment address: {Address.Street}, {Address.City}, {Address.ZipCode}, {Address.Countries}");
            Console.WriteLine($"Apartment Rooms: {numOfRooms}");
            Console.WriteLine($"Apartment Rent: {apartmentRent}");
            Console.WriteLine($"Apartment Size: {apartmentSize}");

        }
    }
}
