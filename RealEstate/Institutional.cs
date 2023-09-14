using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal abstract class Institutional:IEstate
    {

        public string ID { get; set; }
        public Address Address { get; set; }

        public abstract void DisplayDetails();
    }
}
