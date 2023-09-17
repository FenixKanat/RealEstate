using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{

    public enum StoreType
    {
        Grocery,
        Electronics,
        Clothing,
        Bookstore
    }
    internal class Store:Commercial
    {

        public StoreType typeOfStore { get; set; }


    }
}
