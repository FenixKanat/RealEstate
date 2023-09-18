using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    public enum typesOfWareHouse { 
    Distributioncenter,
    Retail,
    Public, 
    Private
    }
    internal class Warehouse:Commercial
    {
        public typesOfWareHouse WarehouseType { get; set; }
    }
}
