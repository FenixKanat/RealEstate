using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Residential : IEstate
    {
        public String ID { get; set; }
        public Address Address { get; set; }

       // public abstract void DisplayDetails() { }
    }
}
