using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{

    public enum typeOfVilla { 
        RomanVilla,
        PoolVilla,
        LuxuryVilla
    }
    internal class Villa:Residential
    {
        public typeOfVilla VillaType {
            get; set;
        }

    }
}
