using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    public enum hospitalType
    {
        Private,
        Communal
    }
    internal class Hospital:Institutional
    {
        public hospitalType typeOfHospital { get; set; }
       
    }
}
