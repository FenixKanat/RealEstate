using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class University:Institutional
    {

        public int numOfClasses { get; set; }
        public int sizeOfUni { get; set; }

        public int rentOfUni { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"University ID: {ID}");
            Console.WriteLine($"University Address: {Address.Street},{Address.City},{Address.ZipCode}, {Address.Countries}");
            Console.WriteLine($"Number of classrooms: {numOfClasses}");
            Console.WriteLine($"Size of University: {sizeOfUni}");
            Console.WriteLine($"Rent of University: {rentOfUni}");
        }
    }
}
