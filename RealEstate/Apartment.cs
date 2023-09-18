using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{

    public enum typeOfApartment { 
        StudioApartment,
        LoftApartment,
        StudentApartment
    }
    internal class Apartment:Residential
    {
        public typeOfApartment ApartmentType {
            get;set;
        }
    }
}
