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
        string ID { get; set; }
        Address Address { get; set; }
    }
}