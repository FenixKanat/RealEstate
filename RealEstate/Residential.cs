using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal abstract class Residential : IEstate
    {
        public String ID { get; set; }
        public Address Address { get; set; }

        private int _id;
        private int room;
        public int Id {

            get{ return _id; }
            set{ _id = value; }
        }

        public int getRoom
        {
            get { return room; }
            set { room = value; }
        }

        public abstract void DisplayDetails();
    }
}
