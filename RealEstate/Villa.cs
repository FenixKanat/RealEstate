using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Villa:Residential
    {

        public int numOfRooms { get; set; }
        public int villaRent { get; set; }
        public int villeSize { get; set; }
      


        public override void DisplayDetails() {
            Console.WriteLine($"Villa ID: {ID}");
            Console.WriteLine($"Villa Address: {Address.Street}, {Address.City}, {Address.ZipCode}, {Address.Countries}");
            Console.WriteLine($"Number of rooms: {numOfRooms}");
            Console.WriteLine($"Villa size: {villeSize}");
            Console.WriteLine($"Villa rent: {villaRent}");
        }





    }
}
