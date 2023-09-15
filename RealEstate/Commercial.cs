using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal abstract class Commercial:IEstate
    {
        public string ID { get; set; }
        public Address Address { get; set; }

        private int _id;
        private int rooms;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int getRoom
        {
            get { return rooms; }
            set { rooms = value; }
        }


        public abstract void DisplayDetails();

    }
}
