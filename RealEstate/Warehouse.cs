using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Warehouse:Commercial
    {

        public int sizeOfWH { get; set; }
        public int rentOfWH { get; set; }
        public override void DisplayDetails()
        {
            Console.WriteLine($"WareHouse ID: {ID}");
            Console.WriteLine($"WareHouse Address: {Address.Street}, {Address.City}, {Address.ZipCode}, {Address.Countries}");
            Console.WriteLine($"WareHouse Size: {sizeOfWH}");
            Console.WriteLine($"WareHouse Rent: {rentOfWH}");
            
        }
    }
}
