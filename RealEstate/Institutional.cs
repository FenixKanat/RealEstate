using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal abstract class Institutional:IEstate
    {

        public string ID { get; set; }
        public Address Address { get; set; }

        private int _id;
        private int rooms;

        private double size;
        private double rent;


        public int Id {
            get { return _id; }
            set { _id = value; }
        }

        public int getRoom {
            get { return rooms; }
            set { rooms = value; }
        }

        public double getSize
        {
            get { return size; }
            set { size = value; }
        }

        public double getRent
        {
            get { return rent; }
            set { rent = value; }
        }
        public abstract void DisplayDetails();
    }
}
