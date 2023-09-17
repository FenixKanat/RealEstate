using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal abstract class Commercial:IEstate
    {
        public int ID { get; set; }

        public double Size { get; set; }

        public int Rooms { get; set; }

        public double Rent { get; set; }
        public Address Address { get; set; }


    }
}
