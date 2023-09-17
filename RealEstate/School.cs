using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{

    public enum schoolType { 
        Private,
        Communal
    }
    internal class School:Institutional

    {
        public schoolType typeOfSchool { get; set; }


    }
}
