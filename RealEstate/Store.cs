using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Store:Commercial
    {
       
        public int storeRent { get; set; }

        public int storeSize { get; set; }


        public override void DisplayDetails()
        {
            Console.WriteLine($"Store ID:  { ID }");
            Console.WriteLine($"Store address: {Address.Street} ,{Address.City} ,{Address.ZipCode} ,{Address.Countries}");
            Console.WriteLine($"Store Rent: {storeRent}");
            Console.WriteLine($"Store Size: {storeSize}");
            
        }
    }
}
