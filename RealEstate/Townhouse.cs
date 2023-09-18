using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    public enum typeOfTownHouse { 
    Traditional,
    Stacked,
    Duplex,
    Triplex}
    internal class Townhouse:Residential
    {

        public typeOfTownHouse townHouseType {
            get; set;
        }
    }
}
