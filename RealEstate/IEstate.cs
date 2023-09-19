using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal interface IEstate
    {
        int ID { get; set; }
        Address Address { get; set; }

        double Size { get; set; }

        int Rooms { get; set; }

        double Rent { get; set; }

 
    }
}