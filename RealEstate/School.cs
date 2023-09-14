using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class School:Institutional

    {

        public int numOfClasses { get; set; }
        public int schoolSize { get; set; }
            
        public int schoolRent { get; set; }
        public override void DisplayDetails()
        {

            Console.WriteLine($"School ID: {ID}");
            Console.WriteLine($"School Address: {Address.Street}, {Address.City}, {Address.ZipCode}, {Address.Countries}");
            Console.WriteLine($"School Rent: {schoolRent}");
            Console.WriteLine($"School Size: {schoolSize}");
     


        }
    }
}
