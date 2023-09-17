using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{

    public enum UniversityType { 
        Private,
        Communal
    }
    internal class University:Institutional
    {
   
        public UniversityType typeOfUni { get; set; }
       
    }
}
